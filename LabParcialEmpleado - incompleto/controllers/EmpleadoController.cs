using LabParcialEmpleado.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabParcialEmpleado.controllers
{
    internal class EmpleadoController
    {

        public List<Empleado> ListarPorCodigoEmpresa(String Codigo)
        {
            List<Empresa> empresas = EmpresaController.ListarTodo();
            Empresa empresa = empresas.Find(e => e.Codigo.Equals(Codigo));
            return empresa.Empleados;
        }

        private bool Existe(String Codigo, String RUC)
        {
            List<Empresa> empresas = EmpresaController.ListarTodo();
            Empresa empresa = empresas.Find(e => e.Codigo.Equals(Codigo));

            return empresa.Empleados.Exists(ep=>ep.RUC.Equals(RUC));
        }
        public bool Registrar(String Codigo, Empleado empleado)
        {
            List<Empresa> empresas = EmpresaController.ListarTodo();
            Empresa empresa = empresas.Find(e => e.Codigo.Equals(Codigo));

            if(Existe(Codigo, empleado.RUC))
            {
                return false;
            }
            else
            {
                empresa.Empleados.Add(empleado);
                return true;
            }
        }

        public void Modificar(String Codigo, Empleado empleadoModificado)
        {
            List<Empresa> empresas = EmpresaController.ListarTodo();
            Empresa empresa = empresas.Find(e => e.Codigo.Equals(Codigo));

            String RUCEmp = empleadoModificado.RUC;

            Empleado empExistente = empresa.Empleados.Find(ep => ep.RUC.Equals(RUCEmp));

            if(empExistente != null)
            {
                empExistente.NombreCompleto = empleadoModificado.NombreCompleto;
                empExistente.Sueldo = empleadoModificado.Sueldo;
            }
        }

        public void Eliminar(String Codigo, String RUC)
        {
            List<Empresa> empresas = EmpresaController.ListarTodo();
            Empresa empresa = empresas.Find(e => e.Codigo.Equals(Codigo));

            empresa.Empleados.RemoveAll(ep => ep.RUC.Equals(RUC));
        }

    }
}
