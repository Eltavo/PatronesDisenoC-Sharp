using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElTavo.RepositoryPattern.Dominio;

namespace ElTavo.RepositoryPattern.Contrato
{
    public interface IArticuloRepository
    {
        List<Articulo> ObtenerArticulos();

        Articulo ObtenArticuloPorId(string id);

        ICollection<Articulo> ObtenerArticulosPorIdEmpleado(string idEmpleado);

        void GuardarArticulo(Articulo articulo);
    }
}
