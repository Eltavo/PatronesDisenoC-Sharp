using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace ElTavo.RepositoryPattern.MongoRepository.Articulo
{
    public class Articulo
    {
        public ObjectId Id { get; set; }

        public string Titulo { get; set; }

        public string ContenidoHtml { get; set; }

        public List<string> Etiquetas { get; set; }

        public string IdEmpleado { get; set; }
    }
}
