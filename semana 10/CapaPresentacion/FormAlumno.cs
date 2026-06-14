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
    public partial class FormAlumno : Form
    {
        private NAlumno nAlumno = new NAlumno();
        public FormAlumno()
        {
            InitializeComponent();
            MostrarEnDataGrid(nAlumno.ListarTodo());
        }

        private void MostrarEnDataGrid(List<Alumno> lAlumnos)
        {
            dgAlumnos.DataSource = null;
            if (lAlumnos.Count > 0)
            {
                dgAlumnos.DataSource = lAlumnos;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPC2.Text == "" || tbPromedioTA.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Alumno objAlumno = new Alumno()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                PromedioTA = decimal.Parse(tbPC2.Text),
                PC2 = decimal.Parse(tbPC2.Text)
            };

            String mensaje = nAlumno.Registrar(objAlumno);
            MessageBox.Show(mensaje);

            MostrarEnDataGrid(nAlumno.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte frm = new FormReporte();
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var fila = dgAlumnos.SelectedRows[0];
            int id = int.Parse(fila.Cells["Id"].Value.ToString());

            String mensaje= nAlumno.Eliminar(id);

            MessageBox.Show(mensaje);
            MostrarEnDataGrid(nAlumno.ListarTodo());
        }
    }
}
