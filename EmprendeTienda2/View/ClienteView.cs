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

namespace EmprendeTiendaDesktop.View
{
    public partial class ClienteView : Form
    {
        BindingSource listaClientes = new BindingSource();
        public ClienteView()
        {
            InitializeComponent();
            dataGridClientes.DataSource = listaClientes;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                listaClientes = new BindingSource();
                listaClientes.DataSource = db.Clientes.ToList();
                dataGridClientes.DataSource = listaClientes;
            }
        }
    }
}
