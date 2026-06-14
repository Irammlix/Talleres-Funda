using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NAlumno
    {
        private DAlumno dAlumno = new DAlumno();

        public String Registrar (Alumno objAlumno)
        {
            objAlumno.Eliminado = false;
            objAlumno.PromedioFinalPC2 = objAlumno.PromedioTA * (decimal)0.25 + objAlumno.PC2 * (decimal)0.75;
            return dAlumno.Registrar(objAlumno);
        }

        public String Eliminar(int id)
        {
            return dAlumno.EliminarLogico(id);
        }

        public List<Alumno> ListarTodo()
        {
            return dAlumno.ListarTodo();
        }

        public List<Alumno> BuscarPorNombre(String nombre)
        {
            return dAlumno.BuscarPorNombre(nombre);
        }

        public List<Alumno> OrdenarPromedioFinalPC2()
        {
            return dAlumno.OrdenarPorPromedioFinalPC2();
        }

    }
}
