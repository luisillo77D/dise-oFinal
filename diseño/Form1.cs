using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseño
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_Fecha.Enabled = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 144)
            {
                timer_Ocultar.Enabled = true;
            }
            else
            {
                timer_Mostrar.Enabled = true;
            }
        }

        private void timer_Mostrar_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width == 144)
            {
                timer_Mostrar.Enabled = false;
            }
            else
            {
                panelMenu.Width = panelMenu.Width + 24;
            }
        }

        private void timer_Ocultar_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 48)
            {
                timer_Ocultar.Enabled = false;
            }
            else
            {
                panelMenu.Width = panelMenu.Width - 24;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            panelTrabajo.Controls.Clear();
            Clientes vClientes = new Clientes();
            vClientes.TopLevel = false;
            panelTrabajo.Controls.Add(vClientes);
            vClientes.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            panelTrabajo.Controls.Clear();
            Ventas vVentas = new Ventas();
            vVentas.TopLevel = false;
            panelTrabajo.Controls.Add(vVentas);
            vVentas.Show();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            panelTrabajo.Controls.Clear();
            Facturacion vFacturacion = new Facturacion();
            vFacturacion.TopLevel = false;
            panelTrabajo.Controls.Add(vFacturacion);
            vFacturacion.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            panelTrabajo.Controls.Clear();
            Reportes vReportes = new Reportes();
            vReportes.TopLevel = false;
            panelTrabajo.Controls.Add(vReportes);
            vReportes.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongTimeString();
        }

        private void panelTrabajo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
