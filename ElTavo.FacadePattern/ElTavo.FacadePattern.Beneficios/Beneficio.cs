using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio = ElTavo.FacadePattern.Dominio;

namespace ElTavo.FacadePattern.Beneficios
{
    public class Beneficio
    {
        public List<dominio.Beneficio> ObtenerrBeneficiosEmpleado(string idEmpleado)
        {
            // ... Buscar beneficios del empleado en particular.

            // ... Calculos para determinar si el empleado tiene un beneficio o no.

            return new List<dominio.Beneficio>()
            {
                new dominio.Beneficio {Nombre = "Prima extralegal 1", Valor = 2000000},
                new dominio.Beneficio {Nombre = "Prima extralegal 2", Valor = 1000000},
                new dominio.Beneficio {Nombre = "Subsidio para hijos", Valor = 500000}
            };
        }
    }
}
