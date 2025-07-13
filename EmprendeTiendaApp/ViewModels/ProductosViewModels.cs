using EmprendeTiendaApp.Class;
using Service.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EmprendeTiendaApp.ViewModels
{
    public class ProductosViewModels : ObjectNotification
    {
        //private GenericService<Producto> productoService = new GenericService<Producto>(); hacer los servicios 
        private string filterProducts;

        public string FilterProducts
        {
            get { return filterProducts; }
            set
            {
                filterProducts = value;
                OnPropertyChanged();
                //filtrarProductos();
            }
        }

        private ObservableCollection<Producto> productos;

        public ObservableCollection<Producto> Productos
        {
            get { return productos; }
            set
                {
                    productos = value;
                    OnPropertyChanged();
                }
        }
         public ICommand ObtenerProductosCommand { get; set; }
         public ICommand FiltrarProductosCommand { get; set; }

        public ProductosViewModels()
        {
            ObtenerProductosCommand = new Command(async () => await ObtenerProducto());
            FiltrarProductosCommand = new Command(async() => await FiltrarProductos());
        }

        private async Task ObtenerProducto()
        {
            //Productos = await productoService.GetAllAsync();
            //OnPropertyChange(nameof(Productos));
            //filtrarProductos();
        }

        private async Task FiltrarProductos()
        {
            
        }
    }

}
