
namespace SalonDeBellezaTest2
{
    partial class frmInsercion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpInsercion = new System.Windows.Forms.GroupBox();
            this.lblResultadoIngresado = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.grpInsertDato = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cboTipoContacto = new System.Windows.Forms.ComboBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblTipoContacto = new System.Windows.Forms.Label();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rbtnProfesional = new System.Windows.Forms.RadioButton();
            this.rbtnCliente = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpInsercion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.grpInsertDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInsercion
            // 
            this.grpInsercion.Controls.Add(this.lblResultadoIngresado);
            this.grpInsercion.Controls.Add(this.btnNuevo);
            this.grpInsercion.Controls.Add(this.dgvResultado);
            this.grpInsercion.Controls.Add(this.grpInsertDato);
            this.grpInsercion.Controls.Add(this.rbtnProfesional);
            this.grpInsercion.Controls.Add(this.rbtnCliente);
            this.grpInsercion.Controls.Add(this.btnGuardar);
            this.grpInsercion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInsercion.ForeColor = System.Drawing.Color.White;
            this.grpInsercion.Location = new System.Drawing.Point(29, 17);
            this.grpInsercion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInsercion.Name = "grpInsercion";
            this.grpInsercion.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInsercion.Size = new System.Drawing.Size(957, 538);
            this.grpInsercion.TabIndex = 0;
            this.grpInsercion.TabStop = false;
            this.grpInsercion.Text = "Insertar Datos";
            // 
            // lblResultadoIngresado
            // 
            this.lblResultadoIngresado.AutoSize = true;
            this.lblResultadoIngresado.Location = new System.Drawing.Point(31, 360);
            this.lblResultadoIngresado.Name = "lblResultadoIngresado";
            this.lblResultadoIngresado.Size = new System.Drawing.Size(258, 21);
            this.lblResultadoIngresado.TabIndex = 30;
            this.lblResultadoIngresado.Text = "Resultado del registro insertado:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Location = new System.Drawing.Point(56, 192);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 31);
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.dgvResultado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.dgvResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultado.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(118)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultado.EnableHeadersVisualStyles = false;
            this.dgvResultado.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvResultado.Location = new System.Drawing.Point(28, 410);
            this.dgvResultado.Name = "dgvResultado";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvResultado.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResultado.Size = new System.Drawing.Size(902, 99);
            this.dgvResultado.TabIndex = 3;
            // 
            // grpInsertDato
            // 
            this.grpInsertDato.Controls.Add(this.lblResultado);
            this.grpInsertDato.Controls.Add(this.lblObligatorio);
            this.grpInsertDato.Controls.Add(this.lblTurno);
            this.grpInsertDato.Controls.Add(this.cboTurno);
            this.grpInsertDato.Controls.Add(this.cboLocalidad);
            this.grpInsertDato.Controls.Add(this.lblLocalidad);
            this.grpInsertDato.Controls.Add(this.cboTipoContacto);
            this.grpInsertDato.Controls.Add(this.lblContacto);
            this.grpInsertDato.Controls.Add(this.lblTipoContacto);
            this.grpInsertDato.Controls.Add(this.cboBarrio);
            this.grpInsertDato.Controls.Add(this.lblBarrio);
            this.grpInsertDato.Controls.Add(this.lblDireccion);
            this.grpInsertDato.Controls.Add(this.lblNroDoc);
            this.grpInsertDato.Controls.Add(this.lblTipoDoc);
            this.grpInsertDato.Controls.Add(this.lblApellido);
            this.grpInsertDato.Controls.Add(this.lblNombre);
            this.grpInsertDato.Controls.Add(this.cboTipoDocumento);
            this.grpInsertDato.Controls.Add(this.txtContacto);
            this.grpInsertDato.Controls.Add(this.txtNroDocumento);
            this.grpInsertDato.Controls.Add(this.txtDireccion);
            this.grpInsertDato.Controls.Add(this.txtApellido);
            this.grpInsertDato.Controls.Add(this.txtNombre);
            this.grpInsertDato.ForeColor = System.Drawing.SystemColors.Window;
            this.grpInsertDato.Location = new System.Drawing.Point(211, 16);
            this.grpInsertDato.Name = "grpInsertDato";
            this.grpInsertDato.Size = new System.Drawing.Size(710, 317);
            this.grpInsertDato.TabIndex = 2;
            this.grpInsertDato.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(395, 274);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 17);
            this.lblResultado.TabIndex = 28;
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorio.Location = new System.Drawing.Point(18, 277);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(187, 16);
            this.lblObligatorio.TabIndex = 27;
            this.lblObligatorio.Text = "Todos los campos son obligatorios";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(115, 226);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(53, 21);
            this.lblTurno.TabIndex = 26;
            this.lblTurno.Text = "Turno";
            // 
            // cboTurno
            // 
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Location = new System.Drawing.Point(174, 223);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(181, 29);
            this.cboTurno.TabIndex = 25;
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(493, 33);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(183, 29);
            this.cboLocalidad.TabIndex = 23;
            this.cboLocalidad.SelectedIndexChanged += new System.EventHandler(this.cboLocalidad_SelectedIndexChanged);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(397, 36);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(87, 21);
            this.lblLocalidad.TabIndex = 22;
            this.lblLocalidad.Text = "Localidad";
            // 
            // cboTipoContacto
            // 
            this.cboTipoContacto.FormattingEnabled = true;
            this.cboTipoContacto.Location = new System.Drawing.Point(496, 166);
            this.cboTipoContacto.Name = "cboTipoContacto";
            this.cboTipoContacto.Size = new System.Drawing.Size(180, 29);
            this.cboTipoContacto.TabIndex = 21;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(400, 209);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(88, 21);
            this.lblContacto.TabIndex = 20;
            this.lblContacto.Text = "Contacto";
            // 
            // lblTipoContacto
            // 
            this.lblTipoContacto.AutoSize = true;
            this.lblTipoContacto.Location = new System.Drawing.Point(368, 168);
            this.lblTipoContacto.Name = "lblTipoContacto";
            this.lblTipoContacto.Size = new System.Drawing.Size(121, 21);
            this.lblTipoContacto.TabIndex = 19;
            this.lblTipoContacto.Text = "Tipo contacto";
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(493, 72);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(183, 29);
            this.cboBarrio.TabIndex = 18;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(431, 76);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(53, 21);
            this.lblBarrio.TabIndex = 17;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(404, 115);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 21);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(43, 171);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(125, 21);
            this.lblNroDoc.TabIndex = 15;
            this.lblNroDoc.Text = "N° documento";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(31, 130);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(139, 21);
            this.lblTipoDoc.TabIndex = 14;
            this.lblTipoDoc.Text = "Tipo documento";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(95, 72);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(74, 21);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(95, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 21);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(174, 125);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(181, 29);
            this.cboTipoDocumento.TabIndex = 11;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(495, 206);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(181, 27);
            this.txtContacto.TabIndex = 10;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(174, 165);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(181, 27);
            this.txtNroDocumento.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(493, 110);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(183, 27);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(174, 69);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(183, 27);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 27);
            this.txtNombre.TabIndex = 2;
            // 
            // rbtnProfesional
            // 
            this.rbtnProfesional.AutoSize = true;
            this.rbtnProfesional.Location = new System.Drawing.Point(51, 118);
            this.rbtnProfesional.Name = "rbtnProfesional";
            this.rbtnProfesional.Size = new System.Drawing.Size(110, 25);
            this.rbtnProfesional.TabIndex = 1;
            this.rbtnProfesional.TabStop = true;
            this.rbtnProfesional.Text = "Profesional";
            this.rbtnProfesional.UseVisualStyleBackColor = true;
            // 
            // rbtnCliente
            // 
            this.rbtnCliente.AutoSize = true;
            this.rbtnCliente.Location = new System.Drawing.Point(51, 62);
            this.rbtnCliente.Name = "rbtnCliente";
            this.rbtnCliente.Size = new System.Drawing.Size(84, 25);
            this.rbtnCliente.TabIndex = 0;
            this.rbtnCliente.TabStop = true;
            this.rbtnCliente.Text = "Cliente";
            this.rbtnCliente.UseVisualStyleBackColor = true;
            this.rbtnCliente.CheckedChanged += new System.EventHandler(this.rbtnCliente_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(56, 267);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 31);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmInsercion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1020, 586);
            this.Controls.Add(this.grpInsercion);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInsercion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon de Belleza - Insercion";
            this.Load += new System.EventHandler(this.frmInsercion_Load);
            this.grpInsercion.ResumeLayout(false);
            this.grpInsercion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.grpInsertDato.ResumeLayout(false);
            this.grpInsertDato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInsercion;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.GroupBox grpInsertDato;
        private System.Windows.Forms.RadioButton rbtnProfesional;
        private System.Windows.Forms.RadioButton rbtnCliente;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblTipoContacto;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cboLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cboTipoContacto;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblResultadoIngresado;
    }
}