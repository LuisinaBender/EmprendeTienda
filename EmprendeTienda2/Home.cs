using EmprendeTiendaDescktop.View;

namespace EmprendeTienda
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void btn_clientes_Click_1(object sender, EventArgs e)
        {
            ClientesViews clientesViews = new ClientesViews();
            clientesViews.ShowDialog();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            ProductosViews productosViews = new ProductosViews();
            productosViews.ShowDialog();
        }
    }
}
