using Semana_5.controllers;
using Semana_5.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_5
{
    public partial class FormPokemon : Form
    {
        private PokemonController pokemonController = new PokemonController();
        private String codigoEntrenador;
        public FormPokemon(String codigoEntrenador)
        {
            InitializeComponent();
            this.codigoEntrenador = codigoEntrenador;
            MostrarDatagrid(pokemonController.ListarTodo(codigoEntrenador));
        }

        private void MostrarDatagrid<T>(List <T> lista)
        {
            dgPokemones.DataSource = null;
            if (lista.Count != 0)
            {
                dgPokemones.DataSource = lista;
            }
        }
        private void btnRegistrarPokemon_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbApodo.Text == "" || cbTipo.Text == "" || tbPS.Text == "" || cbkEsLegendario.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos.");
                return;
            }

            Pokemon nPokemon = new Pokemon()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Apodo = tbApodo.Text,
                Tipo = cbTipo.Text,
                PuntosSalud = int.Parse(tbPS.Text),
                Legendario = cbkEsLegendario.Checked
            };

            bool registrado = pokemonController.Registrar(codigoEntrenador, nPokemon);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro codigo.");
                return;
            }
            MostrarDatagrid(pokemonController.ListarTodo(codigoEntrenador));
            LimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            tbCodigo.Clear();
            tbApodo.Clear();
            tbNombre.Clear();
            tbPS.Clear();
            tbApodo.Clear();
            cbkEsLegendario.Checked = false;
            cbTipo.SelectedIndex = 0;
        }

        private void btnEliminarPokemon_Click(object sender, EventArgs e)
        {

            if (dgPokemones.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un pokemon de la tabla");
                return;
            }

            string codPokemon = dgPokemones.CurrentRow.Cells["Codigo"].Value.ToString();
            pokemonController.EliminarPokemon(codigoEntrenador, codPokemon);
            MostrarDatagrid(pokemonController.ListarTodo(codigoEntrenador));
            MessageBox.Show("Pokemon eliminado correctamente");
        }
    }
}
