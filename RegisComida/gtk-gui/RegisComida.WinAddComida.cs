
// This file has been generated by the GUI designer. Do not modify.
namespace RegisComida
{
	public partial class WinAddComida
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Frame frame2;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.Table table1;

		private global::Gtk.ComboBoxEntry cmbComidas;

		private global::Gtk.Entry entrynombre;

		private global::Gtk.Label label1;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.SpinButton spincomida;

		private global::Gtk.SpinButton spinimagen;

		private global::Gtk.Label GtkLabel;

		private global::Gtk.Table table3;

		private global::Gtk.Button btnañadir;

		private global::Gtk.Button btnModificar;

		private global::Gtk.Button btnRegresar;

		private global::Gtk.Button btnupdate;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget RegisComida.WinAddComida
			this.Name = "RegisComida.WinAddComida";
			this.Title = global::Mono.Unix.Catalog.GetString("WinAddComida");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child RegisComida.WinAddComida.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.frame2 = new global::Gtk.Frame();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(4)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.cmbComidas = global::Gtk.ComboBoxEntry.NewText();
			this.cmbComidas.Name = "cmbComidas";
			this.table1.Add(this.cmbComidas);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.cmbComidas]));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entrynombre = new global::Gtk.Entry();
			this.entrynombre.CanFocus = true;
			this.entrynombre.Name = "entrynombre";
			this.entrynombre.IsEditable = true;
			this.entrynombre.MaxLength = 25;
			this.entrynombre.InvisibleChar = '•';
			this.table1.Add(this.entrynombre);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.entrynombre]));
			w2.TopAttach = ((uint)(3));
			w2.BottomAttach = ((uint)(4));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Comidas \nanteriores");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("id_comida");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("imagenID");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre");
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w6.TopAttach = ((uint)(3));
			w6.BottomAttach = ((uint)(4));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spincomida = new global::Gtk.SpinButton(0D, 100D, 1D);
			this.spincomida.CanFocus = true;
			this.spincomida.Name = "spincomida";
			this.spincomida.Adjustment.PageIncrement = 10D;
			this.spincomida.ClimbRate = 1D;
			this.spincomida.Numeric = true;
			this.table1.Add(this.spincomida);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.spincomida]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spinimagen = new global::Gtk.SpinButton(0D, 100D, 1D);
			this.spinimagen.CanFocus = true;
			this.spinimagen.Name = "spinimagen";
			this.spinimagen.Adjustment.PageIncrement = 10D;
			this.spinimagen.ClimbRate = 1D;
			this.spinimagen.Numeric = true;
			this.table1.Add(this.spinimagen);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.spinimagen]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add(this.table1);
			this.frame2.Add(this.GtkAlignment);
			this.GtkLabel = new global::Gtk.Label();
			this.GtkLabel.Name = "GtkLabel";
			this.GtkLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Creacion de comidas</b>");
			this.GtkLabel.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel;
			this.fixed1.Add(this.frame2);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.frame2]));
			w11.X = -3;
			w11.Y = 9;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.table3 = new global::Gtk.Table(((uint)(1)), ((uint)(4)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.btnañadir = new global::Gtk.Button();
			this.btnañadir.CanFocus = true;
			this.btnañadir.Name = "btnañadir";
			this.btnañadir.UseUnderline = true;
			this.btnañadir.Label = "Añadir";
			this.table3.Add(this.btnañadir);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table3[this.btnañadir]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.btnModificar = new global::Gtk.Button();
			this.btnModificar.CanFocus = true;
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.UseUnderline = true;
			this.btnModificar.Label = global::Mono.Unix.Catalog.GetString("Modificar");
			this.table3.Add(this.btnModificar);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table3[this.btnModificar]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.btnRegresar = new global::Gtk.Button();
			this.btnRegresar.CanFocus = true;
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.UseUnderline = true;
			this.btnRegresar.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.table3.Add(this.btnRegresar);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table3[this.btnRegresar]));
			w14.LeftAttach = ((uint)(3));
			w14.RightAttach = ((uint)(4));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.btnupdate = new global::Gtk.Button();
			this.btnupdate.CanFocus = true;
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.UseUnderline = true;
			this.btnupdate.Label = global::Mono.Unix.Catalog.GetString("Actualizar");
			this.table3.Add(this.btnupdate);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table3[this.btnupdate]));
			w15.LeftAttach = ((uint)(2));
			w15.RightAttach = ((uint)(3));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.fixed1.Add(this.table3);
			global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.table3]));
			w16.X = 25;
			w16.Y = 220;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.btnupdate.Clicked += new global::System.EventHandler(this.Update_Clicked);
			this.btnRegresar.Clicked += new global::System.EventHandler(this.Regresar);
			this.btnModificar.Clicked += new global::System.EventHandler(this.Modificar_Clicked);
			this.btnañadir.Clicked += new global::System.EventHandler(this.Añadir_Clicked);
		}
	}
}