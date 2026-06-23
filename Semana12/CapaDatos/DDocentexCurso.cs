using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DDocentexCurso
    {

        public List<DocentexCurso> ListarTodo()
        {
            List<DocentexCurso> lista = new List<DocentexCurso>();

            try
            {
                using (var context = new db_institutoEntities())
                {
                    lista = context.DocentexCurso
                    .Where(dc => dc.Eliminado == false)
                    .ToList();
                }
                return lista;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return lista;
            }
        }

        public String Registrar( DocentexCurso dc)
        {
            try
            {
                using(var context = new db_institutoEntities())
                {
                    context.DocentexCurso.Add(dc);
                    context.SaveChanges();
                }
                return "Registrado Existosamente";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public String EliminarLogico ( DocentexCurso dc)
        {
            try
            {
                using (var context = new db_institutoEntities())
                {
                    DocentexCurso dcAux = context.DocentexCurso.Find(dc.DocenteId, dc.CursoId, dc.Semestre);
                    //El orden tiene que ser igual al de la clase DocenteId, CursoId, Semestre
                    dcAux.Eliminado = true;
                    context.SaveChanges();
                }
                return "Eliminado Correctamente";
            }
            catch ( Exception ex)
            {
                return ex.Message;
            }
        }

        public String Inactivar (DocentexCurso dc)
        {
            try
            {
                using (var context = new db_institutoEntities())
                {
                    DocentexCurso dcAux = context.DocentexCurso.Find(dc.DocenteId, dc.CursoId, dc.Semestre);
                    //El orden tiene que ser igual al de la clase DocenteId, CursoId, Semestre
                    dcAux.Activado = false;
                    context.SaveChanges();
                }
                return "Inactivado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<DocentexCurso> ListarTodoPorCursoId(int cursoId)
        {
            List<DocentexCurso> lista = new List<DocentexCurso>();

            try
            {
                using (var context = new db_institutoEntities())
                {
                    lista = context.DocentexCurso
                    .Where(dc => dc.Eliminado == false)
                    .Where(dc => dc.CursoId.Equals(cursoId))
                    .ToList();
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return lista;
            }
        }

        public List<DocentexCurso> ListarTodoPorDocenteId(int docenteId)
        {
            List<DocentexCurso> lista = new List<DocentexCurso>();

            try
            {
                using (var context = new db_institutoEntities())
                {
                    lista = context.DocentexCurso
                    .Where(dc => dc.Eliminado == false)
                    .Where(dc => dc.DocenteId.Equals(docenteId))
                    .ToList();
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return lista;
            }
        }
    }
}
