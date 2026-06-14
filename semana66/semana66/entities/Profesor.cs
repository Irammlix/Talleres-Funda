using System;
using System.Collections.Generic;

namespace semana66.entities
{
    public class Profesor
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public List<Curso> Cursos { get; set; }

        public Profesor()
        {
            Cursos = new List<Curso>();
        }
    }
}
