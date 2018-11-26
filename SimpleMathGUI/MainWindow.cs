using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
	int first = 0;
	int second = 1;

	static int ReadInt(string input, int low, int high)
	{
		int result = 1;
		bool success = Int32.TryParse (input, out result);
		if (!success)
		{
			result = 1;
		}
		return (result >= low) && (result <= high) ? result : 1;
	}


	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnTextview3KeyReleaseEvent (object o, KeyReleaseEventArgs args)
	{
		first = ReadInt (textview3.Buffer.Text, 1, 100);
		UpdateLabel ();
	}

	protected void OnTextview4KeyReleaseEvent (object o, KeyReleaseEventArgs args)
	{
		second = ReadInt (textview4.Buffer.Text, 1, 100);
		UpdateLabel ();
	}

	private void UpdateLabel()
	{
		label3.Text = String.Format ($"{first} + {second} = {first + second}\n{first} - {second} = {first - second}\n{first} * {second} = {first * second}\n{first} / {second} = {first / second}\n");
	}
}
