using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTavo.RepositoryPattern.Dominio
{
    public class Empleado
    {
        public string Id { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public List<Articulo> Articulos { get; set; }

        public DatosContacto DatosContacto { get; set; }
    }
}
