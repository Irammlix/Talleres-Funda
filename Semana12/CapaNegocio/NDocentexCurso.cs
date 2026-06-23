using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NDocentexCurso
    {
        private DDocentexCurso dDxC = new DDocentexCurso();

        public List<DocentexCurso> ListarTodo()
        {
            return dDxC.ListarTodo();
        }

        public String Registrar (DocentexCurso dc)
        {
            dc.Eliminado = false;
            dc.Activado = true;
            return dDxC.Registrar(dc);
        }

        public String Eliminar(DocentexCurso dc)
        {
            return dDxC.EliminarLogico(dc);
        }

        public String Inactivar ( DocentexCurso dc)
        {
            return dDxC.Inactivar(dc);
        }

        public List<DocentexCurso> ListarTodoPorCursoId(int cursoId)
        {
            return dDxC.ListarTodoPorCursoId(cursoId);
        }

        public List<DocentexCurso> ListarTodoPorDocenteId(int docenteId)
        {
            return dDxC.ListarTodoPorDocenteId(docenteId);
        }
    }
}
