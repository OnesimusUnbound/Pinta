
// This file has been generated by the GUI designer. Do not modify.
namespace Pinta
{
	public partial class ProgressDialog
	{
		private global::Gtk.Label label;
		private global::Gtk.ProgressBar progress_bar;
		private global::Gtk.Button buttonCancel;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Pinta.ProgressDialog
			this.Name = "Pinta.ProgressDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child Pinta.ProgressDialog.VBox
			global::Gtk.Box w1 = this.ContentArea;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.label = new global::Gtk.Label ();
			this.label.Name = "label";
			this.label.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
			w1.Add (this.label);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.label]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.progress_bar = new global::Gtk.ProgressBar ();
			this.progress_bar.Name = "progress_bar";
			w1.Add (this.progress_bar);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(w1 [this.progress_bar]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Internal child Pinta.ProgressDialog.ActionArea
			global::Gtk.ButtonBox w4 = this.ActionArea;
			w4.Name = "dialog1_ActionArea";
			w4.Spacing = 10;
			w4.BorderWidth = ((uint)(5));
			w4.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w4 [this.buttonCancel]));
			w5.Expand = false;
			w5.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 114;
			this.Hide ();
		}
	}
}
