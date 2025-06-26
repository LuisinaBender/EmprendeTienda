using BackendEmprendeTienda.DataContext;
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
        AppDbContext db = new AppDbContext();
        public ClientesViews()
        {
            InitializeComponent();
            dataGridClientes.DataSource = listaClientes;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            listaClientes.DataSource = db.Clientes.ToList();
        }
    }
}
