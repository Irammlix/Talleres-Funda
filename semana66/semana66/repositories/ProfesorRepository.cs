using semana66.entities;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace semana66.repositories
{
    public class ProfesorRepository
    {
        private static List<Profesor> profesores = new List<Profesor>
        {
            new Profesor
            {
                Codigo = "P001",
                Nombre = "Ana Pérez",
                Especialidad = "Ingenieria",
                Cursos = new List<Curso>
                {
                    new Curso { Codigo = "C001", Nombre = "Algoritmos", Area = "Ingenieria de Sistemas", Creditos = 4 },
                    new Curso { Codigo = "C002", Nombre = "Estructuras de Datos", Area = "Ingenieria de Software", Creditos = 3 },
                    new Curso { Codigo = "C003", Nombre = "Matemáticas Discretas", Area = "Ciencias de la Computacion", Creditos = 6 },
                    new Curso { Codigo = "C004", Nombre = "Matemática Computacional", Area = "Ciencias de la Computacion", Creditos = 8 }

                }
            },
            new Profesor
            {
                Codigo = "P002",
                Nombre = "Luis Gómez",
                Especialidad = "Ciencias Basicas",
                Cursos = new List<Curso>
                { 
                    new Curso { Codigo = "C004", Nombre = "Física I", Area = "Ciencias de la Computacion", Creditos = 2 }
                }
            },
            new Profesor
            {
                Codigo = "P003",
                Nombre = "María López",
                Especialidad = "Arquitectura",
                Cursos = new List<Curso>
                {
                    new Curso { Codigo = "C005", Nombre = "Diseño Arquitectónico", Area = "Ingenieria de Sistemas", Creditos = 5 },
                    new Curso { Codigo = "C006", Nombre = "Historia de la Arquitectura", Area = "Ingenieria de Software", Creditos = 2 }
                }
            },
            new Profesor
            {
                Codigo = "P004",
                Nombre = "Carlos Ruiz",
                Especialidad = "Ingenieria",
                Cursos = new List<Curso>()
            }
        };

        public static List<Profesor> ListarTodo()
        {
            return profesores;
        }

        public bool Existe(string codigoProfesor)
        {
            return profesores.Exists(p => p.Codigo.Equals(codigoProfesor));
        }

        public void Registrar( Profesor profesor)
        {
            profesores.Add(profesor);
        }

    }
}
