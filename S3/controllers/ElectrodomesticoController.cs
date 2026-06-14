using S3.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3.controllers
{
    internal class ElectrodomesticoController
    {
        //aqui se construyte la logica de negocio
        //Simula nuestra base de datos
        private static List<Electrodomestico> electrodomesticos = new List<Electrodomestico>();
        // es muy i<mportante poner el static ya que gracias a este si lo llamo desde otro form, la lista no va a variar

        public static List<Electrodomestico> ListarTodo()
        {
            return electrodomesticos;
        }

        private bool Existe(String codigo)
        {
            // En la lista de electrodomesticos (electrodomesticos)
            //Existe (Exists)
            // algun electrodomestico (elec)
            // tal que (=>)
            //El codigo de ese electrodomestico (elec.Codigo)
            //Sea igual al codigo que le estoy pasando (.Equals(codigo))
            return electrodomesticos.Exists(elec => elec.Codigo.Equals(codigo));
        }

        public bool Registrar(Electrodomestico elec)
        {
            if (Existe(elec.Codigo))
            {
                return false;
            }
            else
            {
                electrodomesticos.Add(elec);
                return true;
            }

        }

        public void Eliminar( String codigo)
        {
            electrodomesticos.RemoveAll(elec => elec.Codigo.Equals(codigo));
        }

        public void EliminarTodo()
        {
            electrodomesticos.Clear();
        }

        public List<Electrodomestico> BuscarPorNombre(String nombre)
        {
            //return electrodomesticos.Where(elec => elec.Nombre.Equals(nombre)).ToList();
            //return electrodomesticos.Where(elec => elec.Nombre.Contains(nombre)).ToList();
            return electrodomesticos.Where(elec => elec.Nombre.StartsWith(nombre)).ToList();
            //return electrodomesticos.Where(elec => elec.Nombre.EndsWith(nombre)).ToList();

        }

        public List<Electrodomestico> OrdenarPorPrecio()
        {
            // Tenemos el OrderBy(asscenednte) y OrderByDescndisn
            //Aqui no es una conidcion(lambda) aqui es por la propiedad por la 
            //cual estas ordenadno
            return electrodomesticos.OrderBy(elec=> elec.Precio).ToList();
        }

        public int CantidadTotal()
        {
            return electrodomesticos.Count();
        }
    }

}
