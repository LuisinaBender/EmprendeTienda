
using CommunityToolkit.Mvvm.Messaging;
using EmprendeTiendaApp.Views;


namespace EmprendeTiendaApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new IniciarSesionView());



            
        }

        
    }
}