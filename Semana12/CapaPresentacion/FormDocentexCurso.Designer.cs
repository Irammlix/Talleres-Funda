namespace CapaPresentacion
{
    partial class FormDocentexCurso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDocente = new System.Windows.Forms.ComboBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.dgDocentesyCursos = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnBuscarPorDocente = new System.Windows.Forms.Button();
            this.btnBuscarPorCurso = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDocentesyCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Docente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semestre:";
            // 
            // cbDocente
            // 
            this.cbDocente.FormattingEnabled = true;
            this.cbDocente.Location = new System.Drawing.Point(137, 57);
            this.cbDocente.Name = "cbDocente";
            this.cbDocente.Size = new System.Drawing.Size(158, 24);
            this.cbDocente.TabIndex = 3;
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(137, 107);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(158, 24);
            this.cbCurso.TabIndex = 4;
            // 
            // cbSemestre
            // 
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Items.AddRange(new object[] {
            "2025-0",
            "2025-1",
            "2025-2",
            "2026-0",
            "2026-1",
            "2026-2"});
            this.cbSemestre.Location = new System.Drawing.Point(137, 158);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(158, 24);
            this.cbSemestre.TabIndex = 5;
            // 
            // dgDocentesyCursos
            // 
            this.dgDocentesyCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDocentesyCursos.Location = new System.Drawing.Point(336, 107);
            this.dgDocentesyCursos.Name = "dgDocentesyCursos";
            this.dgDocentesyCursos.RowHeadersWidth = 51;
            this.dgDocentesyCursos.RowTemplate.Height = 24;
            this.dgDocentesyCursos.Size = new System.Drawing.Size(449, 408);
            this.dgDocentesyCursos.TabIndex = 6;
            this.dgDocentesyCursos.SelectionChanged += new System.EventHandler(this.dgDocentesyCursos_SelectionChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(158, 208);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(137, 36);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(158, 259);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 35);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInactivar
            // 
            this.btnInactivar.Location = new System.Drawing.Point(158, 309);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(137, 33);
            this.btnInactivar.TabIndex = 10;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // btnBuscarPorDocente
            // 
            this.btnBuscarPorDocente.Location = new System.Drawing.Point(41, 468);
            this.btnBuscarPorDocente.Name = "btnBuscarPorDocente";
            this.btnBuscarPorDocente.Size = new System.Drawing.Size(254, 36);
            this.btnBuscarPorDocente.TabIndex = 11;
            this.btnBuscarPorDocente.Text = "Buscar Por Docente";
            this.btnBuscarPorDocente.UseVisualStyleBackColor = true;
            this.btnBuscarPorDocente.Click += new System.EventHandler(this.btnBuscarPorDocente_Click);
            // 
            // btnBuscarPorCurso
            // 
            this.btnBuscarPorCurso.Location = new System.Drawing.Point(41, 419);
            this.btnBuscarPorCurso.Name = "btnBuscarPorCurso";
            this.btnBuscarPorCurso.Size = new System.Drawing.Size(254, 32);
            this.btnBuscarPorCurso.TabIndex = 12;
            this.btnBuscarPorCurso.Text = "Buscar Por Curso";
            this.btnBuscarPorCurso.UseVisualStyleBackColor = true;
            this.btnBuscarPorCurso.Click += new System.EventHandler(this.btnBuscarPorCurso_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(158, 362);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(137, 32);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(666, 534);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 32);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Docentes y Cursos";
            // 
            // FormDocentexCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(807, 578);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscarPorCurso);
            this.Controls.Add(this.btnBuscarPorDocente);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgDocentesyCursos);
            this.Controls.Add(this.cbSemestre);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.cbDocente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDocentexCurso";
            this.Text = "Docentes y Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgDocentesyCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDocente;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.DataGridView dgDocentesyCursos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnBuscarPorDocente;
        private System.Windows.Forms.Button btnBuscarPorCurso;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
    }
}

