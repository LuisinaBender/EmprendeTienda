using EmprendeTienda;
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
    public partial class SplashView : Form
    {
        public SplashView()
        {
            InitializeComponent();
        }

        private void SplashView_Activated(object sender, EventArgs e)
        {
            // colocamos un delay de 5 segundos 
            System.Threading.Thread.Sleep(5000);
            // cerramos la ventana splash
            this.Hide();
            // lanzamos la ventana principal
            Home home = new Home();
            home.ShowDialog();

            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
