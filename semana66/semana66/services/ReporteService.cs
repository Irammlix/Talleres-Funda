using semana66.entities;
using semana66.repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana66.services
{
    internal class ReporteService
    {
        //Listar los profesores que dictan los cursos con mayor cantidad de créditos.
        public List<object> ListarProfesoresCursosMayorCantidadCredito()
        {
            List<Profesor> profesores = ProfesorRepository.ListarTodo();

            //obtengo todos los curso de todos los profesores

            List<Curso> todosLosCursos = profesores.SelectMany(p => p.Cursos).ToList();

            //Hallar el maximo de creditos que puede tener un curso

            int maximoCreditos = 0;
            //¿Hay al menos uno? o ¿Hay alguno?
            if (todosLosCursos.Any())
            {
                maximoCreditos = todosLosCursos.Max(c => c.Creditos);
            }

            List<object> lista = new List<object>();

            //recorrer los profesores y buscar a los que tienen algun curso con ese maximo de creditos

            foreach ( Profesor profesor in profesores)
            {
                if (profesor.Cursos.Any(c => c.Creditos == maximoCreditos))
                {
                    lista.Add(profesor);
                }
            }

            return lista;
        }
        //Listar los profesores que dictan menos cursos.

        public List<object> ListarProfesoresMenosCursos()
        {
            List<Profesor> profesores = ProfesorRepository.ListarTodo();
            //hallar cantidad minima de cursos 
            int cantMinimaCursos = 0;

            if (profesores.Any())
            {
                cantMinimaCursos = profesores.Min(p => p.Cursos.Count);
            }

            List<object> lista = new List<object>();

            foreach (Profesor profesor in profesores)
            {
                if (profesor.Cursos.Count==cantMinimaCursos)
                {
                    lista.Add(profesor);
                }
            }

            return lista;
        }
        //Listar los cursos que pertenecen a profesores de una determinada especialidad.

        public List<object> ListarCursosProfesoresPorEspecialidad(String tipoEspecialidad)
        {
            List<Profesor> profesores = ProfesorRepository.ListarTodo();

            //Filtrar profesores que tengan la especialidad requerida

            List<Profesor> profesorPorEspecialidad = profesores.Where(p => p.Especialidad.Equals(tipoEspecialidad)).ToList();

            List<object> lista = new List<object>();


            //obtener todos los cursos de esos profesores filtrados pro especialadad anteriormente
            lista = profesorPorEspecialidad.SelectMany(p => p.Cursos).ToList<object>();

            return lista;
        }

        public List<object> ListarCursosPorAreaYMasde5Creditos(String areaCurso)
        {
            List<Profesor> profesores = ProfesorRepository.ListarTodo();

            List<Curso> todosLosCursos = profesores.SelectMany(p => p.Cursos).ToList();
            List<Curso> cursosFiltrados = todosLosCursos.
                Where(c => c.Area.Equals(areaCurso) && c.Creditos > 5)
                .OrderByDescending(c=>c.Creditos)
                .ToList();

            List<object> reporte = cursosFiltrados.Select(c => new {
                Curso = c.Nombre,
                Area = c.Area,
                Creditos = c.Creditos
            }).ToList<object>();

            return reporte;
        }

        public List<object> ListarProfesorconPromedioCreditosPorEspecialidad(String especialidadProfesor)
        {
            List<Profesor> profesores = ProfesorRepository.ListarTodo();

            List<Profesor> filtrados = profesores
                .Where(p => p.Especialidad.Equals(especialidadProfesor) && p.Cursos.Count > 3).ToList();

            List<object> reporte = filtrados.Select(p => new
            {
                NombreProfesor = p.Nombre,
                Especialidad = p.Especialidad,
                CantidadCursos = p.Cursos.Count,
                PromedioCreditos = p.Cursos.Average(c => c.Creditos).ToString()
            }).ToList<object>();

            return reporte;
        }
    }
}
