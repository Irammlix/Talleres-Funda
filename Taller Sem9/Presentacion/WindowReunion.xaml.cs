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
    /// Lógica de interacción para WindowReunion.xaml
    /// </summary>
    public partial class WindowReunion : Window
    {
        private string dni;
        private NReunion nReunion = new NReunion();
        public WindowReunion(string dni)
        {
            InitializeComponent();
            this.dni = dni;
            lblDni.Content = dni;
            MostrarEnDataGrid(nReunion.ListarPorEmpleado(dni));
        }

        private void MostrarEnDataGrid(List<Reunion> lReuniones)
        {
            dgReuniones.ItemsSource = null;
            if (lReuniones.Count > 0)
            {
                dgReuniones.ItemsSource = lReuniones;
            }
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (dtpFecha.Text == "" || cbTurno.Text == "" || tbAsunto.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Reunion objReunion = new Reunion()
            {
                Fecha = dtpFecha.SelectedDate.Value.Date,
                Turno= cbTurno.Text,
                Asunto=tbAsunto.Text
            };
            String mensaje = nReunion.Registrar(dni, objReunion);
            MessageBox.Show(mensaje);
            MostrarEnDataGrid(nReunion.ListarPorEmpleado(dni));
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
