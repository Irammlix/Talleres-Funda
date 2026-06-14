namespace LabParcialEmpleado.forms
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSueldoMax = new System.Windows.Forms.TextBox();
            this.tbSueldoMin = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnListarPorRangoSueldos = new System.Windows.Forms.Button();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Sueldo Máximo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Sueldo Mínimo:";
            // 
            // tbSueldoMax
            // 
            this.tbSueldoMax.Location = new System.Drawing.Point(240, 67);
            this.tbSueldoMax.Margin = new System.Windows.Forms.Padding(4);
            this.tbSueldoMax.Name = "tbSueldoMax";
            this.tbSueldoMax.Size = new System.Drawing.Size(183, 22);
            this.tbSueldoMax.TabIndex = 32;
            // 
            // tbSueldoMin
            // 
            this.tbSueldoMin.Location = new System.Drawing.Point(240, 35);
            this.tbSueldoMin.Margin = new System.Windows.Forms.Padding(4);
            this.tbSueldoMin.Name = "tbSueldoMin";
            this.tbSueldoMin.Size = new System.Drawing.Size(183, 22);
            this.tbSueldoMin.TabIndex = 31;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(589, 67);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnListarPorRangoSueldos
            // 
            this.btnListarPorRangoSueldos.Location = new System.Drawing.Point(472, 32);
            this.btnListarPorRangoSueldos.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarPorRangoSueldos.Name = "btnListarPorRangoSueldos";
            this.btnListarPorRangoSueldos.Size = new System.Drawing.Size(217, 28);
            this.btnListarPorRangoSueldos.TabIndex = 29;
            this.btnListarPorRangoSueldos.Text = "Listar Por Rango de Sueldos";
            this.btnListarPorRangoSueldos.UseVisualStyleBackColor = true;
            this.btnListarPorRangoSueldos.Click += new System.EventHandler(this.btnListarPorRangoSueldos_Click_1);
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Location = new System.Drawing.Point(111, 147);
            this.dgEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.RowHeadersWidth = 51;
            this.dgEmpleados.Size = new System.Drawing.Size(579, 272);
            this.dgEmpleados.TabIndex = 28;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSueldoMax);
            this.Controls.Add(this.tbSueldoMin);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListarPorRangoSueldos);
            this.Controls.Add(this.dgEmpleados);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSueldoMax;
        private System.Windows.Forms.TextBox tbSueldoMin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnListarPorRangoSueldos;
        private System.Windows.Forms.DataGridView dgEmpleados;
    }
}