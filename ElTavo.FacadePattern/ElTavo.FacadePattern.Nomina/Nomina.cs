using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElTavo.FacadePattern.Dominio;

namespace ElTavo.FacadePattern.Nomina
{
    public class Nomina
    {
        public double ObtenerSalarioEmpleado(string idEmpleado)
        {
            // Simulamos los empleados de la compañía
            var empleados = new List<Empleado>()
            {
                new Empleado() {Id = "1", Nombre = "Empleado 1", Salario = 1500000},
                new Empleado() {Id = "2", Nombre = "Empleado 2", Salario = 2000000},
                new Empleado() {Id = "3", Nombre = "Empleado 3", Salario = 3000000},
                new Empleado() {Id = "4", Nombre = "Empleado 4", Salario = 4000000},
            };

            // ... Operaciones complejas y calculos del negocio.

            return empleados.First(c => c.Id.Equals(idEmpleado)).Salario;
        }
    }
}
