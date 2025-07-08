using EmprendeTiendaApp.ViewModels;

namespace EmprendeTiendaApp.Views;

public partial class IniciarSesionView : ContentPage
{
	public IniciarSesionView()
	{
		InitializeComponent();
		BindingContext = new IniciarSesionViewModel();
    }
}