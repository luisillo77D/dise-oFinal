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
            Clientes vClientes = new Clientes();
            vClientes.TopLevel = false;
            panelTrabajo.Controls.Add(vClientes);
            vClientes.Show();
        }
    }
}
