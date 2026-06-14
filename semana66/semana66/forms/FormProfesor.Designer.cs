namespace semana66.forms
{
    partial class FormProfesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCodigoProfesor;
        private System.Windows.Forms.TextBox tbCodigoProfesor;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.TextBox tbNombreProfesor;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVerCursos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.DataGridView dgProfesores;

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
            this.lblCodigoProfesor = new System.Windows.Forms.Label();
            this.tbCodigoProfesor = new System.Windows.Forms.TextBox();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.tbNombreProfesor = new System.Windows.Forms.TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVerCursos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.dgProfesores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoProfesor
            // 
            this.lblCodigoProfesor.AutoSize = true;
            this.lblCodigoProfesor.Location = new System.Drawing.Point(20, 29);
            this.lblCodigoProfesor.Name = "lblCodigoProfesor";
            this.lblCodigoProfesor.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoProfesor.TabIndex = 0;
            this.lblCodigoProfesor.Text = "Código:";
            // 
            // tbCodigoProfesor
            // 
            this.tbCodigoProfesor.Location = new System.Drawing.Point(117, 23);
            this.tbCodigoProfesor.Name = "tbCodigoProfesor";
            this.tbCodigoProfesor.Size = new System.Drawing.Size(200, 22);
            this.tbCodigoProfesor.TabIndex = 1;
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.Location = new System.Drawing.Point(20, 59);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(59, 16);
            this.lblNombreProfesor.TabIndex = 2;
            this.lblNombreProfesor.Text = "Nombre:";
            // 
            // tbNombreProfesor
            // 
            this.tbNombreProfesor.Location = new System.Drawing.Point(117, 53);
            this.tbNombreProfesor.Name = "tbNombreProfesor";
            this.tbNombreProfesor.Size = new System.Drawing.Size(200, 22);
            this.tbNombreProfesor.TabIndex = 3;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(20, 89);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(90, 16);
            this.lblEspecialidad.TabIndex = 4;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Ingenieria",
            "Ciencias Basicas",
            "Arquitectura"});
            this.cbEspecialidad.Location = new System.Drawing.Point(117, 83);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(200, 24);
            this.cbEspecialidad.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(351, 30);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(123, 33);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVerCursos
            // 
            this.btnVerCursos.Location = new System.Drawing.Point(351, 74);
            this.btnVerCursos.Name = "btnVerCursos";
            this.btnVerCursos.Size = new System.Drawing.Size(123, 27);
            this.btnVerCursos.TabIndex = 7;
            this.btnVerCursos.Text = "Ver Cursos";
            this.btnVerCursos.UseVisualStyleBackColor = true;
            this.btnVerCursos.Click += new System.EventHandler(this.btnVerCursos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(480, 77);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 24);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.Location = new System.Drawing.Point(480, 29);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(123, 34);
            this.btnVerReportes.TabIndex = 8;
            this.btnVerReportes.Text = "Ver Reportes";
            this.btnVerReportes.UseVisualStyleBackColor = true;
            this.btnVerReportes.Click += new System.EventHandler(this.btnVerReportes_Click);
            // 
            // dgProfesores
            // 
            this.dgProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesores.Location = new System.Drawing.Point(23, 126);
            this.dgProfesores.Name = "dgProfesores";
            this.dgProfesores.RowHeadersWidth = 51;
            this.dgProfesores.Size = new System.Drawing.Size(592, 310);
            this.dgProfesores.TabIndex = 10;
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 458);
            this.Controls.Add(this.dgProfesores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerReportes);
            this.Controls.Add(this.btnVerCursos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.tbNombreProfesor);
            this.Controls.Add(this.lblNombreProfesor);
            this.Controls.Add(this.tbCodigoProfesor);
            this.Controls.Add(this.lblCodigoProfesor);
            this.Name = "FormProfesor";
            this.Text = "FormProfesor";
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
