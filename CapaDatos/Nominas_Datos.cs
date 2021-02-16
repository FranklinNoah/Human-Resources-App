using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaDatos
{
    public class Nominas_Datos
    {
        RecursosHumanosEntities4 database = new RecursosHumanosEntities4();
        public void InsertarNomina(Nominas nominas)
        {
            database.Nominas.Add(nominas);
            database.SaveChanges();
        }
        public List<Nominas> ListarNominas()
        {
            return database.Nominas.ToList();
        }

        public void ActualizarNominas(Nominas nominas)
        {
            var actualizar = database.Nominas.First(a => a.Año == nominas.Año);
           
            actualizar.Mes = nominas.Mes;
            actualizar.Id_Nomina = nominas.Id_Nomina;
            database.SaveChanges();
        }

        public void BorrarNomina(Nominas nominas)
        {
            var registro = database.Nominas.First(a => a.Año == nominas.Año);
            database.Nominas.Remove(registro);
            database.SaveChanges();
        }
        public void SumarNomina(Nominas nominas)
        {
            var listar = from emp in database.Empleados
                         select emp;

            var totalsalary = listar.Sum(emp => emp.Salario);
            nominas.MontoTotal = totalsalary;

        }
    }
}
