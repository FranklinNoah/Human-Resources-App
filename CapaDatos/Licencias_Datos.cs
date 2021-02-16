using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaDatos
{
    public class Licencias_Datos
    {
        RecursosHumanosEntities4 database = new RecursosHumanosEntities4();
        public void InsertarLicencias(Licencias licencias)
        {
            database.Licencias.Add(licencias);
            database.SaveChanges();
        }

        public List<Licencias> ListarLicencias()
        {
            return database.Licencias.ToList();
        }

        public void ActualizarLicencias(Licencias licencias)
        {
            var actualizar = database.Licencias.First(a => a.Id_Empleado == licencias.Id_Empleado);
            //actualizar.Nombre = empleados.Nombre;
            //actualizar.Apellido = empleados.Apellido;
            //actualizar.Telefono = empleados.Telefono;
            actualizar.Desde = licencias.Desde;
            actualizar.Hasta = licencias.Hasta;
            //actualizar.FechaIngreso = empleados.FechaIngreso;
            //actualizar.Salario = empleados.Salario;
            //actualizar.Estatus = empleados.Estatus;
            database.SaveChanges();
        }

        public void BorrarLicencias(Licencias licencias)
        {
            var registro = database.Licencias.First(a => a.Id_Empleado == licencias.Id_Empleado);
            database.Licencias.Remove(registro);
            database.SaveChanges();
        }
    }
}
