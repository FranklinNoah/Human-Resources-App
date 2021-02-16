using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class Licencias_Negocio
    {
        Licencias_Datos ejecutar = new Licencias_Datos();
        public void GuardarLicencia(Licencias elemento)
        {
            ejecutar.InsertarLicencias(elemento);
        }

        public List<Licencias> MostrarLicencias()
        {
            return ejecutar.ListarLicencias();
        }

        public void ActualizarLicencia(Licencias licencias)
        {
            ejecutar.ActualizarLicencias(licencias);
        }

        public void BorrarLicencia(Licencias licencias)
        {
            ejecutar.BorrarLicencias(licencias);
        }
    }
}
