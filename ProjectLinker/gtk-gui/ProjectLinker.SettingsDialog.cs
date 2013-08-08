
// This file has been generated by the GUI designer. Do not modify.
namespace ProjectLinker
{
	public partial class SettingsDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label label1;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.ComboBox projectsCombo;
		private global::Gtk.Label label2;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.VBox targetProjectsBox;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonSave;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ProjectLinker.SettingsDialog
			this.Name = "ProjectLinker.SettingsDialog";
			this.Title = "Project linker options";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.AllowShrink = true;
			this.DestroyWithParent = true;
			this.Gravity = ((global::Gdk.Gravity)(5));
			// Internal child ProjectLinker.SettingsDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.Yalign = 0F;
			this.label1.LabelProp = "<b>Source project</b>";
			this.label1.UseMarkup = true;
			this.label1.SingleLineMode = true;
			this.vbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.alignment1.LeftPadding = ((uint)(20));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.projectsCombo = global::Gtk.ComboBox.NewText ();
			this.projectsCombo.Name = "projectsCombo";
			this.alignment1.Add (this.projectsCombo);
			this.vbox2.Add (this.alignment1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment1]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.Yalign = 0F;
			this.label2.LabelProp = "<b>Target projects</b>";
			this.label2.UseMarkup = true;
			this.vbox2.Add (this.label2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label2]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.alignment2.LeftPadding = ((uint)(20));
			// Container child alignment2.Gtk.Container+ContainerChild
			this.targetProjectsBox = new global::Gtk.VBox ();
			this.targetProjectsBox.Name = "targetProjectsBox";
			this.targetProjectsBox.Spacing = 6;
			this.alignment2.Add (this.targetProjectsBox);
			this.vbox2.Add (this.alignment2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment2]));
			w7.Position = 3;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w8.Position = 0;
			// Internal child ProjectLinker.SettingsDialog.ActionArea
			global::Gtk.HButtonBox w9 = this.ActionArea;
			w9.Name = "dialog1_ActionArea";
			w9.Spacing = 10;
			w9.BorderWidth = ((uint)(5));
			w9.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			// Container child buttonCancel.Gtk.Container+ContainerChild
			global::Gtk.Alignment w10 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w11 = new global::Gtk.HBox ();
			w11.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w12 = new global::Gtk.Image ();
			w12.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w11.Add (w12);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w14 = new global::Gtk.Label ();
			w14.LabelProp = "_Cancel";
			w14.UseUnderline = true;
			w11.Add (w14);
			w10.Add (w11);
			this.buttonCancel.Add (w10);
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w18 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w9 [this.buttonCancel]));
			w18.Expand = false;
			w18.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			// Container child buttonSave.Gtk.Container+ContainerChild
			global::Gtk.Alignment w19 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w20 = new global::Gtk.HBox ();
			w20.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w21 = new global::Gtk.Image ();
			w21.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			w20.Add (w21);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w23 = new global::Gtk.Label ();
			w23.LabelProp = "Save";
			w23.UseUnderline = true;
			w20.Add (w23);
			w19.Add (w20);
			this.buttonSave.Add (w19);
			this.AddActionWidget (this.buttonSave, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w27 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w9 [this.buttonSave]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 252;
			this.Show ();
			this.projectsCombo.Changed += new global::System.EventHandler (this.sourceProjectChanged);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.cancelButtonClicked);
			this.buttonSave.Clicked += new global::System.EventHandler (this.saveButtonClicked);
		}
	}
}