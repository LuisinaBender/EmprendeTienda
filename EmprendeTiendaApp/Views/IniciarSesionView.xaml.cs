using CommunityToolkit.Mvvm.Messaging;
using EmprendeTiendaApp.ViewModels;
using EmprendeTiendaApp.Views;


namespace EmprendeTiendaApp.Views;

public partial class IniciarSesionView : ContentPage
{
	public IniciarSesionView()
	{
		InitializeComponent();
		WeakReferenceMessenger.Default.Register<IniciarSesionViewModel>(this, (r, m) =>
		{
			OnReceiveMessage(Message);
		});
	}

	private async void OnReceiveMessage(Message mensaje)
	{
		if (mensaje.Value == "AbrirProductos")
		{
			await Navigation.PushAsync(new ProductosView());
		}
        if (mensaje.Value == "AgregarProductos")
        {
            await Navigation.PushAsync(new AddEditProductoView());
        }

    }
}