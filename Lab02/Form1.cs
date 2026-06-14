using Lab02.controllers;
using Lab02.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        private EmpleadoController empleadoController = new EmpleadoController();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarNuevoEmpleado(Empleado empleado)
        {
            dgEmpleados.Rows.Add(empleado.Nombre, empleado.Categoria, empleado.MinTardanza,empleado.NumFaltas, empleado.Pago);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesarEmpleado_Click(object sender, EventArgs e)
        {
            //Validacion de campos
            if (tbNombre.Text == "" || cbCategoria.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            //Creacion del objeto
            Empleado empleado = new Empleado()
            {
                Nombre = tbNombre.Text,
                Categoria = cbCategoria.Text,
                MinTardanza = (int)numUDNumTardanzas.Value,
                NumFaltas = (int)numUDNumFaltas.Value
            };

            Empleado empleadoProcesado = empleadoController.ProcesarEmpleado(empleado);

            MostrarNuevoEmpleado(empleadoProcesado);
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
