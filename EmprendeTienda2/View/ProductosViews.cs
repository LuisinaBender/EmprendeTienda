using BackendEmprendeTienda.DataContext;
using Microsoft.EntityFrameworkCore;
using Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmprendeTiendaDescktop.View
{
    public partial class ProductosViews : Form

    {
        Producto productoCurrent;
        BindingSource listaProductos = new BindingSource();
        public ProductosViews()
        {
            InitializeComponent();
            dataGridProductos.DataSource = listaProductos;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                listaProductos = new BindingSource();
                listaProductos.DataSource = db.Productos.ToList();
                dataGridProductos.DataSource = listaProductos;

            }

        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            tabControlProductos.SelectedTab = tabPageAgregarEditar;

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            if (productoCurrent != null)
            {
                using (var db = new AppDbContext(optionsBuilder.Options))
                {
                    var productoBD = await db.Productos.FindAsync(productoCurrent.Id);
                    if (productoBD != null)
                    {
                        productoBD.Nombre = txtNombre.Text.Trim();
                        productoBD.Descripcion = txtDescripcion.Text.Trim();
                        productoBD.Precio = decimal.TryParse(txtPrecio.Text.Trim(), out var precio) ? precio : 0;
                        productoBD.Stock = int.TryParse(txtStock.Text.Trim(), out var stock) ? stock : 0;

                        await db.SaveChangesAsync();

                        MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrilla();
                        tabControlProductos.SelectedTab = tabPageLista;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var producto = new Producto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Precio = decimal.TryParse(txtPrecio.Text.Trim(), out var precio) ? precio : 0,
                    Stock = int.TryParse(txtStock.Text.Trim(), out var stock) ? stock : 0
                };

                using (var db = new AppDbContext(optionsBuilder.Options))
                {
                    db.Productos.Add(producto);
                    await db.SaveChangesAsync();
                }

                MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                tabControlProductos.SelectedTab = tabPageLista;
            }
        }


        private void btn_modificar_Click(object sender, EventArgs e)
        {
            productoCurrent = (Producto)listaProductos.Current;
            txtNombre.Text = productoCurrent.Nombre;
            txtDescripcion.Text = productoCurrent.Descripcion;
            txtPrecio.Text = productoCurrent.Precio.ToString("F2");
            txtStock.Text = productoCurrent.Stock.ToString();

            tabControlProductos.SelectedTab = tabPageAgregarEditar;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea eliminar este producto?",
                                         "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            productoCurrent = (Producto)listaProductos.Current;

            if (productoCurrent != null)
            {
                var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

                try
                {
                    using (var db = new AppDbContext(optionsBuilder.Options))
                    {
                        db.Productos.Remove(productoCurrent);
                        db.SaveChanges();
                    }

                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrilla();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException != null && ex.InnerException.Message.Contains("FOREIGN KEY"))
                    {
                        MessageBox.Show("Este producto no se puede eliminar porque está asociado a una o más ventas.",
                                        "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto: " + ex.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
