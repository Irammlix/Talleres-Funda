using semana66.entities;
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
    public partial class FormProfesor : Form
    {
        private ProfesorService profesorService = new ProfesorService();
        public FormProfesor()
        {
            InitializeComponent();
            MostrarEnDataGrid(profesorService.ListarTodo());
        }

        private void MostrarEnDataGrid(List<Profesor> listaProfesor)
        {
            dgProfesores.DataSource = null;
            if (listaProfesor.Count > 0)
            {
                dgProfesores.DataSource = listaProfesor;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigoProfesor.Text == "" || tbNombreProfesor.Text == "" || cbEspecialidad.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Profesor objProfesor=new Profesor()
            {
                Codigo = tbCodigoProfesor.Text,
                Nombre = tbNombreProfesor.Text,
                Especialidad = cbEspecialidad.Text
            };

            bool registrado = profesorService.Registrar(objProfesor);

            if (!registrado)
            {
                MessageBox.Show("El codigo del profesor ya existe");
                return;
            }
            MostrarEnDataGrid(profesorService.ListarTodo());
        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {
            if (dgProfesores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una  fila");
                return;
            }

            var fila = dgProfesores.SelectedRows[0];

            string codigoProfesor = fila.Cells["Codigo"].Value.ToString();
            FormCurso formCurso=new FormCurso(codigoProfesor);
            formCurso.ShowDialog();
        }

        private void btnVerReportes_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
