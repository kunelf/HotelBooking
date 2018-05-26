using System.Data.Entity;
using System.Linq;
using WebSiteHotel.Core.Models;

namespace WebSiteHotel.Core.Repositories
{
    public class Repository<T> where T : class
    {
        public HotelEntities DbContext { get; set; }
        public Repository()
        {
            DbContext = new HotelEntities();
        }

        private DbSet<T> DbSet()
        {
            return DbContext.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return DbSet();
        }

        public T Insert(T entity)
        {
            DbSet().Add(entity);
            DbContext.SaveChanges();
            return entity;
        }
    }
}
