using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NCurso
    {
        private DCurso dCurso = new DCurso();

        public List<Curso> ListarTodo()
        {
            return dCurso.ListarTodo();
        }
    }
}
