using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3.forms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            Form formMantenimiento = new FormElectrodomestico();
            formMantenimiento.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Form formReporte = new FormReporteElectrodomesticos();
            formReporte.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
