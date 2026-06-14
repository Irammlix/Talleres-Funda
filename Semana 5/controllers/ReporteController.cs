using Semana_5.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_5.controllers
{
    internal class ReporteController
    {
        public List<Entrenador> ListarEntrenadorPorRegion(String region)
        {
            List<Entrenador> lEntrenadores = EntrenadorController.ListarTodo();
            return lEntrenadores.Where(e => e.Region.Equals(region)).ToList();
        }

        public List<Entrenador> ListarEntrenadorPorNombrePokemon(String nombrePokemon)
        {
            List<Entrenador> lEntrenadores = EntrenadorController.ListarTodo();
            return lEntrenadores.Where(e => e.Pokemons.Exists(p => p.Nombre.Equals(nombrePokemon))).ToList();
        }

        //Devuelve una lista de objetos, como tal no deveulve en su totaldad al entrendato, si no el entrenador y la cantidad minima, y rdenarlo

        public List<Object> ListarEntrenadoresPorMenorCantidadPokemon()
        {
            List<Entrenador> lEntrenadores = EntrenadorController.ListarTodo();
            var reporte = lEntrenadores
                .Select(r => new
                {
                    CodigoEntrenador = r.Codigo,
                    CantidadPokemon = r.Pokemons.Count
                })
                .OrderBy(r => r.CantidadPokemon).Cast<Object>().ToList();

            return reporte;
        }

        public List<Object> ListarEntrenadoresPorMaxPuntosSaludPokemon()
        {
            List<Entrenador> lEntrenadores = EntrenadorController.ListarTodo();
            var reporte = lEntrenadores
                .Select(r => new
                {
                    CodigoEntrenador = r.Codigo,
                    MaxPuntoSaludPokemon = r.Pokemons.Count == 0 ?
                    0: r.Pokemons.Max(p=>p.PuntosSalud)
                })
                .OrderByDescending(r => r.MaxPuntoSaludPokemon).Cast<Object>().ToList();

            return reporte;

        }

        public List<Pokemon> ListarPokemonsLegendarios()
        {
            List<Entrenador> lEntrenadores = EntrenadorController.ListarTodo();
            List<Pokemon> lPokemons = lEntrenadores.SelectMany(e => e.Pokemons).ToList();
            return lPokemons.Where(p => p.Legendario.Equals(true)).ToList();
        }

        public List<Pokemon> ListarPokemonsPorEdadEntrenadores(int edadMin, int edadMax)
        {
            List<Entrenador> lEntrenadores = 
                EntrenadorController.ListarTodo().Where(e=>e.Edad>=edadMin && e.Edad<=edadMax).ToList();
            return lEntrenadores.SelectMany(e => e.Pokemons).ToList();


        }

        public List<Object> ReporteCensoLegendario()
        {
            List<Entrenador> lEntrenadores = EntrenadorController.ListarTodo();

            var reporte = lEntrenadores.Select(e => new 
            {
                Entrenador = e.Nombre,
                EdadEntrenador = e.Edad,
                Ubicacion = e.Region,
                TotalLegendarios = e.Pokemons.Count(p => p.Legendario == true),
                Rango = e.Edad > 20 ? "Senior" : "Junior"
            }
            ).OrderByDescending(r=>r.TotalLegendarios).Cast<Object>().ToList();

            return reporte;
        }

        public List<Object> ReporteVitalidadEquipos()
        {
            List<Entrenador> lEntrenadores = EntrenadorController.ListarTodo();
            var reporte = lEntrenadores.Select(
                e => new
                {
                    Entrenador = e.Nombre,
                    CantidadPokemons = e.Pokemons.Count,
                    PSTotal = e.Pokemons.Sum(p => p.PuntosSalud),
                    PSPromedio = e.Pokemons.Count > 0 ? e.Pokemons.Average(p => p.PuntosSalud) : 0
                }
                ).Cast<Object>().ToList();

            return reporte;
        }
    }

}
