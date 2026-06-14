using Semana_5.controllers;
using Semana_5.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_5
{
    public partial class FormEntrenador : Form
    {
        private EntrenadorController entrenadorController = new EntrenadorController();
        public FormEntrenador()
        {
            InitializeComponent();
            MostrarDatagrid(EntrenadorController.ListarTodo());
        }

        //Se pone una <T> cuando no asbemos q lista vendra, pero vendra un alista
        private void MostrarDatagrid<T>( List<T> lista)
        {
            dgEntrenador.DataSource = null;
            if (lista.Count != 0)
            {
                dgEntrenador.DataSource = lista;
            }
        }
        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {
            if(tbCodigo.Text=="" || tbNombre.Text==""|| tbEdad.Text == "" || cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos");
                return;
            }

            Entrenador entrenadorN = new Entrenador()
            {
                Codigo=tbCodigo.Text,
                Nombre=tbNombre.Text,
                Edad=int.Parse(tbEdad.Text),
                Region=cbRegion.Text
            };

            bool registrado = entrenadorController.Registrar(entrenadorN);

            if (!registrado)
            {
                MessageBox.Show("Ingrese otro codigo");
                return;
            }


            MostrarDatagrid(EntrenadorController.ListarTodo());
            LimpiarCampos();

        }

        private void btnVerPokemon_Click(object sender, EventArgs e)
        {
            if (dgEntrenador.CurrentRow == null)
            {
                MessageBox.Show("Selelcione un entrenador");
                return;
            }

            String codigoEntrenador = dgEntrenador.CurrentRow.Cells["Codigo"].Value.ToString();
            FormPokemon form = new FormPokemon(codigoEntrenador);
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte form =new FormReporte();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            tbCodigo.Clear();
            tbNombre.Clear();
            tbEdad.Clear();
            cbRegion.SelectedIndex = 0;
        }
    }
}
