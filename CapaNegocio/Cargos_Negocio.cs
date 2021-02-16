using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
   public class Cargos_Negocio
    {
        Cargos_Datos ejecutar = new Cargos_Datos();

        public void GuardarCargo(Cargos elemento)
        {
            ejecutar.InsertarCargos(elemento);
        }

        public List<Cargos> MostrarCargos()
        {
            return ejecutar.ListarCargos();
        }

        public void ActualizarCargo(Cargos cargos)
        {
            ejecutar.ActualizarCargos(cargos);
        }

        public void BorrarCargo(Cargos cargos)
        {
            ejecutar.BorrarCargos(cargos);
        }
    }
}
