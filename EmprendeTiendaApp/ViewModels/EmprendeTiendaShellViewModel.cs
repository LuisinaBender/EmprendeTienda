using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprendeTiendaApp.ViewModels
{
    internal partial class EmprendeTiendaShellViewModels : ObservableObject
    {
        public IRelayCommand LogoutCommand { get; }

        [ObservableProperty]
        private bool isUserLogout = true;

        public EmprendeTiendaShellViewModels()
        {
            LogoutCommand = new RelayCommand(Logout);
        }

        private void Logout()
        {
            IsUserLogout = true;
            (App.Current.MainPage as EmprendeTiendaShell).DisableAppAfterLogin();
        }
    }
}
