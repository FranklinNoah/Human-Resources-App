using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class Empleados_Negocio
    {
        Empleados_Datos ejecutar = new Empleados_Datos();

        public void GuardarEmpleado(Empleados elemento)
        {
            ejecutar.InsertarEmpleado(elemento);
        }

        public List<Empleados> MostrarDatos()
        {
            return ejecutar.ListarEmpleados();
        }

        public void ActualizarEmpleado(Empleados empleados)
        {
            ejecutar.ActualizarEmpleado(empleados);
        }

        public void BorrarEmpleado(Empleados empleados)
        {
            ejecutar.BorrarEmpleado(empleados);
        }

       


    }
}
