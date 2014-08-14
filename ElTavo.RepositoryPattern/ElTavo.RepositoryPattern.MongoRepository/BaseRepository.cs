using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace ElTavo.RepositoryPattern.MongoRepository
{
    public class BaseRepository<T> where T : class
    {
        private readonly string _nombreColeccion;
        private MongoDatabase database;

        public BaseRepository(string nombreColeccion)
        {
            _nombreColeccion = nombreColeccion;
        }

        public void ConectarDb()
        {
            const string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            database = server.GetDatabase("RepositoryPatternDemo");
        }

        public void Insertar(T entidad)
        {
            var coleccion = database.GetCollection<T>(_nombreColeccion);
            coleccion.Insert(entidad);
        }

        public IQueryable<T> ObtenerTodos()
        {
            var coleccion = database.GetCollection<T>(_nombreColeccion);
            return coleccion.FindAll().AsQueryable();
        }
    }
}
