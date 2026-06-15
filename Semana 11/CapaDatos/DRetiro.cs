using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DRetiro
    {
        public List<Retiro> ListarTodo()
        {
            List<Retiro> retiros = new List<Retiro>();
            try
            {
                using (var context = new db_labAFPEntities())
                {
                    retiros = context.Retiro
                        .Where(r=>r.AFP.Eliminado==false)
                        .Where(r=>r.Empleado.Eliminado==false)
                        .Where(r => r.Eliminado == false).ToList();
                }
                return retiros;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return retiros;
            }
        }

        public String Registrar(Retiro objRetiro)
        {
            try
            {
                using (var context = new db_labAFPEntities())
                {
                    context.Retiro.Add(objRetiro);
                    context.SaveChanges();
                }
                return "Registrado Correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        public String EliminarFisico(int retiroId)
        {
            try
            {
                using (var context = new db_labAFPEntities())
                {
                    Retiro retiroTemp = context.Retiro.Find(retiroId);
                    context.Retiro.Remove(retiroTemp);
                    context.SaveChanges();
                }
                return "Eliminado Correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        public String EliminarLogico(int retiroId)
        {
            try
            {
                using (var context = new db_labAFPEntities())
                {
                    Retiro retiroTemp = context.Retiro.Find(retiroId);
                    retiroTemp.Eliminado = true;
                    context.SaveChanges();
                }
                return "Registrado Correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public String EditarRetiro(Retiro objRetiro)
        {
            try
            {
                using (var context = new db_labAFPEntities())
                {
                    Retiro retiroTemp = context.Retiro.Find(objRetiro.RetiroId);
                    retiroTemp.EmpleadoId = objRetiro.EmpleadoId;
                    retiroTemp.AFPId = objRetiro.AFPId;
                    retiroTemp.CuentaInterbancaria = objRetiro.CuentaInterbancaria;
                    retiroTemp.Monto = objRetiro.Monto;
                    context.SaveChanges();
                }
                return "El retiro se edito correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public List<Retiro> ListarRetirosConAFPHabitat()
        {
            List<Retiro> lRetiros = new List<Retiro>();
            try
            {
                using(var context = new db_labAFPEntities())
                {
                    lRetiros = context.Retiro
                        .Where(r => r.AFP.Eliminado == false)
                        .Where(r => r.Empleado.Eliminado == false)
                        .Where(r => r.Eliminado == false)
                        .Where(r => r.AFP.Nombre.Equals("Habitat"))
                        .ToList();
                }
                return lRetiros;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return lRetiros;
            }
        }

        public List<Retiro> ListarRetirosEmpleadosMasDe30Anios()
        {
            List<Retiro> retiros = new List<Retiro>();
            try
            {
                using (var context = new db_labAFPEntities())
                {
                    DateTime hoyMenos30anios = DateTime.Now.AddYears(-30);

                    retiros = context.Retiro
                        .Where(r => r.AFP.Eliminado == false)
                        .Where(r => r.Empleado.Eliminado == false)
                        .Where(r=>r.Empleado.FechaNacimiento<hoyMenos30anios)
                        .Where(r=>r.Eliminado==false)
                        .ToList();
                }
                return retiros;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return retiros;
            }
        }

        public decimal ObtenerMontoPromedio()
        {
            decimal monto = 0;
            try
            {
                using (var context = new db_labAFPEntities())
                {
                    monto = context.Retiro
                        .Where(r => r.AFP.Eliminado == false)
                        .Where(r => r.Empleado.Eliminado == false)
                        .Average(r => r.Monto);
                }
                return monto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return monto;
            }
        }
    }
}
