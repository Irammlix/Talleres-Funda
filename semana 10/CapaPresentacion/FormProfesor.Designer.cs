namespace CapaPresentacion
{
    partial class FormProfesor
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
            this.dgProfesores = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbEspecializacion = new System.Windows.Forms.TextBox();
            this.lblFechaContrato = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.dtpFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProfesores
            // 
            this.dgProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesores.Location = new System.Drawing.Point(29, 188);
            this.dgProfesores.Name = "dgProfesores";
            this.dgProfesores.RowHeadersWidth = 51;
            this.dgProfesores.RowTemplate.Height = 24;
            this.dgProfesores.Size = new System.Drawing.Size(592, 289);
            this.dgProfesores.TabIndex = 25;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(521, 483);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(372, 132);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 21;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbEspecializacion
            // 
            this.tbEspecializacion.Location = new System.Drawing.Point(179, 136);
            this.tbEspecializacion.Name = "tbEspecializacion";
            this.tbEspecializacion.Size = new System.Drawing.Size(165, 22);
            this.tbEspecializacion.TabIndex = 18;
            // 
            // lblFechaContrato
            // 
            this.lblFechaContrato.AutoSize = true;
            this.lblFechaContrato.Location = new System.Drawing.Point(64, 101);
            this.lblFechaContrato.Name = "lblFechaContrato";
            this.lblFechaContrato.Size = new System.Drawing.Size(101, 16);
            this.lblFechaContrato.TabIndex = 17;
            this.lblFechaContrato.Text = "Fecha Contrato:";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(178, 59);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(165, 22);
            this.tbApellidos.TabIndex = 16;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(98, 62);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(67, 16);
            this.lblApellidos.TabIndex = 15;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(179, 21);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(165, 22);
            this.tbNombres.TabIndex = 14;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(99, 21);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(66, 16);
            this.lblNombres.TabIndex = 13;
            this.lblNombres.Text = "Nombres:";
            // 
            // dtpFechaContrato
            // 
            this.dtpFechaContrato.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaContrato.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaContrato.Location = new System.Drawing.Point(178, 96);
            this.dtpFechaContrato.Name = "dtpFechaContrato";
            this.dtpFechaContrato.Size = new System.Drawing.Size(165, 22);
            this.dtpFechaContrato.TabIndex = 26;
            this.dtpFechaContrato.Value = new System.DateTime(2026, 6, 8, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Especializacion:";
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaContrato);
            this.Controls.Add(this.dgProfesores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbEspecializacion);
            this.Controls.Add(this.lblFechaContrato);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.lblNombres);
            this.Name = "FormProfesor";
            this.Text = "Profesores";
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProfesores;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbEspecializacion;
        private System.Windows.Forms.Label lblFechaContrato;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.DateTimePicker dtpFechaContrato;
        private System.Windows.Forms.Label label1;
    }
}