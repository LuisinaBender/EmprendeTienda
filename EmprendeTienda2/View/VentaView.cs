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

namespace EmprendeTiendaDesktop.View
{
    public partial class VentaView : Form
    {
        Venta ventasCurrent;
        BindingSource listaVentas = new BindingSource();
        private int? ventaEditandoId = null; // CORREGIDO: nombre y tipo

        public VentaView()
        {
            InitializeComponent();
            dataGridVentas.DataSource = listaVentas;
            CargarGrilla();
            CargarComboProductos();
            CargarComboClientes();
        }

        private void CargarGrilla()
        {
            var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                
                var detalles = db.DetalleVentas
                    .Include(d => d.Producto)
                    .Include(d => d.Venta)
                        .ThenInclude(v => v.Cliente)
                    .Select(d => new
                    {
                        Cliente = d.Venta.Cliente.Nombre,
                        Producto = d.Producto.Nombre,
                        Fecha = d.Venta.Fecha,
                        Cantidad = d.Cantidad,
                        PrecioUnitario = d.PrecioUnitario
                    })
                    .ToList();

                listaVentas = new BindingSource();
                dataGridVentas.AutoGenerateColumns = true;
                listaVentas.DataSource = detalles;
                dataGridVentas.DataSource = listaVentas;
            }
        }

        private void CargarComboClientes()
        {
            var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                var clientes = db.Clientes.OrderBy(c => c.Nombre).ToList();
                comboCliente.DataSource = clientes;
                comboCliente.DisplayMember = "Nombre";
                comboCliente.ValueMember = "Id";
            }
        }

        private void CargarComboProductos()
        {
            var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                var productos = db.Productos.OrderBy(p => p.Nombre).ToList();
                comboProductos.DataSource = productos;
                comboProductos.DisplayMember = "Nombre";
                comboProductos.ValueMember = "Id";
            }
        }


        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboCliente.SelectedItem == null || comboProductos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente y un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                if (ventaEditandoId.HasValue)
                {
                    var venta = db.Ventas.Include(v => v.DetalleVentas).FirstOrDefault(v => v.Id == ventaEditandoId.Value);
                    if (venta != null)
                    {
                        venta.Fecha = dateTimeFecha.Value;
                        venta.ClienteId = (int)comboCliente.SelectedValue;

                        var detalle = venta.DetalleVentas.FirstOrDefault();
                        if (detalle != null)
                        {
                            detalle.ProductoId = (int)comboProductos.SelectedValue;
                            detalle.Cantidad = cantidad;
                            detalle.PrecioUnitario = precio;
                        }

                        db.Ventas.Update(venta);
                        await db.SaveChangesAsync();
                        MessageBox.Show("Venta modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    var nuevaVenta = new Venta
                    {
                        Fecha = dateTimeFecha.Value,
                        ClienteId = (int)comboCliente.SelectedValue
                    };
                    db.Ventas.Add(nuevaVenta);
                    await db.SaveChangesAsync();

                    var detalleVenta = new DetalleVenta
                    {
                        VentaId = nuevaVenta.Id,
                        ProductoId = (int)comboProductos.SelectedValue,
                        Cantidad = cantidad,
                        PrecioUnitario = precio
                    };
                    db.DetalleVentas.Add(detalleVenta);
                    await db.SaveChangesAsync();

                    MessageBox.Show("Venta agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            ventaEditandoId = null;
            CargarGrilla();
            tabControlVentas.SelectedTab = tabPageLista;
        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            ventaEditandoId = null;
            dateTimeFecha.Value = DateTime.Now;
            txtCantidad.Text = "";
            txtPrecio.Text = "";

            if (comboCliente.Items.Count > 0)
                comboCliente.SelectedIndex = 0;
            if (comboProductos.Items.Count > 0)
                tabControlVentas.SelectedTab = tabPageAgregarEditar;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dataGridVentas.CurrentRow != null)
            {
                var valorId = dataGridVentas.CurrentRow.Cells["Id"].Value;
                if (valorId is int id)
                {
                    var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
                    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                    optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

                    using (var db = new AppDbContext(optionsBuilder.Options))
                    {
                        var venta = db.Ventas
                            .Include(v => v.DetalleVentas)
                            .FirstOrDefault(v => v.Id == id);

                        if (venta != null)
                        {
                            ventaEditandoId = venta.Id;
                            dateTimeFecha.Value = venta.Fecha;
                            comboCliente.SelectedValue = venta.ClienteId;

                            var detalle = venta.DetalleVentas.FirstOrDefault();
                            if (detalle != null)
                            {
                                comboProductos.SelectedValue = detalle.ProductoId;
                                txtCantidad.Text = detalle.Cantidad.ToString();
                                txtPrecio.Text = detalle.PrecioUnitario.ToString("0.00");
                            }

                            tabControlVentas.SelectedTab = tabPageAgregarEditar;
                        }
                    }
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridVentas.CurrentRow != null)
            {
                var resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta venta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado != DialogResult.Yes)
                    return;

                var valorId = dataGridVentas.CurrentRow.Cells["Id"].Value;
                if (valorId is int id)
                {
                    var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
                    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                    optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

                    using (var db = new AppDbContext(optionsBuilder.Options))
                    {
                        var venta = await db.Ventas
                            .Include(v => v.DetalleVentas)
                            .FirstOrDefaultAsync(v => v.Id == id);

                        if (venta != null)
                        {
                            // Eliminar primero los detalles
                            db.DetalleVentas.RemoveRange(venta.DetalleVentas);

                            // Luego eliminar la venta
                            db.Ventas.Remove(venta);

                            await db.SaveChangesAsync();

                            MessageBox.Show("Venta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CargarGrilla(); // refresca la grilla
                        }
                        else
                        {
                            MessageBox.Show("Venta no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una venta para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
