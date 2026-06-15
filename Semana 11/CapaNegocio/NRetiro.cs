using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NRetiro
    {
        public DRetiro dRetiro = new DRetiro();

        public List<Retiro> ListarTodo()
        {
            return dRetiro.ListarTodo();
        }

        public String Registrar (Retiro retiro)
        {
            retiro.Eliminado = false;
            return dRetiro.Registrar(retiro);
        }

        public String Eliminar(int retiroId)
        {
            return dRetiro.EliminarLogico(retiroId);
        }

        public String EditarRetiro(Retiro objRetiro)
        {
            return dRetiro.EditarRetiro(objRetiro);
        }

        // REPORTES
        public  List<Retiro> ListarRetirosConAFPHabitat()
        {
            return dRetiro.ListarRetirosConAFPHabitat();
        }
        public List<Retiro> ListarretirosEmpleadosMas30Anios()
        {
            return dRetiro.ListarRetirosEmpleadosMasDe30Anios();
        }

        public decimal ObtenerMontoPromedio()
        {
            return dRetiro.ObtenerMontoPromedio();
        }
    }
}
