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
    public partial class FormProfesor : Form
    {
        private NProfesor nProfesor = new NProfesor();
        public FormProfesor()
        {
            InitializeComponent();
            MostrarEnDataGrid(nProfesor.ListarTodo());
        }

        private void MostrarEnDataGrid(List<Profesor> lProfesores)
        {
            dgProfesores.DataSource = null;

            if (lProfesores.Count > 0)
            {
                dgProfesores.DataSource = lProfesores;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombres.Text == "" || tbApellidos.Text == "" || 
                dtpFechaContrato.Text == "" || tbEspecializacion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
            }

            Profesor objProfesor = new Profesor()
            {
                Nombres = tbNombres.Text,
                Apellidos = tbApellidos.Text,
                FechaContrato = dtpFechaContrato.Value.Date,
                Especializacion = tbEspecializacion.Text
            };

            String mensaje = nProfesor.Registrar(objProfesor);
            MessageBox.Show(mensaje);
            MostrarEnDataGrid(nProfesor.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
