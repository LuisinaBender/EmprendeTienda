using EmprendeTiendaDescktop.View;

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
    }
}
