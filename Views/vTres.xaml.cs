namespace wsimbanaS3.Views;

public partial class vTres : ContentPage
{
	public vTres()
	{
		InitializeComponent();
	}


    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		try
		{

			string usuario = txtUsuario.Text;
			string contrasena = txtContrasena.Text;

			Navigation.PushAsync(new vUno(usuario, contrasena));
		}
		catch (Exception ex)
		{
            Console.WriteLine(ex.Message);

        }

    }
}