using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Empleado
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public double Sueldo { get; set; }
        public List<Reunion> Reuniones { get; set; }

        public Empleado()
        {
            Reuniones = new List<Reunion>();
        }
    }
}
