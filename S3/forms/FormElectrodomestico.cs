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

namespace S3
{
    public partial class FormElectrodomestico : Form
    {
        private ElectrodomesticoController electrodomesticoController = new ElectrodomesticoController();
        public FormElectrodomestico()
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validacion de campos
            if(tbCodigo.Text=="" || tbNombre.Text=="" || tbPrecio.Text == "" || tbStock.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creacion del objeto
            Electrodomestico elec = new Electrodomestico()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Stock = int.Parse(tbStock.Text),
                Precio = double.Parse(tbPrecio.Text)
            };
            bool registrado = electrodomesticoController.Registrar(elec);

            if(!registrado)
            {
                MessageBox.Show("Ingrese otro codigo");
                return;
            }

            //Mostrar en el DataGrid
            MostrarEnDataDrig(ElectrodomesticoController.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Validacion de seleccion
            //Tienes 0 filas seleccionadas? Entonces
            if (dgElectrodomesticos.SelectedRows.Count==0)
            {
                MessageBox.Show("Selecciona una fila");
                return;
            }

            //Obtener el codigo de la fila a eliminar
            var fila = dgElectrodomesticos.SelectedRows[0];
            String codigo = fila.Cells["Codigo"].Value.ToString();

            //Eliminadmos con ayuda del controll
            electrodomesticoController.Eliminar(codigo);

            //Mostrar en el Datagrid
            MostrarEnDataDrig(ElectrodomesticoController.ListarTodo());

        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            electrodomesticoController.EliminarTodo();
            MostrarEnDataDrig(ElectrodomesticoController.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormElectrodomestico_Load(object sender, EventArgs e)
        {
            MostrarEnDataDrig(ElectrodomesticoController.ListarTodo());
        }
    }
}
