
// This file has been generated by the GUI designer. Do not modify.
namespace Pinta.Effects
{
	public partial class PosterizeDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Pinta.Gui.Widgets.HScaleSpinButtonWidget hscalespinRed;
		private global::Pinta.Gui.Widgets.HScaleSpinButtonWidget hscalespinGreen;
		private global::Pinta.Gui.Widgets.HScaleSpinButtonWidget hscalespinBlue;
		private global::Gtk.CheckButton checkLinked;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Pinta.Effects.PosterizeDialog
			this.Name = "Pinta.Effects.PosterizeDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Posterize");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			// Internal child Pinta.Effects.PosterizeDialog.VBox
			global::Gtk.Box w1 = this.ContentArea;
			w1.WidthRequest = 400;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hscalespinRed = new global::Pinta.Gui.Widgets.HScaleSpinButtonWidget ();
			this.hscalespinRed.Events = ((global::Gdk.EventMask)(256));
			this.hscalespinRed.Name = "hscalespinRed";
			this.hscalespinRed.Label = "Red";
			this.hscalespinRed.DefaultValue = 16;
			this.hscalespinRed.MaximumValue = 64;
			this.hscalespinRed.MinimumValue = 2;
			this.hscalespinRed.DigitsValue = 0;
			this.hscalespinRed.IncrementValue = 0;
			this.hscalespinRed.Value = 0;
			this.vbox2.Add (this.hscalespinRed);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hscalespinRed]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hscalespinGreen = new global::Pinta.Gui.Widgets.HScaleSpinButtonWidget ();
			this.hscalespinGreen.Events = ((global::Gdk.EventMask)(256));
			this.hscalespinGreen.Name = "hscalespinGreen";
			this.hscalespinGreen.Label = "Green";
			this.hscalespinGreen.DefaultValue = 16;
			this.hscalespinGreen.MaximumValue = 64;
			this.hscalespinGreen.MinimumValue = 2;
			this.hscalespinGreen.DigitsValue = 0;
			this.hscalespinGreen.IncrementValue = 0;
			this.hscalespinGreen.Value = 0;
			this.vbox2.Add (this.hscalespinGreen);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hscalespinGreen]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hscalespinBlue = new global::Pinta.Gui.Widgets.HScaleSpinButtonWidget ();
			this.hscalespinBlue.Events = ((global::Gdk.EventMask)(256));
			this.hscalespinBlue.Name = "hscalespinBlue";
			this.hscalespinBlue.Label = "Blue";
			this.hscalespinBlue.DefaultValue = 16;
			this.hscalespinBlue.MaximumValue = 64;
			this.hscalespinBlue.MinimumValue = 2;
			this.hscalespinBlue.DigitsValue = 0;
			this.hscalespinBlue.IncrementValue = 0;
			this.hscalespinBlue.Value = 0;
			this.vbox2.Add (this.hscalespinBlue);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hscalespinBlue]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.checkLinked = new global::Gtk.CheckButton ();
			this.checkLinked.CanFocus = true;
			this.checkLinked.Name = "checkLinked";
			this.checkLinked.Label = global::Mono.Unix.Catalog.GetString ("Linked");
			this.checkLinked.Active = true;
			this.checkLinked.DrawIndicator = true;
			this.checkLinked.UseUnderline = true;
			w1.Add (this.checkLinked);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(w1 [this.checkLinked]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Internal child Pinta.Effects.PosterizeDialog.ActionArea
			global::Gtk.ButtonBox w7 = this.ActionArea;
			w7.Name = "dialog1_ActionArea";
			w7.Spacing = 10;
			w7.BorderWidth = ((uint)(5));
			w7.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w7 [this.buttonCancel]));
			w8.Expand = false;
			w8.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w7 [this.buttonOk]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
		}
	}
}
