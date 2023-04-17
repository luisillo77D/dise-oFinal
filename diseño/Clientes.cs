using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace diseño
{
    public partial class Clientes : Form
    {
        SqlConnection conn = new SqlConnection();
        int id=0;
        public Clientes()
        {
            InitializeComponent();
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
            
        }

        private void cargarClientes(string filtro="")
        {
            try
            {
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\K04-10\\source\\repos\\diseño\\diseño\\Database1.mdf;Integrated Security=True";
                conn.Open();
                //MessageBox.Show("conexion establecida");
                String consulta = "SELECT * FROM Clientes";
                if (filtro != "")
                {
                    consulta += " WHERE " + "idcliente LIKE '%" + filtro + "%' OR " + "nombre LIKE '" + filtro + "%'";
                }
                SqlDataAdapter adap = new SqlDataAdapter(consulta, conn);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex);
            };
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            cargarClientes(textBox5.Text.Trim());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\K04-10\\source\\repos\\diseño\\diseño\\Database1.mdf;Integrated Security=True";
                conn.Open();
                String consulta = "UPDATE clientes SET nombre=@nom,celular=@cel,correo=@correo,direccion=@dir WHERE idcliente=@id";
                SqlCommand coman = new SqlCommand(consulta, conn);
                coman.Parameters.Add(new SqlParameter("@nom", txtNombre.Text));
                coman.Parameters.Add(new SqlParameter("@cel", txtCel.Text));
                coman.Parameters.Add(new SqlParameter("@correo", txtCorreo.Text));
                coman.Parameters.Add(new SqlParameter("@dir", txtDir.Text));
                coman.Parameters.Add(new SqlParameter("@id", id));
                coman.ExecuteNonQuery();
                MessageBox.Show("Cliente actualizado correctamente");
                conn.Close();
                cargarClientes();
                limpiar();
                id = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (id!=0)
            {
                MessageBox.Show("No se puede agregar al mismo cliente");
                limpiar();
                id = 0;
                return;
            }
            try
            {
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\K04-10\\source\\repos\\diseño\\diseño\\Database1.mdf;Integrated Security=True";
                conn.Open();
                //MessageBox.Show("conexion establecida");
                String consulta = "INSERT INTO Clientes(nombre,celular,correo,direccion) VALUES('"+txtNombre.Text+"','"+txtCel.Text+"','"+txtCorreo.Text+"','"+txtDir.Text+"')";

                SqlCommand coman = new SqlCommand(consulta, conn);
                coman.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado correctamente");
                conn.Close();
                cargarClientes();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            id = Convert.ToInt32(fila.Cells["idCliente"].Value);
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtCel.Text = fila.Cells["celular"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            txtDir.Text = fila.Cells["direccion"].Value.ToString();
            
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtDir.Clear();
            txtCorreo.Clear();
            txtCel.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\K04-10\\source\\repos\\diseño\\diseño\\Database1.mdf;Integrated Security=True";
                conn.Open();

                String delete = "DELETE FROM clientes WHERE idcliente=" + id;
                SqlCommand coman = new SqlCommand(delete, conn);
                coman.ExecuteNonQuery();
                conn.Close();
                cargarClientes();
                limpiar();
                id = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex);
                
            }
            
        }
    }
}
