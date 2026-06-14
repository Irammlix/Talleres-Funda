using semana66.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semana66.forms
{
    public partial class FormReporte : Form
    {
        private ReporteService reporteService= new ReporteService();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarEnDataGrid(List<object> lista)
        {
            dgReportes.DataSource = null;
            if (lista.Count > 0)
            {
                dgReportes.DataSource = lista;
            }
        }
        private void btnCursosProfesoresPorEspecialidad_Click(object sender, EventArgs e)
        {
            if (cbEspecialidad.Text == "")
            {
                MessageBox.Show("Selecciona un especialidad");
                return;
            }

            String tipoEspecialidad = cbEspecialidad.Text;
            MostrarEnDataGrid(reporteService.ListarCursosProfesoresPorEspecialidad(tipoEspecialidad));
        }

        private void btnListarProfesoresCursosMayorCantidadCreditos_Click(object sender, EventArgs e)
        {
            MostrarEnDataGrid(reporteService.ListarProfesoresCursosMayorCantidadCredito());
        }

        private void btnProfesoresConMenosCantidadCursos_Click(object sender, EventArgs e)
        {
            MostrarEnDataGrid(reporteService.ListarProfesoresMenosCursos());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListarCursosPorAreaYMasde5Creditos_Click(object sender, EventArgs e)
        {
            if(cbAreaCurso.Text == "")
            {
                MessageBox.Show("Selecciona un area");
                return;
            }
            String areaCurso = cbAreaCurso.Text;
            MostrarEnDataGrid(reporteService.ListarCursosPorAreaYMasde5Creditos(areaCurso));
        }

        private void btnListarProfesorconPromedioCreditosPorEspecialidad_Click(object sender, EventArgs e)
        {
            if (cbEspecialidad.Text == "")
            {
                MessageBox.Show("Selecciona un especialidad");
                return;
            }

            String tipoEspecialidad = cbEspecialidad.Text;
            MostrarEnDataGrid(reporteService.ListarProfesorconPromedioCreditosPorEspecialidad(tipoEspecialidad));
        }


    }
}
