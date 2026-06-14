using Semana_5.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_5.controllers
{
    internal class EntrenadorController
    {
        //Simula una base dedatos
        private static List<Entrenador> entrenadores = new List<Entrenador>();

        private bool Existe(String codigoEntrenador)
        {
            return entrenadores.Exists(c=>c.Codigo.Equals(codigoEntrenador));
        }
        public bool Registrar(Entrenador bEntrenador)
        {
            if (Existe(bEntrenador.Codigo)){
                return false;
            }

            entrenadores.Add(bEntrenador);
            return true;
        }

        public static List<Entrenador> ListarTodo()
        {
            return entrenadores;
        }
    }
}
