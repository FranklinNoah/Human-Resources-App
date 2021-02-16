using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaDatos
{
    public class Empleados_Datos
    {
        RecursosHumanosEntities4 database = new RecursosHumanosEntities4();
        public void InsertarEmpleado(Empleados empleados)
        {
            database.Empleados.Add(empleados);
            database.SaveChanges();
        }

        public List<Empleados> ListarEmpleados()
        {
            return database.Empleados.ToList();
        }

        public void ActualizarEmpleado(Empleados empleados)
        {
            var actualizar = database.Empleados.First(a => a.CodigoEmpleado == empleados.CodigoEmpleado);
            //actualizar.Nombre = empleados.Nombre;
            //actualizar.Apellido = empleados.Apellido;
            //actualizar.Telefono = empleados.Telefono;
            actualizar.Departamento = empleados.Departamento;
            actualizar.Cargo = empleados.Cargo;
            //actualizar.FechaIngreso = empleados.FechaIngreso;
            //actualizar.Salario = empleados.Salario;
            //actualizar.Estatus = empleados.Estatus;
            database.SaveChanges();
        }

        public void BorrarEmpleado(Empleados empleados)
        {
            var registro = database.Empleados.First(a => a.CodigoEmpleado == empleados.CodigoEmpleado);
            database.Empleados.Remove(registro);
            database.SaveChanges();
        }
        

    }
}
