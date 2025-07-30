using CommunityToolkit.Mvvm.Messaging;
using EmprendeTiendaApp.ViewModels;
using EmprendeTiendaApp.Views;
using CommunityToolkit.Mvvm.Messaging.Messages;



namespace EmprendeTiendaApp.Views;

public partial class IniciarSesionView : ContentPage
{
	public IniciarSesionView()
	{
		InitializeComponent();
		WeakReferenceMessenger.Default.Register<ValueChangedMessage<string>>(this, (r, m) =>
		{
			OnReceiveMessage(m);
		});
	}

	private async void OnReceiveMessage(ValueChangedMessage<string> mensaje)
	{
		if (mensaje.Value == "AbrirProductos")
		{
			await Navigation.PushAsync(new Productos());
		}
		if (mensaje.Value == "AgregarProductos")
		{
			await Navigation.PushAsync(new AddEditProductoView());
		}
		if (mensaje.Value == "CerrarVentana")
		{
			await Navigation.PopAsync();
		}
	}
}