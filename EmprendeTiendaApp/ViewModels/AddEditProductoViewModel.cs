using CommunityToolkit.Mvvm.Messaging;
using EmprendeTiendaApp.Class;
using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EmprendeTiendaApp.ViewModels
{
    public class AddEditProductoViewModel : ObjectNotification, INotifyPropertyChanged
    {

        GenericService<Producto> productoService = new GenericService<Producto>();
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged();
                
            }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                descripcion = value;
                OnPropertyChanged();
            }
        }

        private decimal precio;
        public decimal Precio
        {
            get { return precio; }
            set
            {
                precio = value;
                OnPropertyChanged();
            }
        }
        private decimal stock;

        public decimal Stock
        {
            get { return stock; }
            set
            {
                stock = value;
                OnPropertyChanged();
            }
        }

        private decimal cantidad;

        public decimal Cantidad
        {
            get { return cantidad; }
            set
            {
                cantidad = value;
                OnPropertyChanged();
            }
        }

        private Producto _editProduct;
        public Producto EditProduct
        {
            get => _editProduct;
            set
            {
                _editProduct = value;
                OnPropertyChanged(nameof(EditProduct));
                // Si quieres, puedes mapear las propiedades aquí
                if (_editProduct != null)
                {
                    Nombre = _editProduct.Nombre;
                    Descripcion = _editProduct.Descripcion;
                    Precio = _editProduct.Precio;
                    Stock = _editProduct.Stock;
                    Cantidad = _editProduct.Cantidad;
                }
            }
        }

        public Command SaveProductCommand { get; set; }

        public AddEditProductoViewModel()
        {
            SaveProductCommand = new Command(async (obj) => await SaveProduct(obj));
        }

        private async Task SaveProduct(object obj)
        {
            var producto = new Producto
            {
                Nombre = Nombre,
                Descripcion = Descripcion,
                Precio = Precio,
                Stock = (int)Stock,
                Cantidad = Cantidad
            };
            
            await productoService.AddAsync(producto);
            WeakReferenceMessenger.Default.Send(new Message("CerrarProductos"));
        }
    }
}
