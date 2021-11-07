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

namespace SalonDeBellezaTest2
{
    public partial class frmInsercion : Form
    {
        public frmInsercion()
        {
            InitializeComponent();

        }

        int filasAfectadas = 0;

        private void frmInsercion_Load(object sender, EventArgs e)
        {
            cboBarrio.Enabled = false;
            lblBarrio.ForeColor = Color.Gray;
            btnGuardar.Enabled = false;

            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoContacto.DropDownStyle = ComboBoxStyle.DropDownList;

            CargarCombo(cboTipoContacto, "TIPO_CONTACTOS", "DESCRIPCION", "ID_TIPO_CONTACTO", "", -1);
            CargarCombo(cboTipoDocumento, "TIPO_DOCUMENTOS", "DESCRIPCION", "ID_TIPO_DOC", "",-1);
            CargarCombo(cboLocalidad, "LOCALIDADES", "NOM_LOCALIDAD", "ID_LOCALIDAD", "",-1);
            CargarCombo(cboTurno, "TURNOS", "DESCRIPCION", "ID_TURNO", "",-1);

            LimpiarCampos(true);
            HabilitarCampos(false);

        }

        //Se muestra o no el comboBox Turno dependiendo si es Cliente o Profesional
        private void rbtnCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCliente.Checked)
            {
                cboTurno.Visible = false;
                lblTurno.Visible = false;
            }
            else
            {
                cboTurno.Visible = true;
                lblTurno.Visible = true;
                cboTurno.Text = String.Empty;
                cboTurno.SelectedValue = 0;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos(true);
            HabilitarCampos(true);
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validar Campos
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Campo NOMBRE obligatorio!..");
                return;
            }
            if (String.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Campo APELLIDO obligatorio!..");
                return;
            }

            //Validar tipo de documento

            int tipo_doc = 0;

            try
            {
                tipo_doc = Convert.ToInt32(cboTipoDocumento.SelectedValue);
            }
            catch (Exception)
            {
                
            }
            if (tipo_doc == 0) {
                MessageBox.Show("Campo TIPO DOCUMENTO obligatorio!..");
                return;
            }

            //Validar numero de documento

            if (String.IsNullOrEmpty(txtNroDocumento.Text))
            {
                MessageBox.Show("Campo NUMERO DE DOCUMENTO obligatorio!..");
                return;
            }

            //Validar turno si es profesional 
            if (rbtnProfesional.Checked) {
                int turno = 0;

                try
                {
                    turno = Convert.ToInt32(cboTurno.SelectedValue);
                }
                catch (Exception)
                {

                }
                if (turno == 0)
                {
                    MessageBox.Show("Campo TURNO obligatorio!..");
                    return;
                }
            }

            //Validar localidad

            int localidad = 0;

            try
            {
                localidad = Convert.ToInt32(cboLocalidad.SelectedValue);
            }
            catch { 
            }

            if (localidad == 0)
            {
                MessageBox.Show("Campo LOCALIDAD obligatorio!..");
                return;
            }

            //Validar BARRIO

            int barrio = 0;

            try
            {
                barrio = Convert.ToInt32(cboBarrio.SelectedValue);
            }
            catch
            {
            }

            if (barrio == 0)
            {
                MessageBox.Show("Campo BARRIO obligatorio!..");
                return;
            }

            //

            if (String.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Campo DIRECCION obligatorio!..");
                return;
            }

            //Validar TIPO CONTACTO

            int tipo_contacto = 0;

            try
            {
                tipo_contacto = Convert.ToInt32(cboTipoContacto.SelectedValue);
            }
            catch
            {
            }

            if (tipo_contacto == 0)
            {
                MessageBox.Show("Campo TIPO CONTACTO obligatorio!..");
                return;
            }

            //Validar Contacto

            if (String.IsNullOrEmpty(txtContacto.Text))
            {
                MessageBox.Show("Campo CONTACTO obligatorio!..");
                return;
            }


            // CONECTAR A LA DB
            SqlConnection cnn =  ConectarBase();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MAX(id_contacto)+1 FROM CONTACTOS";
            DataTable tabla_contacto = new DataTable();
            tabla_contacto.Load(cmd.ExecuteReader());

            string id_contacto = tabla_contacto.Rows[0][0].ToString();

            //try
            //{
                //Incersion para cuando es CLIENTE
                if (rbtnCliente.Checked)
                {
                    //BUSCO EL MAXIMO ID DE CLIENTES
                    cmd.CommandText = "SELECT MAX(id_cliente)+1 FROM CLIENTES";
                    DataTable table = new DataTable();
                    table.Load(cmd.ExecuteReader());

                    string id = table.Rows[0][0].ToString();
                    string desc = "CLIENTE " + txtApellido.Text + " " + txtNombre.Text;

                    //INSERTO EN LA TABLA CONTACTOS
                    cmd.CommandText = "INSERT INTO CONTACTOS (id_contacto,descripcion) VALUES (@ID_CONTACTO,@DESCRIPCION_C)";

                    cmd.Parameters.AddWithValue("@ID_CONTACTO", Convert.ToInt32(id_contacto));
                    cmd.Parameters.AddWithValue("@DESCRIPCION_C", desc);

                    cmd.ExecuteNonQuery();

                    //INSERTO EN LA TABLA DETALLE_CONTACTOS
                    cmd.CommandText = "INSERT INTO DETALLE_CONTACTOS (id_contacto,id_tipo_contacto,descripcion)"+
                        " VALUES (@ID_CONTACTO_DC,@ID_TIPO_DOC,@DESCRIPCION_DC)";

                    cmd.Parameters.AddWithValue("@ID_CONTACTO_DC", Convert.ToInt32(id_contacto));
                    cmd.Parameters.AddWithValue("@ID_TIPO_DOC", Convert.ToInt32(cboTipoContacto.SelectedValue));
                    cmd.Parameters.AddWithValue("@DESCRIPCION_DC", txtContacto.Text);

                    cmd.ExecuteNonQuery();

                    //INSERTO EN LA TABLA CLIENTES
                    cmd.CommandText = "INSERT INTO CLIENTES (id_cliente, nombre , apellido , nro_documento , id_tipo_doc , id_barrio , direccion , id_contacto) " +
                        "VALUES (@ID, @NOMBRE,@APELLIDO,@NDOC, @TDOC,@IDBARRIO,@DIRECCION,@CONTACTO)";

                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id));
                    cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@APELLIDO", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@NDOC", txtNroDocumento.Text);
                    cmd.Parameters.AddWithValue("@TDOC", Convert.ToInt32(cboTipoDocumento.SelectedValue));
                    cmd.Parameters.AddWithValue("@IDBARRIO", Convert.ToInt32(cboBarrio.SelectedValue));
                    cmd.Parameters.AddWithValue("@DIRECCION", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@CONTACTO", Convert.ToInt32(id_contacto));

                    filasAfectadas = cmd.ExecuteNonQuery();

                    //Resultado con exito muestra el Data GRid View
                    if (filasAfectadas > 0)
                    {
                        lblResultado.Text = "Resultados guardados con éxito";
                        cmd.CommandText = "SELECT id_cliente cliente, nombre nombre, apellido apellido, nro_documento 'nro documento', id_tipo_doc 'tipo documento', id_barrio barrio, direccion direccion, id_contacto contacto FROM CLIENTES " +
                            "WHERE id_cliente = " + id;
                        DataTable tabla = new DataTable();
                        tabla.Load(cmd.ExecuteReader());
                        dgvResultado.RowTemplate.Height = 40;
                        dgvResultado.ColumnHeadersHeight = 50;
                        dgvResultado.DataSource = tabla;
                    }
                    else
                    {
                        lblResultado.Text = "No se insertó ninguna fila";
                    }

                }
                else //Incersion para cuando es PROFESIONAL
                {
                    //BUSCO EL MAXIMO ID DE PROFESIONALES
                    cmd.CommandText = "SELECT MAX(id_profesional)+1 FROM PROFESIONALES";
                    DataTable table = new DataTable();
                    table.Load(cmd.ExecuteReader());

                    string id = table.Rows[0][0].ToString();

                    //INSERTO EN LA TABLA CONTACTOS
                    string desc = "PROFESIONAL " + txtApellido.Text + " " + txtNombre.Text;

                    cmd.CommandText = "INSERT INTO CONTACTOS (id_contacto,descripcion) VALUES (@ID_CONTACTO,@DESCRIPCION_C)";

                    cmd.Parameters.AddWithValue("@ID_CONTACTO", Convert.ToInt32(id_contacto));
                    cmd.Parameters.AddWithValue("@DESCRIPCION_C", desc);

                    cmd.ExecuteNonQuery();

                    //INSERTO EN LA TABLA DETALLE_CONTACTOS
                    cmd.CommandText = "INSERT INTO DETALLE_CONTACTOS (id_contacto,id_tipo_contacto,descripcion)" +
                        " VALUES (@ID_CONTACTO_DC,@ID_TIPO_CON,@DESCRIPCION_DC)";

                    cmd.Parameters.AddWithValue("@ID_CONTACTO_DC", Convert.ToInt32(id_contacto));
                    cmd.Parameters.AddWithValue("@ID_TIPO_CON", Convert.ToInt32(cboTipoContacto.SelectedValue));
                    cmd.Parameters.AddWithValue("@DESCRIPCION_DC", txtContacto.Text);

                    cmd.ExecuteNonQuery();

                    //INSERTO EN LA TABLA PROFESIONALES
                    cmd.CommandText = "INSERT INTO PROFESIONALES (id_profesional, nombre , apellido , nro_documento , id_tipo_doc , id_barrio , direccion , id_contacto , id_turno )" +
                        "VALUES(@ID, @NOMBRE,@APELLIDO,@NDOC, @TDOC,@IDBARRIO,@DIRECCION,@CONTACTO,@TURNO)";

                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id));
                    cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@APELLIDO", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@NDOC", txtNroDocumento.Text);
                    cmd.Parameters.AddWithValue("@TDOC", Convert.ToInt32(cboTipoDocumento.SelectedValue));
                    cmd.Parameters.AddWithValue("@IDBARRIO", Convert.ToInt32(cboBarrio.SelectedValue));
                    cmd.Parameters.AddWithValue("@DIRECCION", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@CONTACTO", Convert.ToInt32(id_contacto));
                    cmd.Parameters.AddWithValue("@TURNO", Convert.ToInt32(cboTurno.SelectedValue));

                    filasAfectadas = cmd.ExecuteNonQuery();

                    //Resultado con exito muestra el Data GRid View
                    if (filasAfectadas > 0)
                    {
                        lblResultado.Text = "Resultados guardados con éxito";
                        lblResultado.ForeColor = Color.Green;
                        cmd.CommandText = "SELECT id_profesional profesional, nombre nombre, apellido apellido, nro_documento 'nro documento', id_tipo_doc 'tipo documento', id_barrio barrio, direccion direccion, id_contacto contacto, id_turno turno FROM PROFESIONALES " +
                            "WHERE id_profesional = " + id;
                        DataTable tabla = new DataTable();
                        tabla.Load(cmd.ExecuteReader());
                        dgvResultado.RowTemplate.Height = 40;
                        dgvResultado.ColumnHeadersHeight = 50;
                        dgvResultado.DataSource = tabla;
                    }
                    else
                    {
                        lblResultado.Text = "No se insertó ninguna fila";
                    }
                }

                cnn.Close();

                LimpiarCampos(false);
                HabilitarCampos(false);
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
            //}
            //catch (Exception)
            //{
                //MessageBox.Show("Error al insertar en la base de datos, intente nuevamente ...");
            //}   
        }

        //Estructura Conexion inicial SqlConnection
        private SqlConnection ConectarBase() {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=DANIBOGDAN\SQLEXPRESS;Initial Catalog=SALON_DE_BELLEZA;Integrated Security=True";
            cnn.Open();

            return cnn;
        }

        private void CargarCombo(ComboBox cbo, string tabla, string display, string value, string n_filtro, int filtro) {
            SqlConnection cnn = ConectarBase();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + tabla, cnn);
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            cbo.DataSource = table;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cnn.Close();
            
        }
        
        //Cuando se selecciona la localidad se habiliatn los barrios de la misma
        private void cboLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBarrio.Text = String.Empty;
            cboBarrio.SelectedValue = 0;

            try
            {
                SqlConnection cnn = ConectarBase();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BARRIOS WHERE ID_LOCALIDAD=" + Convert.ToInt32(cboLocalidad.SelectedValue), cnn);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                cboBarrio.DataSource = table;
                cboBarrio.DisplayMember = "NOM_BARRIO";
                cboBarrio.ValueMember = "ID_BARRIO";
                cnn.Close();

                cboBarrio.Enabled = true;
                lblBarrio.ForeColor = Color.White;
            }
            catch(Exception) {

            };           
        }

        private void LimpiarCampos(bool aux) {
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtContacto.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtNroDocumento.Text = String.Empty;
            cboLocalidad.Text = String.Empty;
            cboLocalidad.SelectedValue = 0;
            cboBarrio.Text = String.Empty;
            cboBarrio.SelectedValue = 0;
            cboTipoContacto.Text = String.Empty;
            cboTipoContacto.SelectedValue = 0;
            cboTipoDocumento.Text = String.Empty;
            cboTipoDocumento.SelectedValue = 0;

            if (rbtnProfesional.Checked) {
                cboTurno.Text = String.Empty;
                cboTurno.SelectedValue = 0;
            }
            

            if (aux) {
                lblResultado.Text = String.Empty;            
            }
            
        }

        private void HabilitarCampos(bool act)
        {
            txtNombre.Enabled = act;
            txtApellido.Enabled = act;
            txtContacto.Enabled = act;
            txtDireccion.Enabled = act;
            txtNroDocumento.Enabled = act;
            cboLocalidad.Enabled = act;
            cboBarrio.Enabled = false;
            cboTipoContacto.Enabled = act;
            cboTipoDocumento.Enabled = act;
            cboTurno.Enabled = act;
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
