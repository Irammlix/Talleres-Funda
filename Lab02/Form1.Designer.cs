namespace Lab02
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.numUDNumTardanzas = new System.Windows.Forms.NumericUpDown();
            this.lblTardanza = new System.Windows.Forms.Label();
            this.btnProcesarEmpleado = new System.Windows.Forms.Button();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.lblNumFaltas = new System.Windows.Forms.Label();
            this.numUDNumFaltas = new System.Windows.Forms.NumericUpDown();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTardanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroFaltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNumTardanzas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNumFaltas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(170, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(257, 29);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(173, 22);
            this.tbNombre.TabIndex = 1;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(163, 63);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 16);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbCategoria.Location = new System.Drawing.Point(257, 63);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(173, 24);
            this.cbCategoria.TabIndex = 3;
            // 
            // numUDNumTardanzas
            // 
            this.numUDNumTardanzas.Location = new System.Drawing.Point(257, 107);
            this.numUDNumTardanzas.Name = "numUDNumTardanzas";
            this.numUDNumTardanzas.Size = new System.Drawing.Size(173, 22);
            this.numUDNumTardanzas.TabIndex = 4;
            // 
            // lblTardanza
            // 
            this.lblTardanza.AutoSize = true;
            this.lblTardanza.Location = new System.Drawing.Point(130, 106);
            this.lblTardanza.Name = "lblTardanza";
            this.lblTardanza.Size = new System.Drawing.Size(102, 16);
            this.lblTardanza.TabIndex = 5;
            this.lblTardanza.Text = "Num. Tardanza:";
            // 
            // btnProcesarEmpleado
            // 
            this.btnProcesarEmpleado.Location = new System.Drawing.Point(513, 63);
            this.btnProcesarEmpleado.Name = "btnProcesarEmpleado";
            this.btnProcesarEmpleado.Size = new System.Drawing.Size(182, 50);
            this.btnProcesarEmpleado.TabIndex = 6;
            this.btnProcesarEmpleado.Text = "Procesar Empleado";
            this.btnProcesarEmpleado.UseVisualStyleBackColor = true;
            this.btnProcesarEmpleado.Click += new System.EventHandler(this.btnProcesarEmpleado_Click);
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Categoria,
            this.MinTardanza,
            this.NumeroFaltas,
            this.Pago});
            this.dgEmpleados.Location = new System.Drawing.Point(12, 184);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.RowHeadersWidth = 51;
            this.dgEmpleados.RowTemplate.Height = 24;
            this.dgEmpleados.Size = new System.Drawing.Size(816, 239);
            this.dgEmpleados.TabIndex = 7;
            this.dgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellContentClick);
            // 
            // lblNumFaltas
            // 
            this.lblNumFaltas.AutoSize = true;
            this.lblNumFaltas.Location = new System.Drawing.Point(151, 143);
            this.lblNumFaltas.Name = "lblNumFaltas";
            this.lblNumFaltas.Size = new System.Drawing.Size(81, 16);
            this.lblNumFaltas.TabIndex = 8;
            this.lblNumFaltas.Text = "Num. Faltas:";
            // 
            // numUDNumFaltas
            // 
            this.numUDNumFaltas.Location = new System.Drawing.Point(257, 143);
            this.numUDNumFaltas.Name = "numUDNumFaltas";
            this.numUDNumFaltas.Size = new System.Drawing.Size(173, 22);
            this.numUDNumFaltas.TabIndex = 9;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 125;
            // 
            // MinTardanza
            // 
            this.MinTardanza.HeaderText = "MinTardanza";
            this.MinTardanza.MinimumWidth = 6;
            this.MinTardanza.Name = "MinTardanza";
            this.MinTardanza.Width = 125;
            // 
            // NumeroFaltas
            // 
            this.NumeroFaltas.HeaderText = "NumeroFaltas";
            this.NumeroFaltas.MinimumWidth = 6;
            this.NumeroFaltas.Name = "NumeroFaltas";
            this.NumeroFaltas.Width = 125;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.MinimumWidth = 6;
            this.Pago.Name = "Pago";
            this.Pago.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.numUDNumFaltas);
            this.Controls.Add(this.lblNumFaltas);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.btnProcesarEmpleado);
            this.Controls.Add(this.lblTardanza);
            this.Controls.Add(this.numUDNumTardanzas);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDNumTardanzas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNumFaltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.NumericUpDown numUDNumTardanzas;
        private System.Windows.Forms.Label lblTardanza;
        private System.Windows.Forms.Button btnProcesarEmpleado;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.Label lblNumFaltas;
        private System.Windows.Forms.NumericUpDown numUDNumFaltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinTardanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFaltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
    }
}

