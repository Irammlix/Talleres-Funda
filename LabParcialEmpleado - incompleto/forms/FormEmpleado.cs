using LabParcialEmpleado.controllers;
using LabParcialEmpleado.entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabParcialEmpleado.forms
{
    public partial class FormEmpleado : Form
    {
        private EmpleadoController empleadoController = new EmpleadoController();
        private String Codigo;

        public FormEmpleado(String Codigo)
        {
            InitializeComponent();
            this.Codigo = Codigo;
            lblCodigoEmpresa.Text = Codigo;
        }

        private void MostrarEnDatagrid(List<Empleado> empleados)
        {
            dgEmpleados.DataSource = null;
            if (empleados.Count >0)
            {
                dgEmpleados.DataSource = empleados;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombreCompleto.Text==""||tbRUC.Text==""||tbSueldo.Text=="")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }


            double sueldo = 0;

            try
            {
                sueldo = double.Parse(tbSueldo.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingrese un sueldo válido", ex.Message);
                return;
            }


            Empleado objEmpleado = new Empleado()
            {
                NombreCompleto = tbNombreCompleto.Text,
                RUC = tbRUC.Text,
                Sueldo = sueldo
            };

            bool registrar = empleadoController.Registrar(Codigo, objEmpleado);
            if (!registrar)
            {
                MessageBox.Show("El empleado ya existe");
                return;
            }

            MostrarEnDatagrid(empleadoController.ListarPorCodigoEmpresa(Codigo));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            var fila = dgEmpleados.SelectedRows[0];
            String RUCEmpleado = fila.Cells["RUC"].Value.ToString();

            empleadoController.Eliminar(Codigo, RUCEmpleado);

            MostrarEnDatagrid(empleadoController.ListarPorCodigoEmpresa(Codigo));

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbNombreCompleto.Text == "" || tbRUC.Text == "" || tbSueldo.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            Empleado objEmpleado = new Empleado()
            {
                NombreCompleto = tbNombreCompleto.Text,
                RUC = tbRUC.Text,
                Sueldo = double.Parse(tbSueldo.Text)
            };

            empleadoController.Modificar(Codigo, objEmpleado);
            MostrarEnDatagrid(empleadoController.ListarPorCodigoEmpresa(Codigo));

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgEmpleados.SelectedRows.Count > 0)
            {
                var fila = dgEmpleados.SelectedRows[0];
                tbRUC.Text = fila.Cells["RUC"].Value.ToString();
                tbNombreCompleto.Text = fila.Cells["NombreCompleto"].Value.ToString();
                tbSueldo.Text = fila.Cells["Sueldo"].Value.ToString();
            }
        }
    }
}
