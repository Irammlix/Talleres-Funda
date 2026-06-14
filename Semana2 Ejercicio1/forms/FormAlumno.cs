using Semana2_Ejercicio1.controllers;
using Semana2_Ejercicio1.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana2_Ejercicio1
{
    public partial class FormAlumno : Form
    {
        private AlumnoController alumnoController=new AlumnoController();  
        public FormAlumno()
        {
            InitializeComponent();
        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {

        }

        private void MostrarArreglo(Alumno[] alumnos)
        {
            dgAlumnos.DataSource = null;
            dgAlumnos.DataSource = alumnos;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar los campos
            if (txtCodigo.Text == ""||txtNombre.Text=="" ||txtPromedio.Text=="")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            //Creacion del objeto
            Alumno alumno = new Alumno()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Promedio= double.Parse(txtPromedio.Text),
                Seccion=txtSeccion.Text

            };

            //Registrar
            alumnoController.Registrar(alumno); 

            //Mostrar alumnos en datagrid
            MostrarArreglo(alumnoController.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validacion de selccion, si no tiene ni un arows entonces

            if (dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
           String codigo = dgAlumnos.SelectedRows[0].Cells["Codigo"].Value.ToString();

            //alumnoController.EliminarAlternativo(codigo);

            alumnoController.Eliminar(codigo);

            //TO DO
            //Mostrar alumnos en datagrid
            MostrarArreglo(alumnoController.ListarTodo());

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigoBuscar.Text == "")
            {
                MessageBox.Show("Ingrese el campo");
                return;
            }
            String codigo = txtCodigoBuscar.Text;

            MostrarArreglo(alumnoController.BuscarPorCodigo(codigo));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarSeccion_Click(object sender, EventArgs e)
        {
            if (txtSeccionBuscar.Text == "")
            {
                MessageBox.Show("Ingrese el campo");
                return;
            }
            String seccion = txtSeccionBuscar.Text;
            //Llamamos

            MostrarArreglo(alumnoController.BuscarPorSeccion(seccion));
        }

    }
}
