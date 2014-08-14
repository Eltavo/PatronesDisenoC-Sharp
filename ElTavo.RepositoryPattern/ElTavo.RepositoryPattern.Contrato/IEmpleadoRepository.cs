using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElTavo.RepositoryPattern.Dominio;

namespace ElTavo.RepositoryPattern.Contrato
{
    public interface IEmpleadoRepository
    {
        List<Empleado> ObtenerEmpleados();

        Empleado ObtenEmpleadoPoId(string id);

        void GuardarEmpleado(Empleado empleado);
    }
}
