using LabParcialEmpleado.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabParcialEmpleado.controllers
{
    internal class ReporteController
    {
        public List<Empleado> ListarPorSueldo( double SueldoMin, double SueldoMax)
        {
            List<Empresa> lEmpresas = EmpresaController.ListarTodo();
            List<Empleado> empleados = lEmpresas.SelectMany(em => em.Empleados).ToList();

            return empleados.Where(e => e.Sueldo >= SueldoMin && e.Sueldo <= SueldoMax).ToList();

        }

    }
}
