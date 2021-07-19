using System;
using Gdk;
using Gtk;
using MySql.Data.MySqlClient;

namespace RegisComida
{
    public partial class WinAddComida : Gtk.Window
    {
        BaseDato datos;
        public WinAddComida(BaseDato d) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            datos = d;
            //fixed1.ModifyBg(StateType.Normal, new Color(0, 0, 0));
            Mostrar();
        }

        protected void Regresar(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        protected void Añadir_Clicked(object sender, EventArgs e)
        {
            try
            {
                datos.Conectar();
                string x = "INSERT INTO `comida` (`id_comida`, `imagenid`, `nombre`) " +
                    $"VALUES ('{spincomida.Text}', '{spinimagen.Text}', '{entrynombre.Text}');";
                MessageDialog md = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Question, ButtonsType.YesNo, "¿Desea continuar con la operacion?. \n" + x);
                md.SetPosition(WindowPosition.Center);
                ResponseType result = (ResponseType)md.Run();
                if (result == ResponseType.Yes)
                {
                    datos.Insertar(x);
                    Mensaje("Se a insertado el registro");
                }
                else
                {
                    Mensaje("Se cancelo la operacion");
                }
                md.Destroy();
            }
            catch (Exception ex)
            {
                MessageDialog mensaje = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, ""+ex);
                mensaje.Run();
                mensaje.Destroy();
            }
            finally
            {
                datos.Desconectar();
            }
        }

        protected void Modificar_Clicked(object sender, EventArgs e)
        {
            //string x = "UPDATE `comida` SET `id_comida` = '21', `imagenid` = '21', `nombre` = 'pruebax' WHERE `comida`.`id_comida` = 20;";
        }

        protected void Update_Clicked(object sender, EventArgs e)
        {
            //Mostrar();
        }
        private void Mostrar()
        {
            string query;
            MySqlCommand valor;
            MySqlDataReader reader;
            int count = 0;
            try
            {
                //registro.Clear();
                //cmbComidas.Clear(); Bug de windows?
                query = "SELECT * FROM `comida` ORDER BY imagenid DESC";
                datos.Conectar();
                valor = datos.ConsultarComando(query, "");
                reader = valor.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader["nombre"].ToString();
                    string x = $"{reader["imagenid"].ToString()}.- " + $"{name}";
                    cmbComidas.AppendText(x);
                    if(count==0)
                    {
                        cmbComidas.Entry.Text = x;
                    }
                    count++;
                }                
                reader.Close();
                datos.Desconectar();
            }
            catch (MySqlException exx)
            {

                MessageDialog mensaje = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, "Error: " + exx);
                mensaje.Run();
                mensaje.Destroy();
            }
            catch (Exception ex)
            {
                if (ex == null)
                {
                    MessageDialog mensajex = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, "Esta vacio");
                    mensajex.Run();
                    mensajex.Destroy();
                }
                string text = ex.ToString();
                MessageDialog mensaje = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Info, ButtonsType.Ok, $"Error {text}");
                mensaje.Run();
                mensaje.Destroy();
            }
            finally
            {
                datos.Desconectar();
            }
        }

        private void Mensaje(string x)
        {
            MessageDialog mensaje = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Info, ButtonsType.Ok, x);
            mensaje.Run();
            mensaje.Destroy();
        }

        private void CambiarId()
        {
            if (string.IsNullOrEmpty(spincomida.Text))//sea nulo o vacio
            {
                spincomida.Text = "0";
                spinimagen.Text = "0";
            }
            else
            {
                spinimagen.Text = spincomida.Text;

            }
        }

        protected void Spincomida_changed(object sender, EventArgs e)
        {
            CambiarId();
        }
    }
}
