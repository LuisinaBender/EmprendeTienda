using EmprendeTiendaDescktop.View;
using EmprendeTiendaDesktop.View;

namespace EmprendeTienda
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void btn_productos_Click(object sender, EventArgs e)
        {
            ProductosViews productosViews = new ProductosViews();
            productosViews.ShowDialog();
        }


        private void btn_salirDelSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_localidades_Click(object sender, EventArgs e)
        {
            LocalidadView localidadView = new LocalidadView();
            localidadView.ShowDialog();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            ClienteView clienteView = new ClienteView();
            clienteView.ShowDialog();
        }

        private void bnt_ventas_Click(object sender, EventArgs e)
        {
            VentaView ventaView = new VentaView();
            ventaView.ShowDialog();
        }
    }
}
