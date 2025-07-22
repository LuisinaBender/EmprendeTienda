using EmprendeTienda;
using Service.Services;       
using Service.Models;         
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace EmprendeTiendaDesktop.View
{
    public partial class SplashView : Form
    {
        private bool dataReady = false;

        public SplashView()
        {
            InitializeComponent();
        }

        private async void SplashView_Activated(object sender, EventArgs e)
        {
            var cargarDatosTask = CargarDatosDesdeDbAsync();

            timer.Start();

            await cargarDatosTask;
        }

        private async Task CargarDatosDesdeDbAsync()
        {
            await Task.Run(async () =>
            {
                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        var clienteService = new GenericService<Cliente>(httpClient);
                        var clientes = await clienteService.GetAllAsync();
                    }

                    await Task.Delay(2000); // Simula carga si es muy rápida

                    dataReady = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                    Application.Exit();
                }
            });
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 98)
                progressBar.Value += 2;

            if (dataReady)
            {
                timer.Stop();
                this.Hide();
                var home = new Home();
                home.ShowDialog();
                this.Close();
            }
        }
    }
}

