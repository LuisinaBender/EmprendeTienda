using BackendEmprendeTienda.DataContext;
using Microsoft.EntityFrameworkCore;
using Service.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure; 
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
    public partial class LocalidadView : Form
    {
        Localidad localidadCurrent;
        BindingSource listaLocalidades = new BindingSource();
        public LocalidadView()
        {
            InitializeComponent();
            dataGridLocalidades.DataSource = listaLocalidades;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                listaLocalidades = new BindingSource();
                listaLocalidades.DataSource = db.Localidades.ToList();
                dataGridLocalidades.DataSource = listaLocalidades;

            }
        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            tabControlLocalidad.SelectedTab = tabPageAgregarEditar;

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la localidad es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (localidadCurrent != null)
            {
                localidadCurrent.Nombre = txtNombre.Text;
                var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

                using (var db = new AppDbContext(optionsBuilder.Options))
                {
                    db.Localidades.Update(localidadCurrent);
                    await db.SaveChangesAsync();
                }


            }
            else
            {
                var localidad = new Localidad
                {
                    Nombre = txtNombre.Text.Trim()
                };

                var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

                using (var db = new AppDbContext(optionsBuilder.Options))
                {
                    db.Localidades.Add(localidad);
                    db.SaveChanges();
                }

                MessageBox.Show("Localidad guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                tabControlLocalidad.SelectedTab = tabPageLista;
            }

            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            localidadCurrent = (Localidad)listaLocalidades.Current;
            txtNombre.Text = localidadCurrent.Nombre;
            tabControlLocalidad.SelectedTab = tabPageAgregarEditar;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta localidad?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                localidadCurrent = (Localidad)listaLocalidades.Current;
                if (localidadCurrent != null)
                {
                    var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
                    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                    optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
                    using (var db = new AppDbContext(optionsBuilder.Options))
                    {
                        db.Localidades.Remove(localidadCurrent);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Localidad eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrilla();
                }


            }
        }
    }
}
