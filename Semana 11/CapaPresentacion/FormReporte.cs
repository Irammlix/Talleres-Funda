using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormReporte : Form
    {
        private NRetiro nRetiro = new NRetiro();
        public FormReporte()
        {
            InitializeComponent();
        }
        private void MostrarEnDataGrid(List<Retiro> lRetiro)
        {
            dgReportes.DataSource = null;
            if (lRetiro.Count > 0)
            {
                dgReportes.DataSource = lRetiro;
                dgReportes.Columns["Eliminado"].Visible = false;

                dgReportes.Columns["AFP"].Visible = false;
                dgReportes.Columns["Empleado"].Visible = false;
            }
        }
        private void btnRetirosGestionadosPorAFP_Click(object sender, EventArgs e)
        {
            MostrarEnDataGrid(nRetiro.ListarRetirosConAFPHabitat());
        }
        private void btnListarRetirosEmpleadosMasDe30Anios_Click(object sender, EventArgs e)
        {
            MostrarEnDataGrid(nRetiro.ListarretirosEmpleadosMas30Anios());
        }

        private void btnObtenerMontoPromedio_Click(object sender, EventArgs e)
        {
            decimal montoPromedio = nRetiro.ObtenerMontoPromedio();
            MessageBox.Show("El monto promedio de todos los retiros es :" + montoPromedio);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
