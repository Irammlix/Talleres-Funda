using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DEmpleado
    {
        // Inicializo la lista estática con datos de prueba para los reportes
        private static List<Empleado> empleados = new List<Empleado>
        {
            new Empleado {
                Dni = "12345678",
                Nombre = "Ana Lopez",
                Puesto = "Asistente",
                Sueldo = 3000.0,
                Reuniones = new List<Reunion>
                {
                    new Reunion { Fecha = new DateTime(2026, 1, 10), Turno = "9am-10am", Asunto = "Planificacion" },
                    new Reunion { Fecha = new DateTime(2026, 1, 12), Turno = "10am-11am", Asunto = "Revision" }
                }
            },
            new Empleado {
                Dni = "87654321",
                Nombre = "Carlos Perez",
                Puesto = "Auxiliar",
                Sueldo = 2500.0,
                Reuniones = new List<Reunion>
                {
                    new Reunion { Fecha = new DateTime(2026, 1, 11), Turno = "3pm-4pm", Asunto = "Seguimiento" }
                }
            },
            new Empleado {
                Dni = "11223344",
                Nombre = "Maria Gomez",
                Puesto = "Administrador",
                Sueldo = 5000.0,
                Reuniones = new List<Reunion>() // sin reuniones por ahora
            }
        };

        public static List<Empleado> ListarTodo()
        {
            return empleados;
        }

        public bool Existe ( String dni)
        {
            return empleados.Exists(e => e.Dni.Equals(dni));
        }

        public void Registrar(Empleado objEmpleado)
        {
            empleados.Add(objEmpleado);
        }

        public void Eliminar(String dni)
        {
            empleados.RemoveAll(e => e.Dni.Equals(dni));
        }

        public List<Empleado> OrdenarPorSueldo()
        {
            return empleados.OrderBy(e => e.Sueldo).ToList();
        }
    }
}
