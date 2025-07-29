using Service.Models;
using EmprendeTiendaApp.ViewModels;

namespace EmprendeTiendaApp.Views;

[QueryProperty(nameof(Product), "ProductToEdit")]
public partial class AddEditProductoView : ContentPage
{

        public Producto Product
    {
        set
        {
            var producto = value;
            var viewmodel = this.BindingContext as AddEditProductoViewModel;
            viewmodel.EditProduct = producto;
        }
    }
    //nuevo
    public AddEditProductoView()
    {
        InitializeComponent();
    }
}
