using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para WindowEmpleado.xaml
    /// </summary>
    public partial class WindowEmpleado : Window
    {
        private NEmpleado nEmpleado = new NEmpleado();
        private Empleado empleadoSeleccionado = null;
        public WindowEmpleado()
        {
            InitializeComponent();
            MostrarEnDataGrid(nEmpleado.ListarTodo());
        }
        private void MostrarEnDataGrid (List<Empleado> lEmpleados)
        {
            dgEmpleados.ItemsSource = null;

            if (lEmpleados.Count > 0)
            {
                dgEmpleados.ItemsSource = lEmpleados;
            }
        }


        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if(tbDni.Text==""|| tbNombre.Text == "" || cbPuesto.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Empleado objEmpleado = new Empleado()
            {
                Dni = tbDni.Text,
                Nombre= tbNombre.Text,
                Puesto= cbPuesto.Text
            };

            string mensaje = nEmpleado.Registrar(objEmpleado);
            MessageBox.Show(mensaje);
            MostrarEnDataGrid(nEmpleado.ListarTodo());
        }

        private void btnVerReuniones_Click(object sender, RoutedEventArgs e)
        {
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado");
                return;
            }

            String dni = empleadoSeleccionado.Dni;

            WindowReunion window = new WindowReunion(dni);
            window.Show();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado");
                return;
            }

            String dni = empleadoSeleccionado.Dni;

            String mensaje =nEmpleado.Eliminar(dni);
            MessageBox.Show(mensaje);

            MostrarEnDataGrid(nEmpleado.ListarTodo());

        }

        private void btnOrdenarPorSueldo_Click(object sender, RoutedEventArgs e)
        {
            MostrarEnDataGrid(nEmpleado.OrdenarPorSueldo());
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            tbDni.Text = "";
            tbNombre.Text = "";
            cbPuesto.SelectedIndex = -1;
            MostrarEnDataGrid(nEmpleado.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgEmpleados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            empleadoSeleccionado = dgEmpleados.SelectedItem as Empleado;

            if (empleadoSeleccionado == null)
            {
                return;
            }

            tbDni.Text = empleadoSeleccionado.Dni;
            tbNombre.Text = empleadoSeleccionado.Nombre;
            cbPuesto.Text = empleadoSeleccionado.Puesto;
        }
    }
}
