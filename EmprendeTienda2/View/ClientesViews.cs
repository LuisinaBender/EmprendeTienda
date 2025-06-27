using BackendEmprendeTienda.DataContext;
using Microsoft.EntityFrameworkCore;
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
    public partial class ClientesViews : Form
    {
        BindingSource listaClientes = new BindingSource();
        AppDbContext db;

        public ClientesViews()
        {
            InitializeComponent();
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=i20.com.ar,1433;Database=i20com_2doLuisinaBender;User Id=i20com_luisi;Password=Isp203040;")
                .Options;

            db = new AppDbContext(options);
            dataGridClientes.DataSource = listaClientes;
            dataGridClientes.AutoGenerateColumns = true;
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            try
            {
                listaClientes.DataSource = db.Clientes.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
