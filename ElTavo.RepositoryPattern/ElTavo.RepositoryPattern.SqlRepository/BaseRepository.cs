using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElTavo.RepositoryPattern.SqlRepository
{
    public class BaseRepository<T> where T : class
    {
        protected DbContext Contexto = new Contexto();
        protected DbSet<T> DbSet;

        public BaseRepository()
        {
            DbSet = Contexto.Set<T>();
        }

        public void Insertar(T entidad)
        {
            DbSet.Add(entidad);
        }

        public void Eliminar(T entidad)
        {
            DbSet.Remove(entidad);
        }

        public IQueryable<T> Filtrar(Expression<Func<T, bool>> expresion)
        {
            return DbSet.Where(expresion);
        }

        public T ObtenerPorId(string id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> ObtenerTodos()
        {
            return DbSet;
        }

        public void GuardarCambios()
        {
            Contexto.SaveChanges();
        }
    }
}
