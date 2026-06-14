using Semana_4.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_4.cotrollers
{
    internal class CoordinadorController
    {
        private static List<Coordinador> coordinadores = new List<Coordinador>();

        public static List<Coordinador> ListarTodo()
        {
            return coordinadores;
        }

        private bool Existe(String codigoCoordinador)
        {
            return coordinadores.Exists(cod => cod.Codigo.Equals(codigoCoordinador));
        }

        public bool Registrar (Coordinador coordinador)
        {
            if (Existe(coordinador.Codigo))
            {
                return false;
            }
            else
            {
                coordinadores.Add(coordinador);
                return true;
            }

        }

        public List<Coordinador> BuscarPorCentro(String centroDistribucion)
        {
            return coordinadores.Where(c => c.CentroDistribucion.Equals(centroDistribucion)).ToList();
        }

    }
}
