using System;
using Gtk;
using MySql.Data.MySqlClient;
using RegisComida;
using System.IO;

public partial class MainWindow : Gtk.Window
{
    private BaseDato datos = new BaseDato();
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        datos.CambiarDatabase("localhost", "regis_comida", "root", "");
        CellRendererPixbuf activeCell = new Gtk.CellRendererPixbuf();
        CellRendererText utilNameCell = new CellRendererText();
        TreeViewColumn Columnaid_registro = new TreeViewColumn
        {
            Title = "id registro",
            Expand = false,
            Sizing = TreeViewColumnSizing.Autosize
        };
        //Columnaid_registro.PackStart(activeCell, false);
        //Columnaid_registro.AddAttribute(activeCell, "pixbuf", 6);
        Tabla.AppendColumn(Columnaid_registro);
        Columnaid_registro.PackStart(utilNameCell, true);
        Columnaid_registro.AddAttribute(utilNameCell, "text", 0);
        TreeViewColumn Columnaimagenid = new TreeViewColumn
        {
            Title = "Imagen",
            Expand = true,
            Sizing = TreeViewColumnSizing.Fixed
        };
        //Columnaimagenid.PackStart(activeCell, false);
        //Columnaimagenid.AddAttribute(new Gtk.CellRendererPixbuf(), "pixbuf", 1);
        Tabla.AppendColumn("Imagen", new Gtk.CellRendererPixbuf(), "pixbuf", 1);
        TreeViewColumn Columnanombre = new TreeViewColumn
        {
            Title = "Nombre",
            Expand = true,
            Sizing = TreeViewColumnSizing.Fixed
        };
        Columnanombre.PackStart(activeCell, false);
        Columnanombre.AddAttribute(activeCell, "pixbuf", 6);
        Tabla.AppendColumn(Columnanombre);
        Columnanombre.PackStart(utilNameCell, true);
        Columnanombre.AddAttribute(utilNameCell, "text", 2);
        TreeViewColumn Columnafecha = new TreeViewColumn
        {
            Title = "Fecha",
            Expand = true,
            Sizing = TreeViewColumnSizing.Fixed
        };
        Columnafecha.PackStart(activeCell, false);
        Columnafecha.AddAttribute(activeCell, "pixbuf", 6);
        Tabla.AppendColumn(Columnafecha);
        Columnafecha.PackStart(utilNameCell, true);
        Columnafecha.AddAttribute(utilNameCell, "text", 3);
        //Se inserte
        registro = new Gtk.ListStore(typeof(string), typeof(Gdk.Pixbuf), typeof(string), typeof(string));
        Tabla.Model = registro;
        ShowAll();
        //Se supone que de esta manera es una ruta relativa
        string[] paths = { @"/home", "josue-user", "Repos", "ProyectoC","C#","RegisComida","RegisComida","Imagenes", "pizza.jpeg" };
        string fullPath = System.IO.Path.Combine(paths);
        //image1.Pixbuf = new Gdk.Pixbuf(@"/home/josue-user/Repos/ProyectoC/C#/RegisComida/RegisComida/Imagenes/pizza.jpeg");
        image1.Pixbuf = new Gdk.Pixbuf(fullPath);
    }
    ListStore registro;
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void btnSalir_Clicked(object sender, EventArgs e)
    {
        Application.Quit();
    }
    void MensajeError(string x)
    {
        MessageDialog mensaje = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, "Error: " + x);
        mensaje.Run();
        mensaje.Destroy();
    }

    protected void btnInsertar_Clicked(object sender, EventArgs e)
    {
    }

    protected void btnMostrar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Mostrar();
        }
        catch (Exception ex)
        {
            MensajeError("" + ex);
        }
    }
    private void Mostrar()
    {
        string query;
        MySqlCommand valor;
        MySqlDataReader reader;
        try
        {

            registro.Clear();
            query = "SELECT id_registro, comida.imagenid, comida.nombre, registro.fecha " +
            	"FROM registro, comida " +
            	"WHERE registro.id_comida = comida.id_comida";
            datos.Conectar();
            valor = datos.ConsultarComando(query, "");
            reader = valor.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse("" + reader["imagenid"]);
                var imagenes = new Gdk.Pixbuf(ObtenerImagen(id));
                registro.AppendValues($"{reader["id_registro"].ToString()}", imagenes, $"{reader["nombre"].ToString()}", $"{reader["fecha"].ToString()}");
            }
            reader.Close();
            datos.Desconectar();
        }catch(MySqlException exx)
        {
            throw new Exception("Error" + exx);
        }
        catch(Exception ex)
        {
            if(ex == null)
            {
                MensajeError("Esta vaicio");
            }
            string text = ex.ToString();
            MessageDialog mensaje = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Info, ButtonsType.Ok, $"Error {text}");
            mensaje.Run();
            mensaje.Destroy();
        }
    }
    private string ObtenerImagen(int imagenid)
    {
        try
        {
            string UbicacionImagen = "pizza.jpeg";
            switch (imagenid)
            {
                case 0:
                    UbicacionImagen = "pizza.jpeg";
                    break;
                case 1:
                    UbicacionImagen = "hamPollo.jpeg";
                    break;
                default:
                    break;
            }
            string[] paths = { @"/home", "josue-user", "Repos", "ProyectoC", "C#", "RegisComida", "RegisComida", "Imagenes", UbicacionImagen };
            string fullPath = System.IO.Path.Combine(paths);
            return fullPath;
        }
        catch (Exception)
        {
            throw new Exception("Error al cargar la imagen");
        }

    }
}
