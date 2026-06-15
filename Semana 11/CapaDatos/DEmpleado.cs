using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DEmpleado
    {
        public List<Empleado> ListarTodo()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                using ( var context = new db_labAFPEntities())
                {
                    empleados = context.Empleado.Where(e=>e.Eliminado==false).ToList();
                }
                return empleados;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return empleados;
            }
        }
    }
}
