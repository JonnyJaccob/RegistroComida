using System;
using System.Collections.Generic;
using Gtk;
using MySql.Data.MySqlClient;

namespace RegisComida
{
    public partial class WinComidas : Gtk.Window
    {
        BaseDato datos;
        public WinComidas(BaseDato bd) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            datos = bd;
            textview1.Editable = false;
        }

        protected void Salir_clicked(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void Mostrar()
        {
            string query;
            MySqlCommand valor;
            MySqlDataReader reader;
            List<string> list = new List<string>();
            textview1.Editable = true;
            try
            {

                //registro.Clear();
                query = "SELECT id_registro, comida.imagenid, comida.nombre, registro.fecha " +
                    "FROM registro, comida " +
                    "WHERE registro.id_comida = comida.id_comida " +
                    "ORDER BY registro.fecha  DESC";
                datos.Conectar();
                valor = datos.ConsultarComando(query, "");
                reader = valor.ExecuteReader();
                while (reader.Read())
                {
                    DateTime x = (DateTime)reader["fecha"];
                    string name = reader["nombre"].ToString();
                    if (ComprobarLista(name, ref list))
                    {
                        textview1.Buffer.Text += ($"{reader["nombre"].ToString()}      " + $"{CompararTiempo(x)} \n");
                    }
                }
                reader.Close();
                datos.Desconectar();
                textview1.Editable = false;
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

        protected void Mostrar_Clicked(object sender, EventArgs e)
        {
            Mostrar();
        } 
        private string CompararTiempo(DateTime t)
        {
            DateTime x = DateTime.Now;
            TimeSpan tiempo = x.Subtract(t);
            string y = ""+ x.ToString() + " "+ t.ToString() + " " + tiempo.ToString()+ "\nhora " + tiempo.Hours + "\ndias " + tiempo.Days;
            //MessageDialog mensajex = new MessageDialog(null, DialogFlags.DestroyWithParent , MessageType.Info, ButtonsType.Ok, y);
            //mensajex.Run();
            //mensajex.Destroy();
            if (tiempo.Days < 2)
            {
                return tiempo.Hours + "  Hrs.-"+tiempo.Days + "  Dias";
            }

            return tiempo.Days + "  Dias";
        }
        private bool ComprobarLista(string nombre,ref List<string> lista)
        {
            foreach (string item in lista)
            {
                if (item == nombre)
                {
                    return false;
                }
            }
            lista.Add(nombre);
            return true;
        }
    }
}
