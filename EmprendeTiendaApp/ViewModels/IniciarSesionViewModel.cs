using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging;
using EmprendeTiendaApp.Class;

namespace EmprendeTiendaApp.ViewModels
{
    public class IniciarSesionViewModel : ObjectNotification
    {
        private string email;
        public string Email
        {
            get { return email; }
            set {email = value;
               OnPropertyChanged();
                IniciarSesionCommand.ChangeCanExecute();
            }
            
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value;
                OnPropertyChanged();
                IniciarSesionCommand.ChangeCanExecute();
            }
        }

        public Command IniciarSesionCommand { get; set; }
        public Command RegistrarseCommand { get; set; }

        public IniciarSesionViewModel()
        {

            IniciarSesionCommand = new Command(IniciarSesion, PermitirIniciarSesion);

        }

        private bool PermitirIniciarSesion(object arg)
        {
            return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password);
        }

        private void  IniciarSesion(object obj)
        {
            WeakReferenceMessenger.Default.Send(new Message ("AprirAppShell"));
        }

        // if (mensaje.Value == AbrirAppShell)
        // {
        //     await Navigation.PushAsync(new EmprendeTiendaShell());
        // }

    }


}
