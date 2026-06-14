using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_5.entities
{
    internal class Pokemon
    {
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Apodo { get; set; }
        public String Tipo { get; set; }
        public int PuntosSalud { get; set; }
        public bool Legendario { get; set; }

    }
}
