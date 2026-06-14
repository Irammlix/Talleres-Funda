using Semana_4.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_4.cotrollers
{
    internal class RepartidorController
    {
        //Repartidor (entidad muchos)
        //NO TIENE LISTA ESTATICA YA QUE LOS COORDINADORES
        //SE ASOCIAN A UN COORDINADOR ESPECIFICO

        public List<Repartidor> ListarPorCoordinador(String codigoCoordinador)
        {
            //Saber la lista de coordinadores
            List<Coordinador> coordinadores = CoordinadorController.ListarTodo();

            Coordinador coordinador =coordinadores.Find(c=> c.Codigo.Equals(codigoCoordinador));

            return coordinador.Repartidores;

        }

        private bool Existe(String codigoRepartidor)
        {
            List<Coordinador> coordinadores = CoordinadorController.ListarTodo();

            //Obtener todos los repartidores SIN FILTRO

            List<Repartidor> repartidores =coordinadores.SelectMany(c=>c.Repartidores).ToList();

            return repartidores.Exists(rep=> rep.Codigo.Equals(codigoRepartidor));

        }

        public bool Registrar(String codigoCoordinador, Repartidor repartidor)
        {
            if (Existe(repartidor.Codigo))
            {
                return false;
            }
            else
            {
                //Saber la lista de coordinadores
                List<Coordinador> coordinadores = CoordinadorController.ListarTodo();

                Coordinador coordinador = coordinadores.Find(c => c.Codigo.Equals(codigoCoordinador));

                coordinador.Repartidores.Add(repartidor);

                return true;
            }
        }

        public List<Repartidor> BuscarTOP3PorCoordinadorYNumEntregas(String codigoCoordinador)
        {
            //Saber la lista de coordinadores
            List<Coordinador> coordinadores = CoordinadorController.ListarTodo();
            //filtro
            Coordinador coordinador = coordinadores.Find(c => c.Codigo.Equals(codigoCoordinador));

            List<Repartidor> repartidores =coordinador.Repartidores;

            return repartidores.OrderByDescending(r=>r.NumEntregas).Take(3).ToList();
        }
    }
}
