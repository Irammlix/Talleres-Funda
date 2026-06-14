using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.entities
{
    internal class Empleado
    {
        public String Nombre { get; set; }
        public String Categoria { get; set; }
        public int MinTardanza { get; set; }
        public double Pago { get; set; }
        public int NumFaltas { get; set;  }

    }
}
