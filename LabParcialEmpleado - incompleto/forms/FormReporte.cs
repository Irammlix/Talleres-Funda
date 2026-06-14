using LabParcialEmpleado.controllers;
using LabParcialEmpleado.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabParcialEmpleado.forms
{
    public partial class FormReporte : Form
    {
        private ReporteController reporteController = new ReporteController();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarEnDatagrid(List<Empleado> empleados)
        {
            dgEmpleados.DataSource = null;
            if (empleados.Count > 0)
            {
                dgEmpleados.DataSource = empleados;
            }
        }

        private void btnListarPorRangoSueldos_Click_1(object sender, EventArgs e)
        {
            if(tbSueldoMax.Text=="" || tbSueldoMin.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            double sueldoMin = double.Parse(tbSueldoMin.Text);
            double sueldoMax = double.Parse(tbSueldoMax.Text);
            MostrarEnDatagrid(reporteController.ListarPorSueldo(sueldoMin, sueldoMax));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
