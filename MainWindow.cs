using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		int puntos = 0;

		if (this.radpg.Active)
			puntos ++;

		if (this.spinedad.Text == "3")
			puntos ++;

		if (this.xp.Active)
			puntos ++;

		if (this.vista.Active)
			puntos ++;

		DateTime fc = this.calendario.GetDate ();
		String fechaseleccionada = fc.ToShortDateString ();

		if (fechaseleccionada == "16/09/1910") {
			puntos ++;
		}

		String nom = this.nombre.Text;
		String cod = this.codigo.Text;
		String grp = this.grupo.ActiveText;

		MessageDialog md = new MessageDialog (null, 
		                                      DialogFlags.Modal,
		                                      MessageType.Info, 
		                                      ButtonsType.None, "El Alumno: " + nom + 
		                                      "\nCon Codigo: " + cod +
		                                      "\nPerteneciente al Grupo: " + grp +
		                                      "\nTiene: " + puntos + "pts de 5 posibles");
		md.Show();
	}
}