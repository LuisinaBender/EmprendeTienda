using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            }
            
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value;
                OnPropertyChanged();
            }
        }
    }
}
