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
    public partial class FormDocentexCurso : Form
    {
        private NDocentexCurso nDxC = new NDocentexCurso();
        private NCurso nCurso = new NCurso();
        private NDocente nDocente = new NDocente();
        public FormDocentexCurso()
        {
            InitializeComponent();
            MostrarComboBoxDocente(nDocente.ListarTodo());
            MostrarComboBoxCursos(nCurso.ListarTodo());
            MostrarEnDataGrid(nDxC.ListarTodo());
        }

        private void MostrarComboBoxDocente (List<Docente> lista)
        {
            cbDocente.DataSource = null;
            if (lista.Count > 0)
            {
                cbDocente.DataSource = lista;
                cbDocente.ValueMember = "DocenteId";
                cbDocente.DisplayMember = "NombreCompleto";
            }
        }
        private void MostrarComboBoxCursos(List<Curso> lista)
        {
            cbCurso.DataSource = null;
            if (lista.Count > 0)
            {
                cbCurso.DataSource = lista;
                cbCurso.ValueMember = "CursoId";
                cbCurso.DisplayMember = "NombreCurso";
            }
        }

        private void MostrarEnDataGrid(List<DocentexCurso> lista)
        {
            dgDocentesyCursos.DataSource = null;
            if (lista.Count > 0)
            {
                dgDocentesyCursos.DataSource = lista;
                dgDocentesyCursos.Columns["Eliminado"].Visible = false;
                dgDocentesyCursos.Columns["Curso"].Visible = false;
                dgDocentesyCursos.Columns["Docente"].Visible = false;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(cbCurso.Text=="" || cbDocente.Text==""|| cbSemestre.Text=="")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            int cursoId = int.Parse(cbCurso.SelectedValue.ToString());
            int docenteId = int.Parse(cbDocente.SelectedValue.ToString());
            string semestre = cbSemestre.Text;

            DocentexCurso dc = new DocentexCurso()
            {
                CursoId = cursoId,
                DocenteId = docenteId,
                Semestre = semestre
            };

            String mensaje = nDxC.Registrar(dc);
            MessageBox.Show(mensaje);

            MostrarEnDataGrid(nDxC.ListarTodo());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbCurso.SelectedIndex = -1;
            cbDocente.SelectedIndex = -1;
            cbSemestre.SelectedIndex = -1;

            MostrarEnDataGrid(nDxC.ListarTodo());
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            if (dgDocentesyCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una Fila");
                return;
            }

            var fila = dgDocentesyCursos.SelectedRows[0];


            int docenteId = int.Parse(fila.Cells["DocenteId"].Value.ToString());
            int cursoId = int.Parse(fila.Cells["CursoId"].Value.ToString());
            string semestre = cbSemestre.Text;

            DocentexCurso dc = new DocentexCurso()
            {
                DocenteId = docenteId,
                CursoId = cursoId,
                Semestre = semestre
            };

            String mensaje = nDxC.Inactivar(dc);
            MessageBox.Show(mensaje);

            MostrarEnDataGrid(nDxC.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgDocentesyCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una Fila");
                return;
            }

            var fila = dgDocentesyCursos.SelectedRows[0];


            int docenteId = int.Parse(fila.Cells["DocenteId"].Value.ToString());
            int cursoId = int.Parse(fila.Cells["CursoId"].Value.ToString());
            string semestre = cbSemestre.Text;

            DocentexCurso dc = new DocentexCurso()
            {
                DocenteId = docenteId,
                CursoId = cursoId,
                Semestre = semestre
            };

            String mensaje = nDxC.Eliminar(dc);
            MessageBox.Show(mensaje);

            MostrarEnDataGrid(nDxC.ListarTodo());
        }

        private void btnBuscarPorCurso_Click(object sender, EventArgs e)
        {
            if (cbCurso.Text == "")
            {
                MessageBox.Show("Seleccione un Curso");
                return;
            }
            int cursoId = int.Parse(cbCurso.SelectedValue.ToString());
            MostrarEnDataGrid(nDxC.ListarTodoPorCursoId(cursoId));
        }

        private void btnBuscarPorDocente_Click(object sender, EventArgs e)
        {
            if (cbDocente.Text == "")
            {
                MessageBox.Show("Seleccione un Docente");
                return;
            }
            int docenteId = int.Parse(cbDocente.SelectedValue.ToString());
            MostrarEnDataGrid(nDxC.ListarTodoPorDocenteId(docenteId));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgDocentesyCursos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgDocentesyCursos.SelectedRows.Count > 0)
            {
                var fila = dgDocentesyCursos.SelectedRows[0];
                cbCurso.SelectedValue = fila.Cells["CursoId"].Value;
                cbDocente.SelectedValue = fila.Cells["DocenteId"].Value;
                cbSemestre.Text = fila.Cells["Semestre"].Value.ToString();
            }
        }
    }
}
