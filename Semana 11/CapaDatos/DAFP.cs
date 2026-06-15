using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DAFP
    {
        public List<AFP> ListarTodo()
        {
            List<AFP> afps = new List<AFP>();
            try
            {
                using (var context = new db_labAFPEntities())
                {
                    afps = context.AFP.Where(a => a.Eliminado == false).ToList();
                }
                return afps;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return afps;
            }
        }
    }
}
