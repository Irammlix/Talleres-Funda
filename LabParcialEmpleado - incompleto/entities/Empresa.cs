using System;
using System.Collections.Generic;

namespace LabParcialEmpleado.entities
{
    internal class Empresa
    {
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public List<Empleado> Empleados { get; set; }

        public Empresa()
        {
            Empleados = new List<Empleado>();
        }
    }
}
