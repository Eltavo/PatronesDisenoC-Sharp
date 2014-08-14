using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElTavo.RepositoryPattern.Contrato;

namespace ElTavo.RepositoryPattern.MongoRepository.Articulo
{
    public class ArticuloRepository : BaseRepository<Articulo>, IArticuloRepository
    {
        public ArticuloRepository(string nombreColeccion = "Articulos")
            : base(nombreColeccion)
        {
        }

        public List<Dominio.Articulo> ObtenerArticulos()
        {
            AutoMapper.Mapper.CreateMap<Articulo, Dominio.Articulo>();

            ConectarDb();
            return new List<Dominio.Articulo>(ObtenerTodos().Select(c =>
                AutoMapper.Mapper.Map<Dominio.Articulo>(c)
                ));
        }

        public Dominio.Articulo ObtenArticuloPorId(string id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Dominio.Articulo> ObtenerArticulosPorIdEmpleado(string idEmpleado)
        {
            throw new NotImplementedException();
        }

        public void GuardarArticulo(Dominio.Articulo articulo)
        {
            AutoMapper.Mapper.CreateMap<Dominio.Articulo, Articulo>();
            var art = AutoMapper.Mapper.Map<Articulo>(articulo);

            ConectarDb();
            Insertar(art);
        }
    }
}
