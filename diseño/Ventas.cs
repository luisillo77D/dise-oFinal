using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseño
{
    public partial class Ventas : Form
    {
        SqlConnection conn = new SqlConnection();
        DataTable dataTable;
        int cant;
        double pre,sub,iva, total;
        
        public Ventas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ventas_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar==(char)Keys.Escape)
            {
                Cobrar();
                sub = 0;
                cant= 0;
                AsignarPrecios();
                limpiar();
            }
            else if ((int)e.KeyChar == (int)Keys.Enter)
            {
                
                AgregarProductos(txtProductos.Text);
                AsignarPrecios();
            }
        }

        private void limpiar()
        {
            lblIva.Text= string.Empty;
            lblSub.Text= string.Empty;
            lblTotal.Text= string.Empty;
            dgvVentas.DataSource=null;
            dataTable = null;
        }

        private void Cobrar()
        {
            try
            {
                conexion();
                String consulta = "INSERT INTO Ventas(Total,Fecha) VALUES(" + total + ",'" + DateTime.Today + "')";

                SqlCommand coman = new SqlCommand(consulta, conn);
                coman.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Venta realizada correctamente");
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show("error" + ex);
            }

            }

        private void AsignarPrecios()
        {
            sub =sub+(cant * pre);
            iva =(sub * .16);
            total=(iva+sub);
            lblIva.Text = iva.ToString();
            lblSub.Text = sub.ToString();
            lblTotal.Text = total.ToString();
        }

        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvVentas.Rows[e.RowIndex];
            DataGridViewCell precioo = dgvVentas.Rows[e.RowIndex].Cells[1];
            DataGridViewCell canti = dgvVentas.Rows[e.RowIndex].Cells[2];
            MessageBox.Show(canti.Value.ToString());
            sub -= Convert.ToInt32(precioo.Value)* Convert.ToInt32(canti.Value);
            iva = (sub * .16);
            total = (iva + sub);
            lblIva.Text = iva.ToString();
            lblSub.Text = sub.ToString();
            lblTotal.Text = total.ToString();
            dgvVentas.Rows.Remove(fila);
        }

        private void AgregarProductos(string text)
        {
            int idProducto;
            int cantidad;
            if (text.Contains("*"))
            {
                String[] div = text.Split('*');
                 idProducto = Convert.ToInt32(div[0]);
                 cantidad = Convert.ToInt32(div[1]);            
            }
            else
            {
                 idProducto = Convert.ToInt32(text);
                 cantidad = 1;
            }
            conexion();
            String consulta = "SELECT nombre, precio FROM Productos WHERE idProducto=" + idProducto;
            SqlDataAdapter adap = new SqlDataAdapter(consulta, conn);
            DataTable productos = new DataTable();
            adap.Fill(productos);

            if (dataTable==null)
            {
                dataTable = new DataTable();
                dataTable.Columns.Add("nombre", typeof(string));
                dataTable.Columns.Add("precio", typeof(decimal));
                dataTable.Columns.Add("cantidad", typeof(int));

                dgvVentas.DataSource = dataTable;
            }
            // Agregar una nueva fila al DataTable con los datos del nuevo producto
            DataRow row = dataTable.NewRow();
            row["nombre"] = productos.Rows[0]["nombre"];
            row["precio"] = productos.Rows[0]["precio"];
            row["cantidad"] = cantidad;
            dataTable.Rows.Add(row);

            pre = Convert.ToDouble(productos.Rows[0]["precio"]);
            cant = cantidad;

            // Establecer el DataSource del DataGridView para que muestre todos los productos
            dgvVentas.DataSource = dataTable;

            // Cerrar la conexión a la base de datos
            conn.Close();

            txtProductos.Clear();

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
                dataTable = new DataTable();
            dataTable.Columns.Add("nombre", typeof(string));
            dataTable.Columns.Add("precio", typeof(decimal));
            dataTable.Columns.Add("cantidad", typeof(int));

            dgvVentas.DataSource = dataTable;
        }
        public void conexion()
        {
            try
            {
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\luisi\\Downloads\\diseño\\diseño\\Database2.mdf;Integrated Security=True";
                conn.Open();     
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex);
            };
        }
    }
}
