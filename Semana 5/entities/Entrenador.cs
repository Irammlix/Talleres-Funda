using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_5.entities
{
    internal class Entrenador
    { 
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String Region { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public Entrenador()
        {
            Pokemons = new List<Pokemon>();
        }

    }
}
