using System;
using System.Diagnostics;
using Gtk;

namespace RegisComida
{
    public partial class Window2 : Gtk.Window
    {
        public Window2() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void On_clicked(object sender, EventArgs e)
        {
            Control("Encender");
        }


        protected void Off_clicked(object sender, EventArgs e)
        {
            Control("Apagar");
        }
        private void Control(string instruccion)
        {
            try
            {
                /*string _Command = "";
                if (instruccion == "Encender")
                {
                    _Command = $"sudo /opt/lampp/lampp start /n";
                }
                else
                {
                    _Command = $"sudo /opt/lampp/lampp stop /n";
                }
                _Command += $"{entContra.Text}";*/
                // Indicamos que deseamos inicializar el proceso cmd.exe junto a un comando de arranque.
                //(/C, le indicamos al proceso cmd que deseamos que cuando termine la tarea asignada se cierre el proceso).
                //Para mas informacion consulte la ayuda de la consola con cmd.exe /? 
                ProcessStartInfo procStartInfo = new ProcessStartInfo();

                // Indicamos que la salida del proceso se redireccione en un Stream
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
                procStartInfo.CreateNoWindow = false;//deberia ser true?
                //Inicializa el proceso
                Process proc = new Process
                {
                    StartInfo = procStartInfo
                };
                proc.Start();
                //Consigue la salida de la Consola(Stream) y devuelve una cadena de texto
                string result = proc.StandardOutput.ReadToEnd();
                //Muestra en pantalla la salida del Comando
                Console.WriteLine(result);
            }
            catch(System.SystemException exx)
            {
                MessageDialog mensaje = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, "Error en el sistema: ");
                mensaje.Run();
                mensaje.Destroy();
                Console.WriteLine("" + exx);
            }
            catch (Exception ex)
            { 
                Console.WriteLine("" + ex);
            }

        }
    }
}
