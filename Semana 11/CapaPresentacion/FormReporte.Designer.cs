namespace CapaPresentacion
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnObtenerMontoPromedio = new System.Windows.Forms.Button();
            this.btnListarRetirosEmpleadosMasDe30Anios = new System.Windows.Forms.Button();
            this.btnRetirosGestionadosPorAFP = new System.Windows.Forms.Button();
            this.dgReportes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reportes";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(486, 616);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(161, 30);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnObtenerMontoPromedio
            // 
            this.btnObtenerMontoPromedio.Location = new System.Drawing.Point(21, 119);
            this.btnObtenerMontoPromedio.Name = "btnObtenerMontoPromedio";
            this.btnObtenerMontoPromedio.Size = new System.Drawing.Size(492, 30);
            this.btnObtenerMontoPromedio.TabIndex = 18;
            this.btnObtenerMontoPromedio.Text = "Monto Promedio de Retiros";
            this.btnObtenerMontoPromedio.UseVisualStyleBackColor = true;
            this.btnObtenerMontoPromedio.Click += new System.EventHandler(this.btnObtenerMontoPromedio_Click);
            // 
            // btnListarRetirosEmpleadosMasDe30Anios
            // 
            this.btnListarRetirosEmpleadosMasDe30Anios.Location = new System.Drawing.Point(21, 71);
            this.btnListarRetirosEmpleadosMasDe30Anios.Name = "btnListarRetirosEmpleadosMasDe30Anios";
            this.btnListarRetirosEmpleadosMasDe30Anios.Size = new System.Drawing.Size(492, 30);
            this.btnListarRetirosEmpleadosMasDe30Anios.TabIndex = 17;
            this.btnListarRetirosEmpleadosMasDe30Anios.Text = "Listar los retiros de Empleados con mas de 30 años";
            this.btnListarRetirosEmpleadosMasDe30Anios.UseVisualStyleBackColor = true;
            this.btnListarRetirosEmpleadosMasDe30Anios.Click += new System.EventHandler(this.btnListarRetirosEmpleadosMasDe30Anios_Click);
            // 
            // btnRetirosGestionadosPorAFP
            // 
            this.btnRetirosGestionadosPorAFP.Location = new System.Drawing.Point(21, 20);
            this.btnRetirosGestionadosPorAFP.Name = "btnRetirosGestionadosPorAFP";
            this.btnRetirosGestionadosPorAFP.Size = new System.Drawing.Size(492, 30);
            this.btnRetirosGestionadosPorAFP.TabIndex = 16;
            this.btnRetirosGestionadosPorAFP.Text = "Listar los retiros que son gestionados por la AFP Habitat";
            this.btnRetirosGestionadosPorAFP.UseVisualStyleBackColor = true;
            this.btnRetirosGestionadosPorAFP.Click += new System.EventHandler(this.btnRetirosGestionadosPorAFP_Click);
            // 
            // dgReportes
            // 
            this.dgReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportes.Location = new System.Drawing.Point(12, 238);
            this.dgReportes.Name = "dgReportes";
            this.dgReportes.RowHeadersWidth = 51;
            this.dgReportes.RowTemplate.Height = 24;
            this.dgReportes.Size = new System.Drawing.Size(635, 362);
            this.dgReportes.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObtenerMontoPromedio);
            this.groupBox1.Controls.Add(this.btnListarRetirosEmpleadosMasDe30Anios);
            this.groupBox1.Controls.Add(this.btnRetirosGestionadosPorAFP);
            this.groupBox1.Location = new System.Drawing.Point(97, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 161);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 658);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgReportes);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnObtenerMontoPromedio;
        private System.Windows.Forms.Button btnListarRetirosEmpleadosMasDe30Anios;
        private System.Windows.Forms.Button btnRetirosGestionadosPorAFP;
        private System.Windows.Forms.DataGridView dgReportes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}