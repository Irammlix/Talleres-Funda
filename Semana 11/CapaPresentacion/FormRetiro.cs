using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormRetiro : Form
    {
        private NAFP nAFP = new NAFP();
        private NEmpleado nEmpleado = new NEmpleado();
        private NRetiro nRetiro = new NRetiro();
        public FormRetiro()
        {
            InitializeComponent();
            MostrarCBAFP(nAFP.ListarTodo());
            MostrarCBEmpleados(nEmpleado.ListarTodo());
            MostrarEnDataGrid(nRetiro.ListarTodo());
        }

        private void MostrarEnDataGrid(List<Retiro> lRetiro)
        {
            dgRetiros.DataSource = null;
            if (lRetiro.Count > 0)
            {
                dgRetiros.DataSource = lRetiro;
                dgRetiros.Columns["Eliminado"].Visible = false;
                //Objetos virtuales que se crean en la clase principal
                dgRetiros.Columns["AFP"].Visible = false;
                dgRetiros.Columns["Empleado"].Visible = false;
            }
        }
        private void MostrarCBAFP(List<AFP> lAFP)
        {
            cbAFP.DataSource = null;
            if (lAFP.Count > 0)
            {
                cbAFP.DataSource = lAFP;
                //Valor que toma la lista / Valor que yo veo en la lista
                //Debemos tener un Id y un elemento visible

                cbAFP.ValueMember = "AFPId"; //Corresponde al Id, el verdadero valor ya que aqui esta el Id
                cbAFP.DisplayMember = "Nombre"; //Lo que se ve
                // Los nombres deben estar tal cual a los atributos de las clases
            }
        }

        private void MostrarCBEmpleados(List<Empleado> lEmpleados)
        {
            cbEmpleado.DataSource = null;
            if (lEmpleados.Count > 0)
            {
                cbEmpleado.DataSource = lEmpleados;
                cbEmpleado.ValueMember = "EmpleadoId";
                cbEmpleado.DisplayMember = "Nombre";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbAFP.Text == "" || cbEmpleado.Text == "" || tbCuenta.Text == "" || tbMonto.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos.");
                return;
            }

            int empleadoId = int.Parse(cbEmpleado.SelectedValue.ToString());
            int AFPId = int.Parse(cbAFP.SelectedValue.ToString());

            Retiro objRetiro = new Retiro()
            {
                EmpleadoId = empleadoId,
                AFPId=AFPId,
                Monto=decimal.Parse(tbMonto.Text),
                CuentaInterbancaria=tbCuenta.Text
            };

            String mensaje = nRetiro.Registrar(objRetiro);
            MessageBox.Show(mensaje);
            MostrarEnDataGrid(nRetiro.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgRetiros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila");
                return;
            }

            var fila = dgRetiros.SelectedRows[0];
            int retiroId = int.Parse(fila.Cells["RetiroId"].Value.ToString());

            String mensaje = nRetiro.Eliminar(retiroId);

            MessageBox.Show(mensaje);

            MostrarEnDataGrid(nRetiro.ListarTodo());
        }

        private void btnVerReportes_Click(object sender, EventArgs e)
        {
            FormReporte frm = new FormReporte();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgRetiros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgRetiros.SelectedRows.Count > 0)
            {
                var fila = dgRetiros.SelectedRows[0];

                cbAFP.SelectedValue = fila.Cells["AFPId"].Value;
                cbEmpleado.SelectedValue = fila.Cells["EmpleadoId"].Value;

                tbCuenta.Text = fila.Cells["CuentaInterbancaria"].Value.ToString();
                tbMonto.Text=fila.Cells["Monto"].Value.ToString();
            }
        }

        private void btnEditarRetiro_Click(object sender, EventArgs e)
        {
            if (dgRetiros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila.");
                return;
            }
            var fila = dgRetiros.SelectedRows[0];

            int idRetiro = int.Parse(fila.Cells["RetiroId"].Value.ToString());

            Retiro objRetiro = new Retiro()
            {
                RetiroId = idRetiro,
                EmpleadoId = int.Parse(cbEmpleado.SelectedValue.ToString()),
                AFPId = int.Parse(cbAFP.SelectedValue.ToString()),
                CuentaInterbancaria= tbCuenta.Text,
                Monto= decimal.Parse(tbMonto.Text)
            };

            String mensaje = nRetiro.EditarRetiro(objRetiro);
            MessageBox.Show(mensaje);
            MostrarEnDataGrid(nRetiro.ListarTodo());
        }
    }
}
