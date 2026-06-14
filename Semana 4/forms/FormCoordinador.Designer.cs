namespace Semana_4
{
    partial class FormCoordinador
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigoCoordinador = new System.Windows.Forms.TextBox();
            this.cbCentroDistribucion = new System.Windows.Forms.ComboBox();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVerRepartidores = new System.Windows.Forms.Button();
            this.btnBuscarPorCentro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgCoordinadores = new System.Windows.Forms.DataGridView();
            this.btnModificarCoordinador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCoordinadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Centro de Distribucion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Turno:";
            // 
            // tbCodigoCoordinador
            // 
            this.tbCodigoCoordinador.Location = new System.Drawing.Point(181, 36);
            this.tbCodigoCoordinador.Name = "tbCodigoCoordinador";
            this.tbCodigoCoordinador.Size = new System.Drawing.Size(183, 22);
            this.tbCodigoCoordinador.TabIndex = 3;
            // 
            // cbCentroDistribucion
            // 
            this.cbCentroDistribucion.FormattingEnabled = true;
            this.cbCentroDistribucion.Items.AddRange(new object[] {
            "Norte",
            "Sur",
            "Este",
            "Oeste"});
            this.cbCentroDistribucion.Location = new System.Drawing.Point(181, 85);
            this.cbCentroDistribucion.Name = "cbCentroDistribucion";
            this.cbCentroDistribucion.Size = new System.Drawing.Size(131, 24);
            this.cbCentroDistribucion.TabIndex = 4;
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.cbTurno.Location = new System.Drawing.Point(181, 141);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(131, 24);
            this.cbTurno.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(35, 189);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVerRepartidores
            // 
            this.btnVerRepartidores.Location = new System.Drawing.Point(156, 189);
            this.btnVerRepartidores.Name = "btnVerRepartidores";
            this.btnVerRepartidores.Size = new System.Drawing.Size(146, 28);
            this.btnVerRepartidores.TabIndex = 7;
            this.btnVerRepartidores.Text = "Ver Repartidores";
            this.btnVerRepartidores.UseVisualStyleBackColor = true;
            this.btnVerRepartidores.Click += new System.EventHandler(this.btnVerRepartidores_Click);
            // 
            // btnBuscarPorCentro
            // 
            this.btnBuscarPorCentro.Location = new System.Drawing.Point(345, 85);
            this.btnBuscarPorCentro.Name = "btnBuscarPorCentro";
            this.btnBuscarPorCentro.Size = new System.Drawing.Size(265, 37);
            this.btnBuscarPorCentro.TabIndex = 8;
            this.btnBuscarPorCentro.Text = "Buscar Por Centro de Distribucion";
            this.btnBuscarPorCentro.UseVisualStyleBackColor = true;
            this.btnBuscarPorCentro.Click += new System.EventHandler(this.btnBuscarPorCentro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(321, 189);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 28);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgCoordinadores
            // 
            this.dgCoordinadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCoordinadores.Location = new System.Drawing.Point(35, 232);
            this.dgCoordinadores.Name = "dgCoordinadores";
            this.dgCoordinadores.RowHeadersWidth = 51;
            this.dgCoordinadores.RowTemplate.Height = 24;
            this.dgCoordinadores.Size = new System.Drawing.Size(595, 196);
            this.dgCoordinadores.TabIndex = 11;
            this.dgCoordinadores.SelectionChanged += new System.EventHandler(this.dgCoordinadores_SelectionChanged);
            // 
            // btnModificarCoordinador
            // 
            this.btnModificarCoordinador.Location = new System.Drawing.Point(345, 128);
            this.btnModificarCoordinador.Name = "btnModificarCoordinador";
            this.btnModificarCoordinador.Size = new System.Drawing.Size(265, 42);
            this.btnModificarCoordinador.TabIndex = 12;
            this.btnModificarCoordinador.Text = "Modificar Coordinador";
            this.btnModificarCoordinador.UseVisualStyleBackColor = true;
            this.btnModificarCoordinador.Click += new System.EventHandler(this.btnModificarCoordinador_Click);
            // 
            // FormCoordinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.btnModificarCoordinador);
            this.Controls.Add(this.dgCoordinadores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarPorCentro);
            this.Controls.Add(this.btnVerRepartidores);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.cbCentroDistribucion);
            this.Controls.Add(this.tbCodigoCoordinador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCoordinador";
            this.Text = "Coordinadores";
            this.Load += new System.EventHandler(this.FormCoordinador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCoordinadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodigoCoordinador;
        private System.Windows.Forms.ComboBox cbCentroDistribucion;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVerRepartidores;
        private System.Windows.Forms.Button btnBuscarPorCentro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgCoordinadores;
        private System.Windows.Forms.Button btnModificarCoordinador;
    }
}

