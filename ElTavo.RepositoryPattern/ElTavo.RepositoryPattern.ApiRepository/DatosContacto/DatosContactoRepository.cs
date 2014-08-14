using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElTavo.RepositoryPattern.Contrato;

namespace ElTavo.RepositoryPattern.ApiRepository.DatosContacto
{
    public class DatosContactoRepository : BaseRepository<Dominio.DatosContacto>, IDatosContactoRepository
    {
        public Dominio.DatosContacto ObtenerDatosContactoEmpleado(string idEmpleado)
        {
            return ObtenerPorId(idEmpleado);
        }
    }
}
