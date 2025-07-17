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
        public VentaView()
        {
            InitializeComponent();
            dataGridVentas.DataSource = listaVentas;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                listaVentas = new BindingSource();
                listaVentas.DataSource = db.Ventas.ToList();
                dataGridVentas.DataSource = listaVentas;
            }
        }

        //private void bntAgregar_Click(object sender, EventArgs e)
        //{
        //    tabControlVentas.SelectedTab = tabPageAgregarEditar;
        //}

        //private async void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtNombre.Text))
        //    {
        //        MessageBox.Show("El nombre de la venta  es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    if (ventasCurrent != null)
        //    {
        //        ventasCurrent.Nombre = txtNombre.Text;
        //        var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
        //        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        //        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        //        using (var db = new AppDbContext(optionsBuilder.Options))
        //        {
        //            db.Ventas.Update(ventasCurrent);
        //            await db.SaveChangesAsync();
        //        }


        //    }
        //    else
        //    {
        //        var ventas = new Ventas
        //        {
        //            Nombre = txtNombre.Text.Trim()
        //        };

        //        var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
        //        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        //        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        //        using (var db = new AppDbContext(optionsBuilder.Options))
        //        {
        //            db.Ventas.Add(venta);
        //            db.SaveChanges();
        //        }

        //        MessageBox.Show("La venta se guardo correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        CargarGrilla();
        //        tabControlVentas.SelectedTab = tabPageLista;
        //    }
        //}
    }
}
