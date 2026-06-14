using semana66.entities;
using System;
using System.Collections.Generic;

namespace semana66.repositories
{
    public class CursoRepository
    {
        public List<Curso> ListarPorProfesor(String codigoProfesor)
        {
            List<Profesor> profesores = ProfesorRepository.ListarTodo();
            Profesor profesor = profesores.Find(p => p.Codigo.Equals(codigoProfesor));
            return profesor.Cursos;
        }

        public bool Existe( string codigoCurso, String codigoProfesor)
        {
            List<Profesor> profesores = ProfesorRepository.ListarTodo();
            Profesor profesor = profesores.Find(p => p.Codigo.Equals(codigoProfesor));
            List<Curso> cursos = profesor.Cursos;
            return cursos.Exists(c => c.Codigo.Equals(codigoCurso));
        }

        public void Registrar( Curso objCurso, String codigoProfesor)
        {
            List<Profesor> profesores = ProfesorRepository.ListarTodo();
            Profesor profesor = profesores.Find(p => p.Codigo.Equals(codigoProfesor));
            List<Curso> cursos = profesor.Cursos;
            cursos.Add(objCurso);
        }
    }
}
