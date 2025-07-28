using BackendEmprendeTienda.DataContext;
using Microsoft.EntityFrameworkCore;
using Service.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmprendeTiendaDesktop.View
{
    public partial class ClienteView : Form
    {
        // Usamos este campo para saber si estamos editando (Id) o agregando (null)
        int? clienteEditandoId = null;

        public ClienteView()
        {
            InitializeComponent();
            CargarGrilla();
            CargarComboLocalidades();
        }

        private void CargarGrilla()
        {
            var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                var clientes = db.Clientes.Include(c => c.Localidad).ToList();
                var clientesVista = clientes.Select(c => new
                {
                    c.Nombre,
                    c.Apellido,
                    c.Email,
                    c.Telefono,
                    c.Direccion,
                    Localidad = c.Localidad != null ? c.Localidad.Nombre : "",
                    Id = c.Id // oculto, para saber cuál editar/eliminar
                }).ToList();

                dataGridClientes.DataSource = null;
                dataGridClientes.DataSource = clientesVista;
                if (dataGridClientes.Columns["Id"] != null)
                    dataGridClientes.Columns["Id"].Visible = false;
            }
        }

        private void CargarComboLocalidades()
        {
            var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                var localidades = db.Localidades.OrderBy(l => l.Nombre).ToList();
                comboLocalidades.DataSource = localidades;
                comboLocalidades.DisplayMember = "Nombre";
                comboLocalidades.ValueMember = "Id";
            }
        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            // Limpia los campos y deja clienteEditandoId en null
            clienteEditandoId = null;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            if (comboLocalidades.Items.Count > 0)
                comboLocalidades.SelectedIndex = 0;
            tabControlClientes.SelectedTab = tabPageAgregarEditar;
        }



        private void btn_modificar_Click(object sender, EventArgs e)
        {
            // Selecciona el cliente y lo carga en el formulario
            if (dataGridClientes.CurrentRow != null)
            {
                var valorId = dataGridClientes.CurrentRow.Cells["Id"].Value;
                if (valorId is int id)
                {
                    var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
                    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                    optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

                    using (var db = new AppDbContext(optionsBuilder.Options))
                    {
                        var cliente = db.Clientes.Find(id);
                        if (cliente != null)
                        {
                            clienteEditandoId = cliente.Id;
                            txtNombre.Text = cliente.Nombre;
                            txtApellido.Text = cliente.Apellido;
                            txtEmail.Text = cliente.Email;
                            txtTelefono.Text = cliente.Telefono;
                            txtDireccion.Text = cliente.Direccion;
                            comboLocalidades.SelectedValue = cliente.LocalidadId;
                            tabControlClientes.SelectedTab = tabPageAgregarEditar;
                        }
                    }
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.CurrentRow != null)
            {
                var valorId = dataGridClientes.CurrentRow.Cells["Id"].Value;
                if (valorId is int id)
                {
                    var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
                    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                    optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

                    using (var db = new AppDbContext(optionsBuilder.Options))
                    {
                        // Verifica si el cliente tiene ventas asociadas
                        bool tieneVentas = db.Ventas.Any(v => v.ClienteId == id);
                        if (tieneVentas)
                        {
                            MessageBox.Show("No se puede eliminar el cliente porque tiene ventas asociadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var cliente = await db.Clientes.FindAsync(id);
                        if (cliente != null)
                        {
                            db.Clientes.Remove(cliente);
                            await db.SaveChangesAsync();
                        }
                    }
                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrilla();
                }
            }
        }

        private async void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del cliente es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var connectionString = "server=i20.com.ar;port=3306;database=i20com_2doLuisinaBender;user=i20com_luisi;password=Isp203040;AllowZeroDateTime=true;ConvertZeroDateTime=true";
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                if (clienteEditandoId.HasValue)
                {
                    // EDITAR CLIENTE
                    var cliente = await db.Clientes.FindAsync(clienteEditandoId.Value);
                    if (cliente != null)
                    {
                        cliente.Nombre = txtNombre.Text.Trim();
                        cliente.Apellido = txtApellido.Text.Trim();
                        cliente.Email = txtEmail.Text.Trim();
                        cliente.Telefono = txtTelefono.Text.Trim();
                        cliente.Direccion = txtDireccion.Text.Trim();
                        cliente.LocalidadId = (int)comboLocalidades.SelectedValue;
                        db.Clientes.Update(cliente);
                        await db.SaveChangesAsync();
                        MessageBox.Show("Cliente editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // AGREGAR CLIENTE
                    var cliente = new Cliente
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Apellido = txtApellido.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim(),
                        Direccion = txtDireccion.Text.Trim(),
                        LocalidadId = (int)comboLocalidades.SelectedValue
                    };
                    db.Clientes.Add(cliente);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            CargarGrilla();
            tabControlClientes.SelectedTab = tabPageLista;
            clienteEditandoId = null; // Resetea el Id para futuras operaciones
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}