namespace Lab01
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnAbrirForm1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirForm1
            // 
            this.btnAbrirForm1.Location = new System.Drawing.Point(109, 117);
            this.btnAbrirForm1.Name = "btnAbrirForm1";
            this.btnAbrirForm1.Size = new System.Drawing.Size(176, 50);
            this.btnAbrirForm1.TabIndex = 0;
            this.btnAbrirForm1.Text = "Abrir Form 1";
            this.btnAbrirForm1.UseVisualStyleBackColor = true;
            this.btnAbrirForm1.Click += new System.EventHandler(this.btnAbrirForm1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarForm2
            // 
            this.btnCerrarForm2.BackColor = System.Drawing.Color.Pink;
            this.btnCerrarForm2.Location = new System.Drawing.Point(109, 260);
            this.btnCerrarForm2.Name = "btnCerrarForm2";
            this.btnCerrarForm2.Size = new System.Drawing.Size(176, 50);
            this.btnCerrarForm2.TabIndex = 2;
            this.btnCerrarForm2.Text = "Cerrar Formulario";
            this.btnCerrarForm2.UseVisualStyleBackColor = false;
            this.btnCerrarForm2.Click += new System.EventHandler(this.btnCerrarF2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarForm2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAbrirForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarForm2;
    }
}