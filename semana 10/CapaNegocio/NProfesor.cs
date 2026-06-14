using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NProfesor
    {
        private DProfesor dProfesor = new DProfesor();

        public String Registrar(Profesor objProfesor)
        {
            objProfesor.Activo = true;
            return dProfesor.Registrar(objProfesor);
        }

        public List<Profesor> ListarTodo()
        {
            return dProfesor.ListarTodo();
        }
    }
}
