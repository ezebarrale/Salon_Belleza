
namespace Consultas_SalonDeBelleza
{
    partial class Consultas
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
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtConsigna = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRapida = new System.Windows.Forms.TextBox();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDiagrama = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // cbConsulta
            // 
            this.cbConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Location = new System.Drawing.Point(142, 16);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(56, 33);
            this.cbConsulta.TabIndex = 0;
            this.cbConsulta.SelectionChangeCommitted += new System.EventHandler(this.cbConsulta_SelectionChangeCommitted);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBorrar.Location = new System.Drawing.Point(204, 14);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(160, 35);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar Consulta";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(429, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta N°:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNumero.Location = new System.Drawing.Point(558, 16);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(38, 30);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNuevo.Location = new System.Drawing.Point(602, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(118, 35);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtConsigna
            // 
            this.txtConsigna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtConsigna.Location = new System.Drawing.Point(12, 92);
            this.txtConsigna.Multiline = true;
            this.txtConsigna.Name = "txtConsigna";
            this.txtConsigna.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsigna.Size = new System.Drawing.Size(832, 115);
            this.txtConsigna.TabIndex = 5;
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtQuery.Location = new System.Drawing.Point(12, 255);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuery.Size = new System.Drawing.Size(833, 115);
            this.txtQuery.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Consigna:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(13, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Query:";
            // 
            // txtRapida
            // 
            this.txtRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtRapida.Location = new System.Drawing.Point(181, 380);
            this.txtRapida.Name = "txtRapida";
            this.txtRapida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRapida.Size = new System.Drawing.Size(540, 30);
            this.txtRapida.TabIndex = 9;
            this.txtRapida.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRapida_MouseClick);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Location = new System.Drawing.Point(12, 420);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.Size = new System.Drawing.Size(832, 199);
            this.dgvPrincipal.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnGuardar.Location = new System.Drawing.Point(726, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 35);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Consulta N°:";
            // 
            // btnDiagrama
            // 
            this.btnDiagrama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDiagrama.Location = new System.Drawing.Point(142, 214);
            this.btnDiagrama.Name = "btnDiagrama";
            this.btnDiagrama.Size = new System.Drawing.Size(212, 35);
            this.btnDiagrama.TabIndex = 14;
            this.btnDiagrama.Text = "Ver Diagrama";
            this.btnDiagrama.UseVisualStyleBackColor = true;
            this.btnDiagrama.Click += new System.EventHandler(this.btnDiagrama_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Consulta Rapida:";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEjecutar.Location = new System.Drawing.Point(728, 376);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(118, 38);
            this.btnEjecutar.TabIndex = 16;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEditar.Location = new System.Drawing.Point(684, 213);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(160, 35);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar Consulta";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 631);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDiagrama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.txtRapida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.txtConsigna);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.cbConsulta);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtConsigna;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRapida;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDiagrama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnEditar;
    }
}

