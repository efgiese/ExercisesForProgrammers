using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnTextview1KeyReleaseEvent (object o, KeyReleaseEventArgs args)
	{
		label4.Text = String.Format("{0} has {1} characters.", textview1.Buffer.Text ,textview1.Buffer.Text.Length);
	}
}
