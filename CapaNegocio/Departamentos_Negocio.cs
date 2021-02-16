using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class Departamentos_Negocio
    {
        Departamentos_Datos ejecutar = new Departamentos_Datos();

        public void GuardarDepartamentos(Departamentos elemento)
        {
            ejecutar.InsertarDepartamentos(elemento);
        }

        public List<Departamentos> MostrarDepartamentos()
        {
            return ejecutar.ListarDepartamentos();
        }

        public void ActualizarDepartamento(Departamentos departamentos)
        {
            ejecutar.ActualizarDepartamentos(departamentos);
        }

        public void BorrarDepartamento(Departamentos departamentos)
        {
            ejecutar.BorrarDepartamentos(departamentos);
        }
    }
}
