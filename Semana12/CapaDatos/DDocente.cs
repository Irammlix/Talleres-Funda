using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DDocente
    {
        public List<Docente> ListarTodo()
        {
            List<Docente> docentes = new List<Docente>();

            try
            {
                using(var context = new db_institutoEntities())
                {
                    docentes = context.Docente.ToList();
                }
                return docentes;
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
                return docentes;
            }
        }
    }
}
