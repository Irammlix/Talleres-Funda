using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DProfesor
    {
        public String Registrar(Profesor objProfesor)
        {
            try
            {
                using (var context = new dbSemana10Entities())
                {
                    context.Profesor.Add(objProfesor);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Profesor> ListarTodo()
        {
            List<Profesor> profesores = new List<Profesor>();

            try
            {
                using (var context = new dbSemana10Entities())
                {
                    profesores = context.Profesor.ToList();
                }

                return profesores;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return profesores;
            }
        }
    }
}
