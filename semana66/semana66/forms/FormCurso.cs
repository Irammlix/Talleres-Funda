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
    public partial class FormCurso : Form
    {
        String codigoProfesor;
        private CursoService cursoService = new CursoService();
        public FormCurso(string codigoProfesor)
        {
            InitializeComponent();
            this.codigoProfesor = codigoProfesor;
            lblcodigoProfesor.Text = codigoProfesor;
            MostrarEnDataGrid(cursoService.ListaPorProfesor(codigoProfesor));
        }
        private void MostrarEnDataGrid(List<Curso> listaCurso)
        {
            dgCursos.DataSource = null;
            if (listaCurso.Count > 0)
            {
                dgCursos.DataSource = listaCurso;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigoCurso.Text==""|| tbNombreCurso.Text==""||cbArea.Text==""||tbCreditos.Text=="")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Curso objCurso = new Curso()
            {
                Codigo = tbCodigoCurso.Text,
                Nombre = tbNombreCurso.Text,
                Area = cbArea.Text,
                Creditos = int.Parse(tbCreditos.Text)
            };

            bool registrado = cursoService.Registrar(codigoProfesor, objCurso);

            if (!registrado)
            {
                MessageBox.Show("No se pudo registrar el curso");
                return;
            }

            MostrarEnDataGrid(cursoService.ListaPorProfesor(codigoProfesor));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
