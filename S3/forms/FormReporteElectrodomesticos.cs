using S3.controllers;
using S3.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3.forms
{
    public partial class FormReporteElectrodomesticos : Form
    {
        private ElectrodomesticoController electrodomesticoController = new ElectrodomesticoController();

        public FormReporteElectrodomesticos()
        {
            InitializeComponent();
        }
        private void MostrarEnDataDrig(List<Electrodomestico> electrodomesticos)
        {
            //limpiar datagrid (parte visual)
            dgElectrodomesticos.DataSource = null;
            if (electrodomesticos.Count() != 0)
            {
                dgElectrodomesticos.DataSource = electrodomesticos;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validacion de campos
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre a buscar");
                return;
            }

            //Mostrar la busqueda en el datagrid
            String nombre = tbNombre.Text;
            //Mostrar la busqueda en el dtagrid
            MostrarEnDataDrig(electrodomesticoController.BuscarPorNombre(nombre));
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MostrarEnDataDrig(electrodomesticoController.OrdenarPorPrecio());
        }

        private void btnVerCantidad_Click(object sender, EventArgs e)
        {
            lblCantidadTotal.Text = electrodomesticoController.CantidadTotal().ToString();
            MostrarEnDataDrig(ElectrodomesticoController.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
