namespace Lab01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnVerMensaje = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnCerrarForm1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerMensaje
            // 
            this.btnVerMensaje.Location = new System.Drawing.Point(191, 342);
            this.btnVerMensaje.Name = "btnVerMensaje";
            this.btnVerMensaje.Size = new System.Drawing.Size(158, 55);
            this.btnVerMensaje.TabIndex = 0;
            this.btnVerMensaje.Text = "Ver Mensaje";
            this.btnVerMensaje.UseVisualStyleBackColor = true;
            this.btnVerMensaje.Click += new System.EventHandler(this.btnVerMensaje_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(302, 35);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(194, 36);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "¡Bienvenido!";
            this.lblBienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCerrarForm1
            // 
            this.btnCerrarForm1.BackColor = System.Drawing.Color.Yellow;
            this.btnCerrarForm1.Location = new System.Drawing.Point(440, 342);
            this.btnCerrarForm1.Name = "btnCerrarForm1";
            this.btnCerrarForm1.Size = new System.Drawing.Size(188, 55);
            this.btnCerrarForm1.TabIndex = 2;
            this.btnCerrarForm1.Text = "Cerrar Formulario";
            this.btnCerrarForm1.UseVisualStyleBackColor = false;
            this.btnCerrarForm1.Click += new System.EventHandler(this.btnCerrarF1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(311, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrarForm1);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.btnVerMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerMensaje;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnCerrarForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

