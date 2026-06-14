 using Semana_4.cotrollers;
using Semana_4.entities;
using Semana_4.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_4
{
    public partial class FormCoordinador : Form
    {
        private CoordinadorController coordinadorController = new CoordinadorController();
        public FormCoordinador()
        {
            InitializeComponent();
            MostrarEnDataGrid(CoordinadorController.ListarTodo());
        }

        private void FormCoordinador_Load(object sender, EventArgs e)
        {

        }

        private void MostrarEnDataGrid(List<Coordinador> lista)
        {
            //limpiamos la lista
            dgCoordinadores.DataSource = null;

            //valir si hay elementos a mostrar
            if (lista.Count > 0)
            {
                dgCoordinadores.DataSource = lista;
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validacion de campos
            if(tbCodigoCoordinador.Text==""||cbCentroDistribucion.Text=="" || cbTurno.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            //Creacion de objetos
            Coordinador coordinador = new Coordinador()
            {
                Codigo = tbCodigoCoordinador.Text,
                CentroDistribucion = cbCentroDistribucion.Text,
                Turno = cbTurno.Text
            };

            //Registramos
            bool registrado = coordinadorController.Registrar(coordinador);
            if (!registrado)
            {
                MessageBox.Show("Codigo Repetido");
                return;
            }

            //Mostrar en DataGrid
            MostrarEnDataGrid(CoordinadorController.ListarTodo());
          
        }

        private void btnVerRepartidores_Click(object sender, EventArgs e)
        {
            //Si no tienes nada seleccionado... (teda un error)
            if (dgCoordinadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un coordinador");
                return;
            }

            var fila = dgCoordinadores.SelectedRows[0];
            String codigoCoordinador = fila.Cells["Codigo"].Value.ToString();

            //Mandar el codigo al otro forumlario mediante su contructor

            FormRepartidor formRepartidor = new FormRepartidor(codigoCoordinador);
            formRepartidor.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarPorCentro_Click(object sender, EventArgs e)
        {
            if (cbCentroDistribucion.Text == "")
            {
                MessageBox.Show("Selcionne un centro de distribucion");
                return;
            }

            String centroDistribucion = cbCentroDistribucion.Text;

            // Mostrar en DataGrid
            MostrarEnDataGrid(coordinadorController.BuscarPorCentro(centroDistribucion));
        }

        private void dgCoordinadores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCoordinadores.SelectedRows.Count > 0)
            {
                //Tomar la primera fila selccionada
                var fila = dgCoordinadores.SelectedRows[0];
                tbCodigoCoordinador.Text = fila.Cells["Codigo"].Value.ToString();
                cbCentroDistribucion.Text = fila.Cells["CentroDistribucion"].Value.ToString();
                cbTurno.Text = fila.Cells["Turno"].Value.ToString();
            }
        }

        private bool ModificarCoordinador(Coordinador coordinador)
        {
            Coordinador coordinadorEncontrado = CoordinadorController.ListarTodo().Find(c=>c.Codigo.Equals(coordinador.Codigo));

            if (coordinadorEncontrado == null)
            {
                MessageBox.Show("No se encontro el coordinador con ese codigo");
                return false;
            }

            coordinadorEncontrado.CentroDistribucion = coordinador.CentroDistribucion;
            coordinadorEncontrado.Turno = coordinador.Turno;

            return true;
        }

        private void btnModificarCoordinador_Click(object sender, EventArgs e)
        {
            if (tbCodigoCoordinador.Text == "" || cbCentroDistribucion.Text == "" || cbTurno.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Coordinador coordinador = new Coordinador()
            {
                Codigo = tbCodigoCoordinador.Text,
                CentroDistribucion = cbCentroDistribucion.Text,
                Turno = cbTurno.Text,
            };

            if (ModificarCoordinador(coordinador))
            {
                MostrarEnDataGrid(CoordinadorController.ListarTodo());
                MessageBox.Show(" Coordinador actualizado coorectamente");
            }
        }
    }
}
