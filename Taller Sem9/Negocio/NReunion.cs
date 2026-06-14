using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NReunion
    {
        private DReunion dReunion = new DReunion();

        public List<Reunion> ListarPorEmpleado(string dni)
        {
            return dReunion.ListaPorEmpleado(dni);
        }

        public String Registrar( string dni, Reunion objReunion)
        {
            if(dReunion.Existe(dni, objReunion.Fecha, objReunion.Turno))
            {
                return "El empleado ya tiene una reunion en esa fecha y turno";
            }
            else
            {
                dReunion.Registrar(dni, objReunion);
                return "Reunion registrada exitosamente";
            
            }
        }
    }
}
