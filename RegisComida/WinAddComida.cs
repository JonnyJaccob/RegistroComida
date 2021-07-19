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
        }

        protected void Regresar(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        protected void Añadir_Clicked(object sender, EventArgs e)
        {
        }

        protected void Modificar_Clicked(object sender, EventArgs e)
        {
        }

        protected void Update_Clicked(object sender, EventArgs e)
        {
            Mostrar();
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
    }
}
