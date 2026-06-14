using Lab02.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.controllers
{
    internal class EmpleadoController
    {
        public Empleado ProcesarEmpleado(Empleado empleado)
        {
            switch(empleado.Categoria)
            {
                case "A":
                    empleado.Pago = 1000;
                    break;
                case "B":
                    empleado.Pago = 900;
                    break;
                case "C":
                    empleado.Pago = 600;
                    break;
                default:
                    empleado.Pago = 0;
                    break;
            }

            //Logica de aumento y descuento
            if(empleado.MinTardanza == 0 && empleado.NumFaltas == 0)
            {
                empleado.Pago = empleado.Pago * 1.15;
            }
            else
            {
                empleado.Pago -= (empleado.MinTardanza * 5) + (empleado.NumFaltas *10); 
            }

            return empleado;
        }
    }
}
