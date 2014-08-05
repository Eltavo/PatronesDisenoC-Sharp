using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTavo.RepositoryPattern.Dominio
{
    public class Articulo
    {
        public string Id { get; set; }

        public string Titulo { get; set; }

        public string ContenidoHtml { get; set; }

        public List<string> Etiquetas { get; set; }
    }
}
