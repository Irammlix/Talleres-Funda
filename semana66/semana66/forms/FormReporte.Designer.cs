namespace semana66.forms
{
    partial class FormReporte
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
            this.btnListarProfesoresCursosMayorCantidadCreditos = new System.Windows.Forms.Button();
            this.btnProfesoresConMenosCantidadCursos = new System.Windows.Forms.Button();
            this.btnCursosProfesoresPorEspecialidad = new System.Windows.Forms.Button();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.dgReportes = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbAreaCurso = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnListarCursosPorAreaYMasde5Creditos = new System.Windows.Forms.Button();
            this.btnListarProfesorconPromedioCreditosPorEspecialidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarProfesoresCursosMayorCantidadCreditos
            // 
            this.btnListarProfesoresCursosMayorCantidadCreditos.Location = new System.Drawing.Point(33, 264);
            this.btnListarProfesoresCursosMayorCantidadCreditos.Name = "btnListarProfesoresCursosMayorCantidadCreditos";
            this.btnListarProfesoresCursosMayorCantidadCreditos.Size = new System.Drawing.Size(288, 55);
            this.btnListarProfesoresCursosMayorCantidadCreditos.TabIndex = 0;
            this.btnListarProfesoresCursosMayorCantidadCreditos.Text = "Listar los profesores que dictan los cursos con mayor cantidad de créditos";
            this.btnListarProfesoresCursosMayorCantidadCreditos.UseVisualStyleBackColor = true;
            this.btnListarProfesoresCursosMayorCantidadCreditos.Click += new System.EventHandler(this.btnListarProfesoresCursosMayorCantidadCreditos_Click);
            // 
            // btnProfesoresConMenosCantidadCursos
            // 
            this.btnProfesoresConMenosCantidadCursos.Location = new System.Drawing.Point(33, 218);
            this.btnProfesoresConMenosCantidadCursos.Name = "btnProfesoresConMenosCantidadCursos";
            this.btnProfesoresConMenosCantidadCursos.Size = new System.Drawing.Size(288, 40);
            this.btnProfesoresConMenosCantidadCursos.TabIndex = 1;
            this.btnProfesoresConMenosCantidadCursos.Text = "Listar los profesores que dictan menos cursos";
            this.btnProfesoresConMenosCantidadCursos.UseVisualStyleBackColor = true;
            this.btnProfesoresConMenosCantidadCursos.Click += new System.EventHandler(this.btnProfesoresConMenosCantidadCursos_Click);
            // 
            // btnCursosProfesoresPorEspecialidad
            // 
            this.btnCursosProfesoresPorEspecialidad.Location = new System.Drawing.Point(37, 88);
            this.btnCursosProfesoresPorEspecialidad.Name = "btnCursosProfesoresPorEspecialidad";
            this.btnCursosProfesoresPorEspecialidad.Size = new System.Drawing.Size(288, 59);
            this.btnCursosProfesoresPorEspecialidad.TabIndex = 2;
            this.btnCursosProfesoresPorEspecialidad.Text = "Listar los cursos que pertenecen a profesores de una determinada especialidad";
            this.btnCursosProfesoresPorEspecialidad.UseVisualStyleBackColor = true;
            this.btnCursosProfesoresPorEspecialidad.Click += new System.EventHandler(this.btnCursosProfesoresPorEspecialidad_Click);
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Ingenieria",
            "Ciencias Basicas",
            "Arquitectura"});
            this.cbEspecialidad.Location = new System.Drawing.Point(130, 41);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(200, 24);
            this.cbEspecialidad.TabIndex = 7;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(34, 44);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(90, 16);
            this.lblEspecialidad.TabIndex = 6;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // dgReportes
            // 
            this.dgReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportes.Location = new System.Drawing.Point(375, 41);
            this.dgReportes.Name = "dgReportes";
            this.dgReportes.RowHeadersWidth = 51;
            this.dgReportes.RowTemplate.Height = 24;
            this.dgReportes.Size = new System.Drawing.Size(718, 380);
            this.dgReportes.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(290, 457);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(184, 28);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbAreaCurso
            // 
            this.cbAreaCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAreaCurso.FormattingEnabled = true;
            this.cbAreaCurso.Items.AddRange(new object[] {
            "Ingenieria de Sistemas",
            "Ingenieria de Software",
            "Ciencias de la Computacion"});
            this.cbAreaCurso.Location = new System.Drawing.Point(97, 335);
            this.cbAreaCurso.Name = "cbAreaCurso";
            this.cbAreaCurso.Size = new System.Drawing.Size(200, 24);
            this.cbAreaCurso.TabIndex = 11;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(30, 338);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(39, 16);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Area:";
            // 
            // btnListarCursosPorAreaYMasde5Creditos
            // 
            this.btnListarCursosPorAreaYMasde5Creditos.Location = new System.Drawing.Point(33, 365);
            this.btnListarCursosPorAreaYMasde5Creditos.Name = "btnListarCursosPorAreaYMasde5Creditos";
            this.btnListarCursosPorAreaYMasde5Creditos.Size = new System.Drawing.Size(288, 55);
            this.btnListarCursosPorAreaYMasde5Creditos.TabIndex = 12;
            this.btnListarCursosPorAreaYMasde5Creditos.Text = "Listar Cursos por Area y con mas de 5 creditos";
            this.btnListarCursosPorAreaYMasde5Creditos.UseVisualStyleBackColor = true;
            this.btnListarCursosPorAreaYMasde5Creditos.Click += new System.EventHandler(this.btnListarCursosPorAreaYMasde5Creditos_Click);
            // 
            // btnListarProfesorconPromedioCreditosPorEspecialidad
            // 
            this.btnListarProfesorconPromedioCreditosPorEspecialidad.Location = new System.Drawing.Point(37, 153);
            this.btnListarProfesorconPromedioCreditosPorEspecialidad.Name = "btnListarProfesorconPromedioCreditosPorEspecialidad";
            this.btnListarProfesorconPromedioCreditosPorEspecialidad.Size = new System.Drawing.Size(288, 59);
            this.btnListarProfesorconPromedioCreditosPorEspecialidad.TabIndex = 13;
            this.btnListarProfesorconPromedioCreditosPorEspecialidad.Text = "Listar Profesores y el promedio de sus creditos en cursos, con mas de 3, para una" +
    " determinada especialidad";
            this.btnListarProfesorconPromedioCreditosPorEspecialidad.UseVisualStyleBackColor = true;
            this.btnListarProfesorconPromedioCreditosPorEspecialidad.Click += new System.EventHandler(this.btnListarProfesorconPromedioCreditosPorEspecialidad_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 497);
            this.Controls.Add(this.btnListarProfesorconPromedioCreditosPorEspecialidad);
            this.Controls.Add(this.btnListarCursosPorAreaYMasde5Creditos);
            this.Controls.Add(this.cbAreaCurso);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgReportes);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.btnCursosProfesoresPorEspecialidad);
            this.Controls.Add(this.btnProfesoresConMenosCantidadCursos);
            this.Controls.Add(this.btnListarProfesoresCursosMayorCantidadCreditos);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarProfesoresCursosMayorCantidadCreditos;
        private System.Windows.Forms.Button btnProfesoresConMenosCantidadCursos;
        private System.Windows.Forms.Button btnCursosProfesoresPorEspecialidad;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.DataGridView dgReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbAreaCurso;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnListarCursosPorAreaYMasde5Creditos;
        private System.Windows.Forms.Button btnListarProfesorconPromedioCreditosPorEspecialidad;
    }
}