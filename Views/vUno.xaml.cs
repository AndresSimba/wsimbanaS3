namespace wsimbanaS3.Views;

public partial class vUno : ContentPage
{
	string usuarioGlobal;
	string contrasenaGlobal;

    public vUno()
	{
		InitializeComponent();

	}

	public vUno(string usuarioAcceso, string contrasenaAcceso)
	{
		InitializeComponent(); 

		usuarioGlobal = usuarioAcceso;
		contrasenaGlobal = contrasenaAcceso;
	}

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
		try
		{
			//string usuarioAcceso = "Uisrael";
			//string contrasenaAcceso = "2018";
			string usuario = txtUsuario.Text;
			string contrasena = txtContrasena.Text;
			if (usuario == usuarioGlobal && contrasena == contrasenaGlobal)
			{
                Navigation.PushAsync(new Views.vDos(usuario, contrasena));

			}
			else
			{
				DisplayAlert("Error","Usuario o contraseña Incorrecto", "OK");
			}

        }
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {

		Navigation.PushAsync(new vTres());

    }
}