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
        private NAlumno nAlumno = new NAlumno();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarEnDataGrid(List<Alumno> lAlumnos)
        {
            dgAlumnos.DataSource = null;
            if (lAlumnos.Count > 0)
            {
                dgAlumnos.DataSource = lAlumnos;
            }
        }
        private void btnBuscarPorNombre_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese el Nombre");
                return;
            }
            String nombre = tbNombre.Text;
            MostrarEnDataGrid(nAlumno.BuscarPorNombre(nombre));
        }

        private void btnOrdenarPorPromFPC2_Click(object sender, EventArgs e)
        {
            MostrarEnDataGrid(nAlumno.OrdenarPromedioFinalPC2());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
