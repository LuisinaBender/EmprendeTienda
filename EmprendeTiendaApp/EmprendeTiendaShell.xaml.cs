using EmprendeTiendaApp.Views;
using EmprendeTiendaApp.ContentViews;

namespace EmprendeTiendaApp
{
    public partial class EmprendeTiendaShell : Shell
    {
        public EmprendeTiendaShell()
        {
            InitializeComponent();
            FlyoutItemsPrincipal.IsVisible = false;
            RegisterRoutes();

        }
        private void RegisterRoutes()
        {
            Routing.RegisterRoute("Registrarse", typeof(RegistrarseView));
        }

        public void EnableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Flyout; 
            FlyoutItemsPrincipal.IsVisible = true; 
            Shell.Current.GoToAsync("//MainPage"); 
            var viewmodel = this.BindingContext as EmprendeTiendaShellViewModel;
            viewmodel.IsUserLogout = false;
        }
        public void DisableAppAfterLogin()
        {
            FlyoutItemsPrincipal.IsVisible = false; 
            FlyoutBehavior = FlyoutBehavior.Disabled; 
            Shell.Current.GoToAsync("//Login");
    }
}
