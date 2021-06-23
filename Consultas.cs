using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SalonDeBellezaTest2;

namespace Consultas_SalonDeBelleza
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
            Deshabilitar();
            CargarCombo();
        }
        private void Deshabilitar()
        {
            btnGuardar.Enabled = false;
            txtNumero.ReadOnly = true;
            txtConsigna.ReadOnly = true;
            txtQuery.ReadOnly = true;
        }
        private void Limpiar()
        {
            txtNumero.Text = "";
            txtConsigna.Text = "";
            txtQuery.Text = "";
            txtRapida.Text = "";
            dgvPrincipal.DataSource = "";
            txtRapida.Text = "";
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string num = cbConsulta.SelectedValue.ToString();
            result = MessageBox.Show("Desea borrar la consulta N°: " + num, "Borrar consulta", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                SqlConnection cnn = ConectarBaseConsultas();
                string query = "delete Consultas where Numero =" + num;
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                CargarCombo();
                Limpiar();
            }
        }

        private void CargarCombo()
        {
            SqlConnection cnn = ConectarBaseConsultas();

            SqlCommand cmd = new SqlCommand("select Numero from Consultas", cnn);
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());

            cbConsulta.DataSource = tabla;
            cbConsulta.DisplayMember = "Numero";
            cbConsulta.ValueMember = "Numero";
            cnn.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNumero.ReadOnly = false;
            btnGuardar.Enabled = true;
            txtConsigna.ReadOnly = false;
            txtQuery.ReadOnly = false;
            Limpiar();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNumero.Text);
                string consigna = txtConsigna.Text.ToString();
                string consulta = txtQuery.Text.ToString();

                DialogResult result;
                result = MessageBox.Show("Esta seguro que desea guardar la consulta N°:" + num, "Guardar", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    SqlConnection cnn = ConectarBaseConsultas();

                    string query = "set quoted_identifier off " +
                                    "insert into Consultas(Numero, Consigna, Query) values(" +
                                     num + ",\"" + consigna + "\",\"" + consulta + "\")";

                    if (txtNumero.ReadOnly == true)
                    {
                        query = "set quoted_identifier off " +
                                "update Consultas " +
                                "set Consigna = \" " + consigna + " \"," +
                                "    Query = \" " + consulta + " \" " +
                                "where Numero = " + num;
                    }
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                Form1_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!");
            }
            
        }
        private void Mostrar(string query)
        {
            try
            {
                SqlConnection cnn = ConectarBaseSalon();

                SqlCommand cmd = new SqlCommand(query, cnn);
                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());
                dgvPrincipal.DataSource = tabla;
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!");
            }
        }
        private void cbConsulta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query;
            string num = cbConsulta.SelectedValue.ToString();
            txtNumero.Text = num;
            try
            {
                SqlConnection cnn = ConectarBaseConsultas();

                string consigna = "select consigna from Consultas where Numero = " + num;
                SqlCommand cmdConsigna = new SqlCommand(consigna, cnn);
                txtConsigna.Text = (string)cmdConsigna.ExecuteScalar();

                string queryAux = "select Query from Consultas where Numero = " + num;
                SqlCommand cmdQuery = new SqlCommand(queryAux, cnn);
                query = (string)cmdQuery.ExecuteScalar();
                txtQuery.Text = query;
                cnn.Close();

                Mostrar(query);
                Deshabilitar();
                txtRapida.ReadOnly = true;
                txtRapida.Text = "";

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!");
            }
        }
        private void btnDiagrama_Click(object sender, EventArgs e)
        {
            Diagrama diagrama = new Diagrama();
            diagrama.Show();
        }

        private void txtRapida_MouseClick(object sender, MouseEventArgs e)
        {
            txtRapida.ReadOnly = false;
            Deshabilitar();
            Limpiar();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (txtRapida.Text == "")
            {
                Mostrar(txtQuery.Text);
            }
            else
            {
                Mostrar(txtRapida.Text);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtConsigna.ReadOnly = false;
            txtQuery.ReadOnly = false;
            btnGuardar.Enabled = true;
            txtRapida.Text = "";
            txtRapida.ReadOnly = true;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Form formulario2 = new frmInsercion();
            formulario2.ShowDialog();
        }

        private SqlConnection ConectarBaseSalon()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=not0109\SQLEXPRESS;Initial Catalog=SALON_DE_BELLEZA;Integrated Security=True";
            cnn.Open();

            return cnn;
        }

        private SqlConnection ConectarBaseConsultas()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=not0109\SQLEXPRESS;Initial Catalog=ConsultasSalon;Integrated Security=True";
            cnn.Open();

            return cnn;
        }
    }
}
