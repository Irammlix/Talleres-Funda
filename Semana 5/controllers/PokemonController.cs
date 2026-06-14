using Semana_5.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_5.controllers
{
    internal class PokemonController
    {
        private bool Existe(String codigoPokemon)
        {
            List<Entrenador> entrenadores = EntrenadorController.ListarTodo();
            List<Pokemon> pokemons =entrenadores.SelectMany(e=>e.Pokemons).ToList();
            return pokemons.Exists(c => c.Codigo.Equals(codigoPokemon));
        }

        public bool Registrar(String codigoEntrenador, Pokemon pokemon)
        {
            if (Existe(pokemon.Codigo))
            {
                return false;
            }

            List<Entrenador> entrenadores = EntrenadorController.ListarTodo();
            Entrenador entrenadorEnc = entrenadores.Find(e => e.Codigo.Equals(codigoEntrenador));
            entrenadorEnc.Pokemons.Add(pokemon);
            return true;
        }

        public List<Pokemon> ListarTodo(String codigoEntrenador)
        {
            List<Entrenador> entrenadores = EntrenadorController.ListarTodo();
            Entrenador entrenadorEnc = entrenadores.Find(e => e.Codigo.Equals(codigoEntrenador));
            return entrenadorEnc.Pokemons;
        }

        public void EliminarPokemon(String codEntrenador, String codPokemon)
        {
            List<Entrenador> entrenadores = EntrenadorController.ListarTodo();

            Entrenador entrenadorEnc=entrenadores.Find(e => e.Codigo.Equals(codEntrenador));

            entrenadorEnc.Pokemons.RemoveAll(p => p.Codigo.Equals(codPokemon));
        }
    }
}
