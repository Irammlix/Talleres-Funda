using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DReunion
    {
        public List<Reunion> ListaPorEmpleado(String dni)
        {
            List<Empleado> empleados = DEmpleado.ListarTodo();
            Empleado objEmpleado = empleados.Find(e => e.Dni.Equals(dni));
            return objEmpleado.Reuniones;
        }

        public bool Existe(String dni, DateTime fecha, String Turno)
        {
            List<Empleado> empleados = DEmpleado.ListarTodo();
            Empleado objEmpleado = empleados.Find(e => e.Dni.Equals(dni));

            List<Reunion> reuniones = objEmpleado.Reuniones;

            return reuniones.Exists(r => r.Turno.Equals(Turno) && r.Fecha.Equals(fecha));
        }

        public void Registrar(String dni, Reunion reunion)
        {
            List<Empleado> empleados = DEmpleado.ListarTodo();
            Empleado objEmpleado = empleados.Find(e => e.Dni.Equals(dni));
            objEmpleado.Reuniones.Add(reunion);
        }
    }
}
