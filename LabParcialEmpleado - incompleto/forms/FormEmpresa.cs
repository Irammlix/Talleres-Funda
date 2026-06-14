using LabParcialEmpleado.controllers;
using LabParcialEmpleado.entities;
using LabParcialEmpleado.forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabParcialEmpleado
{
    public partial class FormEmpresa : Form
    {
        private EmpresaController empresaController = new EmpresaController();

        public FormEmpresa()
        {
            InitializeComponent();
        }

        private void MostrarEnDatagrid(List<Empresa> empresas)
        {
            dgEmpresas.DataSource = null;
            if (empresas.Count > 0)
            {
                dgEmpresas.DataSource = empresas;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "" || tbNombre.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            Empresa objEmpresa = new Empresa()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text
            };
            bool registrado = empresaController.Registrar(objEmpresa);

            if (!registrado)
            {
                MessageBox.Show("La empresa ya esta registrada");
                return;
            }

            MostrarEnDatagrid(EmpresaController.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgEmpresas.SelectedRows.Count == 0)
            {
                return;
            }
            var fila = dgEmpresas.SelectedRows[0];

            String codigo = fila.Cells["Codigo"].Value.ToString();

            empresaController.Eliminar(codigo);
            MostrarEnDatagrid(EmpresaController.ListarTodo());

        }

        private void btnVerEmpleados_Click(object sender, EventArgs e)
        {
            if (dgEmpresas.SelectedRows.Count == 0)
            {
                return;
            }
            var fila = dgEmpresas.SelectedRows[0];

            String codigo = fila.Cells["Codigo"].Value.ToString();

            FormEmpleado frm = new FormEmpleado(codigo);
            frm.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgEmpresas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgEmpresas.SelectedRows.Count > 0)
            {
                var fila = dgEmpresas.SelectedRows[0];
                tbCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                tbNombre.Text = fila.Cells["Nombre"].Value.ToString();
            }
        }

        private void btnVerReportes_Click(object sender, EventArgs e)
        {
            FormReporte frm = new FormReporte();
            frm.ShowDialog();
        }
    }
}
