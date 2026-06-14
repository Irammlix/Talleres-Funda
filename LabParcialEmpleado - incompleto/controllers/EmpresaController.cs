using LabParcialEmpleado.entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabParcialEmpleado.controllers
{
    internal class EmpresaController
    {
        private static List<Empresa> empresas = new List<Empresa>();

        public static List<Empresa> ListarTodo()
        {
          return empresas;
        }

        private bool Existe(String codigoEmp)
        {
            return empresas.Exists(e => e.Codigo.Equals(codigoEmp));
        }
        public bool Registrar(Empresa empresa)
        {
            if (Existe(empresa.Codigo))
            {
                return false;
            }
            else
            {
                empresas.Add(empresa);
                return true;
            }
        }

        public void Eliminar(String Codigo)
        {
            empresas.RemoveAll(e => e.Codigo.Equals(Codigo));
        }
    }
}
