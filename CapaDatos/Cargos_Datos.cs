using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaDatos
{
    public class Cargos_Datos
    {
        RecursosHumanosEntities4 database = new RecursosHumanosEntities4();
        public void InsertarCargos(Cargos cargos)
        {
            database.Cargos.Add(cargos);
            database.SaveChanges();
        }

        public List<Cargos> ListarCargos()
        {
            return database.Cargos.ToList();
        }

        public void ActualizarCargos(Cargos cargos)
        {
            var actualizar = database.Cargos.First(a => a.Id_Empleado == cargos.Id_Empleado);
            //actualizar.Nombre = empleados.Nombre;
            //actualizar.Apellido = empleados.Apellido;
            //actualizar.Telefono = empleados.Telefono;
            actualizar.Cargo = cargos.Cargo;
            //actualizar.FechaIngreso = empleados.FechaIngreso;
            //actualizar.Salario = empleados.Salario;
            //actualizar.Estatus = empleados.Estatus;
            database.SaveChanges();
        }

        public void BorrarCargos(Cargos cargos)
        {
            var registro = database.Cargos.First(a => a.Id_Empleado == cargos.Id_Empleado);
            database.Cargos.Remove(registro);
            database.SaveChanges();
        }
    }
}
