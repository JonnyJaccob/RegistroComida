
// This file has been generated by the GUI designer. Do not modify.
namespace RegisComida
{
	public partial class WinComidas
	{
		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView textview1;

		private global::Gtk.Label GtkLabel;

		private global::Gtk.Table table1;

		private global::Gtk.Button btnMostrar;

		private global::Gtk.Button btnSalir;

		private global::Gtk.Button button2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget RegisComida.WinComidas
			this.Name = "RegisComida.WinComidas";
			this.Title = global::Mono.Unix.Catalog.GetString("¿Que Comer?");
			this.Icon = global::Stetic.IconLoader.LoadIcon(this, "gtk-dialog-info", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child RegisComida.WinComidas.Gtk.Container+ContainerChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w1 = new global::Gtk.Viewport();
			w1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.WidthRequest = 300;
			this.GtkScrolledWindow.HeightRequest = 200;
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textview1 = new global::Gtk.TextView();
			this.textview1.CanFocus = true;
			this.textview1.Name = "textview1";
			this.GtkScrolledWindow.Add(this.textview1);
			this.GtkAlignment.Add(this.GtkScrolledWindow);
			this.frame1.Add(this.GtkAlignment);
			this.GtkLabel = new global::Gtk.Label();
			this.GtkLabel.Name = "GtkLabel";
			this.GtkLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Comidas</b>");
			this.GtkLabel.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel;
			this.fixed1.Add(this.frame1);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.frame1]));
			w5.X = 7;
			w5.Y = 7;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.table1 = new global::Gtk.Table(((uint)(1)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.btnMostrar = new global::Gtk.Button();
			this.btnMostrar.CanFocus = true;
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.UseUnderline = true;
			this.btnMostrar.Label = global::Mono.Unix.Catalog.GetString("Mostrar");
			this.table1.Add(this.btnMostrar);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.btnMostrar]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btnSalir = new global::Gtk.Button();
			this.btnSalir.CanFocus = true;
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.UseUnderline = true;
			this.btnSalir.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.table1.Add(this.btnSalir);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.btnSalir]));
			w7.LeftAttach = ((uint)(2));
			w7.RightAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.button2 = new global::Gtk.Button();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
			this.table1.Add(this.button2);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.button2]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.fixed1.Add(this.table1);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.table1]));
			w9.X = 44;
			w9.Y = 234;
			w1.Add(this.fixed1);
			this.scrolledwindow1.Add(w1);
			this.Add(this.scrolledwindow1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 339;
			this.DefaultHeight = 300;
			this.Show();
			this.btnSalir.Clicked += new global::System.EventHandler(this.Salir_clicked);
			this.btnMostrar.Clicked += new global::System.EventHandler(this.Mostrar_Clicked);
		}
	}
}
