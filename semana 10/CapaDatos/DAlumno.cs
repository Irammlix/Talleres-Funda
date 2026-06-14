using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DAlumno
    {
        public String Registrar( Alumno objAlumno)
        {
            try
            {
                using (var context = new dbSemana10Entities())
                {
                    context.Alumno.Add(objAlumno);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        
        public String EliminarFisico (int id)
        {
            try
            {
                using(var context = new dbSemana10Entities())
                {
                    Alumno alumnoTemp = context.Alumno.Find(id);
                    context.Alumno.Remove(alumnoTemp);
                    context.SaveChanges();
                }
                return "Eliminado Exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String EliminarLogico(int id)
        {
            try
            {
                using (var context = new dbSemana10Entities())
                {
                    Alumno alumnoTemp = context.Alumno.Find(id);
                    alumnoTemp.Eliminado = true;
                    context.SaveChanges();
                }
                return "Eliminado Exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Alumno> ListarTodo()
        {
            List<Alumno> alumnos = new List<Alumno>();

            try
            {
                using ( var context = new dbSemana10Entities())
                {
                    alumnos = context.Alumno.Where(a=>a.Eliminado==false).ToList();
                }

                return alumnos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return alumnos;
            }
        }

        public List<Alumno> BuscarPorNombre(String nombre)
        {
            List<Alumno> alumnos = new List<Alumno>();

            try
            {
                using (var context = new dbSemana10Entities())
                {
                    alumnos = context.Alumno.
                        Where(a=> a.Nombre.Contains(nombre))
                        .Where(a => a.Eliminado == false).ToList();
                }

                return alumnos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return alumnos;
            }
        }

        public List<Alumno> OrdenarPorPromedioFinalPC2()
        {
            List<Alumno> alumnos = new List<Alumno>();

            try
            {
                using (var context = new dbSemana10Entities())
                {
                    alumnos = context.Alumno.Where(a => a.Eliminado == false)
                        .OrderByDescending(a=>a.PromedioFinalPC2).ToList();
                }

                return alumnos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return alumnos;
            }
        }
    }
}
