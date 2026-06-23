using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NDocente
    {
        private DDocente dDocente = new DDocente();

        public List<Docente> ListarTodo()
        {
            return dDocente.ListarTodo();
        }
    }
}
