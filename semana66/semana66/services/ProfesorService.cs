using semana66.entities;
using semana66.repositories;
using System;
using System.Collections.Generic;

namespace semana66.services
{
    public class ProfesorService
    {
        private ProfesorRepository profesorRepositoy = new ProfesorRepository();

        public List<Profesor> ListarTodo()
        {
            return ProfesorRepository.ListarTodo();
        }

        public bool Registrar (Profesor objProfesor)
        {
            if (profesorRepositoy.Existe(objProfesor.Codigo))
            {
                return false;
            }
            else
            {
                profesorRepositoy.Registrar(objProfesor);
                return true;
            }
        }

    }
}
