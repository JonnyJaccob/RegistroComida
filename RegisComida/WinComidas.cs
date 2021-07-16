using System;
namespace RegisComida
{
    public partial class WinComidas : Gtk.Window
    {
        public WinComidas() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void Salir_clicked(object sender, EventArgs e)
        {

        }
    }
}
