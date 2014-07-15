using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio = ElTavo.FacadePattern.Dominio;

namespace ElTavo.FacadePattern.Incentivos
{
    public class Incentivo
    {
        public List<dominio.Incentivo> ObtenerIncentivosEmpleado(string idEmpleado)
        {
            // ... Buscar incentivos otorgados al empleado con reglas de negocio.

            return new List<dominio.Incentivo>()
            {
                new dominio.Incentivo {Concepto = "Bono por cumplimiento", Valor = 200000},
                new dominio.Incentivo {Concepto = "Bono por felicitaciones del cliente", Valor = 200000}
            };
        }
    }
}
