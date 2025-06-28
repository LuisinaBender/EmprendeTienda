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
            db = new AppDbContext(new DbContextOptions<AppDbContext>());
            dataGridClientes.DataSource = listaClientes;
            dataGridClientes.AutoGenerateColumns = true;
            CargarGrilla();

        }

        private void CargarGrilla()
        {
            listaClientes.DataSource = db.Clientes.ToList();
        }
    }
}
