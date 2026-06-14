namespace Semana_4.forms
{
    partial class FormRepartidor
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
            this.dgRepartidores = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTop3PorEntregas = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbZona = new System.Windows.Forms.ComboBox();
            this.tbCodigoRepartidor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumEntregas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCodigoCoordinador = new System.Windows.Forms.Label();
            this.btnModificarRepartidor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepartidores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRepartidores
            // 
            this.dgRepartidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRepartidores.Location = new System.Drawing.Point(21, 274);
            this.dgRepartidores.Name = "dgRepartidores";
            this.dgRepartidores.RowHeadersWidth = 51;
            this.dgRepartidores.RowTemplate.Height = 24;
            this.dgRepartidores.Size = new System.Drawing.Size(595, 196);
            this.dgRepartidores.TabIndex = 22;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(357, 231);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 28);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTop3PorEntregas
            // 
            this.btnTop3PorEntregas.Location = new System.Drawing.Point(167, 231);
            this.btnTop3PorEntregas.Name = "btnTop3PorEntregas";
            this.btnTop3PorEntregas.Size = new System.Drawing.Size(146, 28);
            this.btnTop3PorEntregas.TabIndex = 19;
            this.btnTop3PorEntregas.Text = "Top 3 por Entregas";
            this.btnTop3PorEntregas.UseVisualStyleBackColor = true;
            this.btnTop3PorEntregas.Click += new System.EventHandler(this.btnTop3PorEntregas_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(21, 231);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbZona
            // 
            this.cbZona.FormattingEnabled = true;
            this.cbZona.Items.AddRange(new object[] {
            "Urbana",
            "Rural",
            "Mixta"});
            this.cbZona.Location = new System.Drawing.Point(194, 124);
            this.cbZona.Name = "cbZona";
            this.cbZona.Size = new System.Drawing.Size(131, 24);
            this.cbZona.TabIndex = 16;
            // 
            // tbCodigoRepartidor
            // 
            this.tbCodigoRepartidor.Location = new System.Drawing.Point(194, 75);
            this.tbCodigoRepartidor.Name = "tbCodigoRepartidor";
            this.tbCodigoRepartidor.Size = new System.Drawing.Size(183, 22);
            this.tbCodigoRepartidor.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Numero de Entregas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(132, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Zona:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(119, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo:";
            // 
            // tbNumEntregas
            // 
            this.tbNumEntregas.Location = new System.Drawing.Point(194, 180);
            this.tbNumEntregas.Name = "tbNumEntregas";
            this.tbNumEntregas.Size = new System.Drawing.Size(183, 22);
            this.tbNumEntregas.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(28, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Codigo de Coordinador:";
            // 
            // lblCodigoCoordinador
            // 
            this.lblCodigoCoordinador.AutoSize = true;
            this.lblCodigoCoordinador.BackColor = System.Drawing.Color.GhostWhite;
            this.lblCodigoCoordinador.Location = new System.Drawing.Point(201, 28);
            this.lblCodigoCoordinador.Name = "lblCodigoCoordinador";
            this.lblCodigoCoordinador.Size = new System.Drawing.Size(11, 16);
            this.lblCodigoCoordinador.TabIndex = 25;
            this.lblCodigoCoordinador.Text = "-";
            // 
            // btnModificarRepartidor
            // 
            this.btnModificarRepartidor.Location = new System.Drawing.Point(435, 123);
            this.btnModificarRepartidor.Name = "btnModificarRepartidor";
            this.btnModificarRepartidor.Size = new System.Drawing.Size(166, 34);
            this.btnModificarRepartidor.TabIndex = 26;
            this.btnModificarRepartidor.Text = "Modificar Repartidor";
            this.btnModificarRepartidor.UseVisualStyleBackColor = true;
            this.btnModificarRepartidor.Click += new System.EventHandler(this.btnModificarRepartidor_Click);
            // 
            // FormRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.btnModificarRepartidor);
            this.Controls.Add(this.lblCodigoCoordinador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNumEntregas);
            this.Controls.Add(this.dgRepartidores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTop3PorEntregas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbZona);
            this.Controls.Add(this.tbCodigoRepartidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRepartidor";
            this.Text = "FormRepartidor";
            ((System.ComponentModel.ISupportInitialize)(this.dgRepartidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRepartidores;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnTop3PorEntregas;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbZona;
        private System.Windows.Forms.TextBox tbCodigoRepartidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumEntregas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCodigoCoordinador;
        private System.Windows.Forms.Button btnModificarRepartidor;
    }
}