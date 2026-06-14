using semana66.entities;
using semana66.repositories;
using System;
using System.Collections.Generic;

namespace semana66.services
{
    public class CursoService
    {
        private CursoRepository cursoRepository = new CursoRepository();

        public List <Curso> ListaPorProfesor( string codigoProfesor)
        {
            return cursoRepository.ListarPorProfesor(codigoProfesor);
        }

        public bool Registrar(String codigoProfesor, Curso objCurso)
        {
            if (cursoRepository.Existe(objCurso.Codigo, codigoProfesor))
            {
                return false;
            }
            else
            {
                cursoRepository.Registrar(objCurso, codigoProfesor);
                return true;
            }
        }
    }
}
