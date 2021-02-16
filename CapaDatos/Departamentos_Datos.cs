using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaDatos
{
    public class Departamentos_Datos
    {
        RecursosHumanosEntities4 database = new RecursosHumanosEntities4();
        public void InsertarDepartamentos(Departamentos departamentos)
        {
            database.Departamentos.Add(departamentos);
            database.SaveChanges();
        }

        public List<Departamentos> ListarDepartamentos()
        {
            return database.Departamentos.ToList();
        }

        public void ActualizarDepartamentos(Departamentos departamentos)
        {
            var actualizar = database.Departamentos.First(a => a.CodigoDepartamento == departamentos.CodigoDepartamento);
            //actualizar.Nombre = empleados.Nombre;
            //actualizar.Apellido = empleados.Apellido;
            //actualizar.Telefono = empleados.Telefono;
            actualizar.Nombre = departamentos.Nombre;
            //actualizar.FechaIngreso = empleados.FechaIngreso;
            //actualizar.Salario = empleados.Salario;
            //actualizar.Estatus = empleados.Estatus;
            database.SaveChanges();
        }

        public void BorrarDepartamentos(Departamentos departamentos)
        {
            var registro = database.Departamentos.First(a => a.CodigoDepartamento == departamentos.CodigoDepartamento);
            database.Departamentos.Remove(registro);
            database.SaveChanges();
        }
    }
}
