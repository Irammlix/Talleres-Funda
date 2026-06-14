using Semana2_Ejercicio1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Ejercicio1.controllers
{
    internal class AlumnoController
    {
        private Alumno[] alumnos = new Alumno[100];
        private int cont = 0;

        public Alumno[] ListarTodo()
        {
            return alumnos; //Dado que alumnos es private hacemos esto
        }

        public void Registrar(Alumno alumno)
        {
            alumnos[cont] = alumno;
            cont++;
        }

        public void Eliminar(string Codigo)
        {
            alumnos = alumnos.Where(a => a !=  null && a.Codigo != Codigo).ToArray();
            Array.Resize(ref alumnos, 100);

            cont = alumnos.Count(a => a != null);
        }

        public void EliminarAlternativo(String codigo)
        {
            int pos = Array.FindIndex(alumnos, alumno => alumno.Codigo.Equals(codigo));

            //logica de eleiminacion

            for(int i =0; i < cont; i++)
            {
                if (i>=pos)
                {
                    alumnos[i] = alumnos[i + 1];
                }
            } 

            cont--;
        }

        public Alumno[] BuscarPorCodigo(String codigo)
        {
            return alumnos.Where(a => a != null && a.Codigo == codigo).ToArray();
        }

        public Alumno[] OrdenarPorPromedio()
        {
            return alumnos.OrderBy(alumno => alumno.Promedio).ToArray();
        }

        public Alumno[] BuscarPorSeccion(String seccion)
        {
            return alumnos.Where(a => a != null && a.Seccion == seccion).ToArray();

        }
    }
}
