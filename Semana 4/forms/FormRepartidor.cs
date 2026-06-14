using Semana_4.cotrollers;
using Semana_4.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_4.forms
{
    public partial class FormRepartidor : Form
    {
        private RepartidorController repartidorController = new RepartidorController();
        String codigoCoordinador = "-";
        public FormRepartidor(string codigoCoordinador)
        {
            InitializeComponent();
            //setear la variable codigo de coordinador de manera local
            this.codigoCoordinador = codigoCoordinador;
            lblCodigoCoordinador.Text = codigoCoordinador;
            //Muestra lo que hay en la lista de repartidaores al iniciar el formulario
            MostrarEnDataGrid(repartidorController.ListarPorCoordinador(codigoCoordinador));
        }

        private void MostrarEnDataGrid(List<Repartidor> lista)
        {
            dgRepartidores.DataSource = null;
            if (lista.Count > 0)
            {
                dgRepartidores.DataSource = lista;
            }
        }

        private bool ValidacionNumEntregas(String numEntregasValidacion)
        {
            try
            { 
                if (int.Parse(numEntregasValidacion) < 0)
                {
                    MessageBox.Show("El numero de entregas no puede ser negativo");
                        return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese un valor numerico valido");
                return false;
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(tbCodigoRepartidor.Text==""|| cbZona.Text=="" || tbNumEntregas.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            if (!ValidacionNumEntregas(tbNumEntregas.Text))
            {
                return;
            }

            Repartidor repartidor = new Repartidor()
            {
                Codigo = tbCodigoRepartidor.Text,
                Zona = cbZona.Text,
                NumEntregas = int.Parse(tbNumEntregas.Text)
            };

            bool registrado = repartidorController.Registrar(codigoCoordinador, repartidor);
            if (!registrado)
            {
                MessageBox.Show("Codigo Repetido");
                return;
            }

            //Mostrar en DataGrid
            MostrarEnDataGrid(repartidorController.ListarPorCoordinador(codigoCoordinador));

        }

        private void btnTop3PorEntregas_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ModificarRepartidor(Repartidor nRepartidor)
        {
            Coordinador nCoordinador = CoordinadorController.ListarTodo().Find(c => c.Codigo == codigoCoordinador);
            if (nCoordinador != null)
            {
                Repartidor eRepartidor = nCoordinador.Repartidores.Find(r => r.Codigo == nRepartidor.Codigo);
                if (eRepartidor != null)
                {
                    eRepartidor.Zona = nRepartidor.Zona;
                    eRepartidor.NumEntregas = nRepartidor.NumEntregas;
                    return true;
                }
            }
            return false;
        }
        private void btnModificarRepartidor_Click(object sender, EventArgs e)
        {
            if (tbCodigoRepartidor.Text == "" || cbZona.Text == "" || tbNumEntregas.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Repartidor nRepartidor = new Repartidor()
            {
                Codigo = tbCodigoRepartidor.Text,
                Zona = cbZona.Text,
                NumEntregas = int.Parse(tbNumEntregas.Text)
            };

            if (ModificarRepartidor(nRepartidor))
            {
                MostrarEnDataGrid(repartidorController.ListarPorCoordinador(codigoCoordinador));
            }
        }
    }
}
