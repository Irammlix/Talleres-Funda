namespace semana66.forms
{
    partial class FormCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCodigoCurso;
        private System.Windows.Forms.TextBox tbCodigoCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.TextBox tbNombreCurso;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.TextBox tbCreditos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgCursos;

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
            this.lblCodigoCurso = new System.Windows.Forms.Label();
            this.tbCodigoCurso = new System.Windows.Forms.TextBox();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.tbNombreCurso = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.tbCreditos = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgCursos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcodigoProfesor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoCurso
            // 
            this.lblCodigoCurso.AutoSize = true;
            this.lblCodigoCurso.Location = new System.Drawing.Point(24, 54);
            this.lblCodigoCurso.Name = "lblCodigoCurso";
            this.lblCodigoCurso.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoCurso.TabIndex = 0;
            this.lblCodigoCurso.Text = "Código:";
            // 
            // tbCodigoCurso
            // 
            this.tbCodigoCurso.Location = new System.Drawing.Point(91, 51);
            this.tbCodigoCurso.Name = "tbCodigoCurso";
            this.tbCodigoCurso.Size = new System.Drawing.Size(200, 22);
            this.tbCodigoCurso.TabIndex = 1;
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Location = new System.Drawing.Point(24, 84);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(59, 16);
            this.lblNombreCurso.TabIndex = 2;
            this.lblNombreCurso.Text = "Nombre:";
            // 
            // tbNombreCurso
            // 
            this.tbNombreCurso.Location = new System.Drawing.Point(91, 81);
            this.tbNombreCurso.Name = "tbNombreCurso";
            this.tbNombreCurso.Size = new System.Drawing.Size(200, 22);
            this.tbNombreCurso.TabIndex = 3;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(24, 114);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(39, 16);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area:";
            // 
            // cbArea
            // 
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "Ingenieria de Sistemas",
            "Ingenieria de Software",
            "Ciencias de la Computacion"});
            this.cbArea.Location = new System.Drawing.Point(91, 111);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(200, 24);
            this.cbArea.TabIndex = 5;
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Location = new System.Drawing.Point(24, 144);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(60, 16);
            this.lblCreditos.TabIndex = 6;
            this.lblCreditos.Text = "Creditos:";
            // 
            // tbCreditos
            // 
            this.tbCreditos.Location = new System.Drawing.Point(91, 141);
            this.tbCreditos.Name = "tbCreditos";
            this.tbCreditos.Size = new System.Drawing.Size(200, 22);
            this.tbCreditos.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(314, 51);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(115, 33);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(314, 90);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 34);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgCursos
            // 
            this.dgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCursos.Location = new System.Drawing.Point(16, 182);
            this.dgCursos.Name = "dgCursos";
            this.dgCursos.RowHeadersWidth = 51;
            this.dgCursos.Size = new System.Drawing.Size(467, 219);
            this.dgCursos.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código Profesor:";
            // 
            // lblcodigoProfesor
            // 
            this.lblcodigoProfesor.AutoSize = true;
            this.lblcodigoProfesor.Location = new System.Drawing.Point(156, 20);
            this.lblcodigoProfesor.Name = "lblcodigoProfesor";
            this.lblcodigoProfesor.Size = new System.Drawing.Size(11, 16);
            this.lblcodigoProfesor.TabIndex = 12;
            this.lblcodigoProfesor.Text = "-";
            // 
            // FormCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 419);
            this.Controls.Add(this.lblcodigoProfesor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCursos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbCreditos);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.tbNombreCurso);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.tbCodigoCurso);
            this.Controls.Add(this.lblCodigoCurso);
            this.Name = "FormCurso";
            this.Text = "FormCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcodigoProfesor;
    }
}
