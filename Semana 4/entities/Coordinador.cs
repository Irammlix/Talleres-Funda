using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_4.entities
{
    internal class Coordinador
    {
        public String Codigo { get; set; }
        public String CentroDistribucion { get; set; }
        public String Turno { get; set; }
        public List<Repartidor> Repartidores { get; set; }
        
        // Constructor que inicializa la lista de Repartidores

        public Coordinador()
        {
            Repartidores =new List<Repartidor>();
        }
    }
}
