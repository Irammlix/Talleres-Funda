namespace Semana_5
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBuscarPSMax = new System.Windows.Forms.Button();
            this.btnBuscarMenorCantidadPok = new System.Windows.Forms.Button();
            this.btnBuscarPorRegion = new System.Windows.Forms.Button();
            this.btnBuscarNombrePokemon = new System.Windows.Forms.Button();
            this.tbNombreEntrenador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBuscarLegendarios = new System.Windows.Forms.Button();
            this.btnBuscarRangoEdadEntrenadotes = new System.Windows.Forms.Button();
            this.tbEdadMax = new System.Windows.Forms.TextBox();
            this.tbEdadMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgReportes = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.btnReporteVitalidad = new System.Windows.Forms.Button();
            this.btnCensoLegendario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(404, 319);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // btnBuscarPSMax
            // 
            this.btnBuscarPSMax.Location = new System.Drawing.Point(38, 303);
            this.btnBuscarPSMax.Name = "btnBuscarPSMax";
            this.btnBuscarPSMax.Size = new System.Drawing.Size(206, 48);
            this.btnBuscarPSMax.TabIndex = 27;
            this.btnBuscarPSMax.Text = "Buscar por max PS de Pokemons";
            this.btnBuscarPSMax.UseVisualStyleBackColor = true;
            this.btnBuscarPSMax.Click += new System.EventHandler(this.btnBuscarPSMax_Click);
            // 
            // btnBuscarMenorCantidadPok
            // 
            this.btnBuscarMenorCantidadPok.Location = new System.Drawing.Point(40, 245);
            this.btnBuscarMenorCantidadPok.Name = "btnBuscarMenorCantidadPok";
            this.btnBuscarMenorCantidadPok.Size = new System.Drawing.Size(204, 52);
            this.btnBuscarMenorCantidadPok.TabIndex = 26;
            this.btnBuscarMenorCantidadPok.Text = "Buscar por Menor Cantidad de Pokemons";
            this.btnBuscarMenorCantidadPok.UseVisualStyleBackColor = true;
            this.btnBuscarMenorCantidadPok.Click += new System.EventHandler(this.btnBuscarMenorCantidadPok_Click);
            // 
            // btnBuscarPorRegion
            // 
            this.btnBuscarPorRegion.Location = new System.Drawing.Point(40, 204);
            this.btnBuscarPorRegion.Name = "btnBuscarPorRegion";
            this.btnBuscarPorRegion.Size = new System.Drawing.Size(204, 25);
            this.btnBuscarPorRegion.TabIndex = 25;
            this.btnBuscarPorRegion.Text = "Buscar por Region";
            this.btnBuscarPorRegion.UseVisualStyleBackColor = true;
            this.btnBuscarPorRegion.Click += new System.EventHandler(this.btnBuscarPorRegion_Click);
            // 
            // btnBuscarNombrePokemon
            // 
            this.btnBuscarNombrePokemon.Location = new System.Drawing.Point(77, 109);
            this.btnBuscarNombrePokemon.Name = "btnBuscarNombrePokemon";
            this.btnBuscarNombrePokemon.Size = new System.Drawing.Size(255, 29);
            this.btnBuscarNombrePokemon.TabIndex = 24;
            this.btnBuscarNombrePokemon.Text = "Buscar por nombre del Pokemon";
            this.btnBuscarNombrePokemon.UseVisualStyleBackColor = true;
            this.btnBuscarNombrePokemon.Click += new System.EventHandler(this.btnBuscarNombrePokemon_Click);
            // 
            // tbNombreEntrenador
            // 
            this.tbNombreEntrenador.Location = new System.Drawing.Point(109, 65);
            this.tbNombreEntrenador.Name = "tbNombreEntrenador";
            this.tbNombreEntrenador.Size = new System.Drawing.Size(223, 22);
            this.tbNombreEntrenador.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Region:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Reportes Entrenador";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(28, 408);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(404, 204);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // btnBuscarLegendarios
            // 
            this.btnBuscarLegendarios.Location = new System.Drawing.Point(259, 544);
            this.btnBuscarLegendarios.Name = "btnBuscarLegendarios";
            this.btnBuscarLegendarios.Size = new System.Drawing.Size(155, 48);
            this.btnBuscarLegendarios.TabIndex = 35;
            this.btnBuscarLegendarios.Text = "Buscar Legendarios";
            this.btnBuscarLegendarios.UseVisualStyleBackColor = true;
            this.btnBuscarLegendarios.Click += new System.EventHandler(this.btnBuscarLegendarios_Click);
            // 
            // btnBuscarRangoEdadEntrenadotes
            // 
            this.btnBuscarRangoEdadEntrenadotes.Location = new System.Drawing.Point(49, 544);
            this.btnBuscarRangoEdadEntrenadotes.Name = "btnBuscarRangoEdadEntrenadotes";
            this.btnBuscarRangoEdadEntrenadotes.Size = new System.Drawing.Size(204, 48);
            this.btnBuscarRangoEdadEntrenadotes.TabIndex = 34;
            this.btnBuscarRangoEdadEntrenadotes.Text = "Buscar por Rango de Edad de Entrenadores";
            this.btnBuscarRangoEdadEntrenadotes.UseVisualStyleBackColor = true;
            this.btnBuscarRangoEdadEntrenadotes.Click += new System.EventHandler(this.btnBuscarRangoEdadEntrenadotes_Click);
            // 
            // tbEdadMax
            // 
            this.tbEdadMax.Location = new System.Drawing.Point(144, 493);
            this.tbEdadMax.Name = "tbEdadMax";
            this.tbEdadMax.Size = new System.Drawing.Size(219, 22);
            this.tbEdadMax.TabIndex = 32;
            // 
            // tbEdadMin
            // 
            this.tbEdadMin.Location = new System.Drawing.Point(144, 456);
            this.tbEdadMin.Name = "tbEdadMin";
            this.tbEdadMin.Size = new System.Drawing.Size(219, 22);
            this.tbEdadMin.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Edad Max:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Edad Min:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Reportes Pokemon";
            // 
            // dgReportes
            // 
            this.dgReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportes.Location = new System.Drawing.Point(448, 52);
            this.dgReportes.Name = "dgReportes";
            this.dgReportes.RowHeadersWidth = 51;
            this.dgReportes.RowTemplate.Height = 24;
            this.dgReportes.Size = new System.Drawing.Size(768, 498);
            this.dgReportes.TabIndex = 36;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(748, 576);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(193, 36);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "Kanto",
            "Johto",
            "Hoenn",
            "Sinnoh",
            "Teselia/Unova",
            "Kalos",
            "Alola",
            "Galar",
            "Paldea"});
            this.cbRegion.Location = new System.Drawing.Point(109, 162);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(223, 24);
            this.cbRegion.TabIndex = 10;
            // 
            // btnReporteVitalidad
            // 
            this.btnReporteVitalidad.Location = new System.Drawing.Point(259, 216);
            this.btnReporteVitalidad.Name = "btnReporteVitalidad";
            this.btnReporteVitalidad.Size = new System.Drawing.Size(155, 44);
            this.btnReporteVitalidad.TabIndex = 0;
            this.btnReporteVitalidad.Text = "Reporte de Vitalidad";
            this.btnReporteVitalidad.UseVisualStyleBackColor = true;
            this.btnReporteVitalidad.Click += new System.EventHandler(this.btnReporteVitalidad_Click);
            // 
            // btnCensoLegendario
            // 
            this.btnCensoLegendario.Location = new System.Drawing.Point(259, 281);
            this.btnCensoLegendario.Name = "btnCensoLegendario";
            this.btnCensoLegendario.Size = new System.Drawing.Size(155, 44);
            this.btnCensoLegendario.TabIndex = 38;
            this.btnCensoLegendario.Text = "Censo Legendario";
            this.btnCensoLegendario.UseVisualStyleBackColor = true;
            this.btnCensoLegendario.Click += new System.EventHandler(this.btnCensoLegendario_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 624);
            this.Controls.Add(this.btnCensoLegendario);
            this.Controls.Add(this.btnBuscarLegendarios);
            this.Controls.Add(this.btnReporteVitalidad);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgReportes);
            this.Controls.Add(this.btnBuscarRangoEdadEntrenadotes);
            this.Controls.Add(this.tbEdadMax);
            this.Controls.Add(this.tbEdadMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.btnBuscarPSMax);
            this.Controls.Add(this.btnBuscarMenorCantidadPok);
            this.Controls.Add(this.btnBuscarPorRegion);
            this.Controls.Add(this.btnBuscarNombrePokemon);
            this.Controls.Add(this.tbNombreEntrenador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBuscarPSMax;
        private System.Windows.Forms.Button btnBuscarMenorCantidadPok;
        private System.Windows.Forms.Button btnBuscarPorRegion;
        private System.Windows.Forms.Button btnBuscarNombrePokemon;
        private System.Windows.Forms.TextBox tbNombreEntrenador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnBuscarLegendarios;
        private System.Windows.Forms.Button btnBuscarRangoEdadEntrenadotes;
        private System.Windows.Forms.TextBox tbEdadMax;
        private System.Windows.Forms.TextBox tbEdadMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Button btnReporteVitalidad;
        private System.Windows.Forms.Button btnCensoLegendario;
    }
}