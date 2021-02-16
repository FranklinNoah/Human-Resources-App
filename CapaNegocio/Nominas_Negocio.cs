using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class Nominas_Negocio
    {
        Nominas_Datos ejecutar = new Nominas_Datos();

        public void InsertarNomina(Nominas nominas)
        {
            ejecutar.InsertarNomina(nominas);
        }

        public List<Nominas> MostrarNomina()
        {
            return ejecutar.ListarNominas();
        }

        public void ActualizarNominas(Nominas nominas)
        {
            ejecutar.ActualizarNominas(nominas);
        }

        public void BorrarNomina(Nominas nominas)
        {
            ejecutar.BorrarNomina(nominas);
        }

        public void SumarNomina(Nominas nominas)
        {
            ejecutar.SumarNomina(nominas);
        }
    }
}
