using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCurso
    {

        public List<Curso> ListarTodo()
        {
            List<Curso> cursos = new List<Curso>();

            try
            {
                using(var context = new db_institutoEntities())
                {
                    cursos = context.Curso.ToList();
                }
                return cursos;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return cursos;
            }
        }
    }
}
