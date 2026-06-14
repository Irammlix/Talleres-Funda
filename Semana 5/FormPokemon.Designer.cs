namespace Semana_5
{
    partial class FormPokemon
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
            this.dgPokemones = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrarPokemon = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tbApodo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbkEsLegendario = new System.Windows.Forms.CheckBox();
            this.btnEliminarPokemon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPokemones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPokemones
            // 
            this.dgPokemones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPokemones.Location = new System.Drawing.Point(376, 23);
            this.dgPokemones.Name = "dgPokemones";
            this.dgPokemones.RowHeadersWidth = 51;
            this.dgPokemones.RowTemplate.Height = 24;
            this.dgPokemones.Size = new System.Drawing.Size(385, 456);
            this.dgPokemones.TabIndex = 28;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(137, 445);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(164, 34);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrarPokemon
            // 
            this.btnRegistrarPokemon.Location = new System.Drawing.Point(137, 346);
            this.btnRegistrarPokemon.Name = "btnRegistrarPokemon";
            this.btnRegistrarPokemon.Size = new System.Drawing.Size(164, 34);
            this.btnRegistrarPokemon.TabIndex = 24;
            this.btnRegistrarPokemon.Text = "Registrar Pokemon";
            this.btnRegistrarPokemon.UseVisualStyleBackColor = true;
            this.btnRegistrarPokemon.Click += new System.EventHandler(this.btnRegistrarPokemon_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Kanto",
            "Johto",
            "Hoenn",
            "Sinnoh",
            "Teselia/Unova",
            "Kalos",
            "Alola",
            "Galar",
            "Paldea"});
            this.cbTipo.Location = new System.Drawing.Point(137, 196);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(206, 24);
            this.cbTipo.TabIndex = 23;
            // 
            // tbApodo
            // 
            this.tbApodo.Location = new System.Drawing.Point(137, 150);
            this.tbApodo.Name = "tbApodo";
            this.tbApodo.Size = new System.Drawing.Size(206, 22);
            this.tbApodo.TabIndex = 22;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(137, 104);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(206, 22);
            this.tbNombre.TabIndex = 21;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(137, 66);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(206, 22);
            this.tbCodigo.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Apodo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registrar Pokemon";
            // 
            // tbPS
            // 
            this.tbPS.Location = new System.Drawing.Point(137, 247);
            this.tbPS.Name = "tbPS";
            this.tbPS.Size = new System.Drawing.Size(206, 22);
            this.tbPS.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "PS:";
            // 
            // cbkEsLegendario
            // 
            this.cbkEsLegendario.AutoSize = true;
            this.cbkEsLegendario.Location = new System.Drawing.Point(161, 293);
            this.cbkEsLegendario.Name = "cbkEsLegendario";
            this.cbkEsLegendario.Size = new System.Drawing.Size(113, 20);
            this.cbkEsLegendario.TabIndex = 31;
            this.cbkEsLegendario.Text = "Es legendario";
            this.cbkEsLegendario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPokemon
            // 
            this.btnEliminarPokemon.Location = new System.Drawing.Point(137, 394);
            this.btnEliminarPokemon.Name = "btnEliminarPokemon";
            this.btnEliminarPokemon.Size = new System.Drawing.Size(164, 34);
            this.btnEliminarPokemon.TabIndex = 32;
            this.btnEliminarPokemon.Text = "Eliminar Pokemon";
            this.btnEliminarPokemon.UseVisualStyleBackColor = true;
            this.btnEliminarPokemon.Click += new System.EventHandler(this.btnEliminarPokemon_Click);
            // 
            // FormPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.btnEliminarPokemon);
            this.Controls.Add(this.cbkEsLegendario);
            this.Controls.Add(this.tbPS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgPokemones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarPokemon);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.tbApodo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormPokemon";
            this.Text = "FormPokemon";
            ((System.ComponentModel.ISupportInitialize)(this.dgPokemones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPokemones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrarPokemon;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox tbApodo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbkEsLegendario;
        private System.Windows.Forms.Button btnEliminarPokemon;
    }
}