using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEmpleado
    {
        private DEmpleado dEmpleado = new DEmpleado();

        public List<Empleado> ListarTodo()
        {
            return DEmpleado.ListarTodo();
        }

        public String Registrar(Empleado empleado)
        {
            if (dEmpleado.Existe(empleado.Dni))
            {
                return "Dni duplicado, ingrese otro";
            }
            else
            {
                switch (empleado.Puesto)
                {
                    case "Auxiliar":
                        empleado.Sueldo = 2000;
                        break;

                    case "Administrador":
                        empleado.Sueldo = 5000;
                        break;

                    case "Asistente":
                        empleado.Sueldo = 3000;
                        break;

                    default:
                        empleado.Sueldo = 2000;
                        break;
                }
                dEmpleado.Registrar(empleado);
                return "El empleado ha sido registrado";
            }
        }

        public String Eliminar (String dni)
        {
            dEmpleado.Eliminar(dni);
            return "Empleado eliminado exitosamente";
        }

        public List<Empleado> OrdenarPorSueldo()
        {
            return dEmpleado.OrdenarPorSueldo();
        }
    }
}
