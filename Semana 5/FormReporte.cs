using Semana_5.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_5
{
    public partial class FormReporte : Form
    {
        private ReporteController reporteController = new ReporteController();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarDataGrid<T>(List<T> lista)
        {
            dgReportes.DataSource = null;
            if (lista.Count != 0)
            {
                dgReportes.DataSource = lista;
            }
        }
        private void btnBuscarNombrePokemon_Click(object sender, EventArgs e)
        {
            if (tbNombreEntrenador.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            MostrarDataGrid(reporteController.ListarEntrenadorPorNombrePokemon(tbNombreEntrenador.Text));
        }

        private void btnBuscarPorRegion_Click(object sender, EventArgs e)
        {
            if (cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            MostrarDataGrid(reporteController.ListarEntrenadorPorRegion(cbRegion.Text));

        }

        private void btnBuscarMenorCantidadPok_Click(object sender, EventArgs e)
        {
            MostrarDataGrid(reporteController.ListarEntrenadoresPorMenorCantidadPokemon());
        }

        private void btnBuscarPSMax_Click(object sender, EventArgs e)
        {
            MostrarDataGrid(reporteController.ListarEntrenadoresPorMaxPuntosSaludPokemon());
        }

        private void btnBuscarRangoEdadEntrenadotes_Click(object sender, EventArgs e)
        {
            if (tbEdadMax.Text==""||tbEdadMin.Text=="")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            int edadMin = int.Parse(tbEdadMin.Text);
            int edadMax = int.Parse(tbEdadMax.Text);

            MostrarDataGrid(reporteController.ListarPokemonsPorEdadEntrenadores(edadMin,edadMax));

        }

        private void btnBuscarLegendarios_Click(object sender, EventArgs e)
        {
            MostrarDataGrid(reporteController.ListarPokemonsLegendarios());

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporteVitalidad_Click(object sender, EventArgs e)
        {
            MostrarDataGrid(reporteController.ReporteVitalidadEquipos());
        }

        private void btnCensoLegendario_Click(object sender, EventArgs e)
        {
            MostrarDataGrid(reporteController.ReporteCensoLegendario());
        }
    }
}
