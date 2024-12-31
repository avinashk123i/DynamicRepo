using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{

    // We are marking all the class implementation as internal so they can be accessed inside their particular assembly only since we are strictly
    // following the onion architecture all the outer layer should have the implementation for the interfaces and can only go down one layer so it
    // only depends upon the lower level rather that is domain layer.
    // this layer contains all the external implementation and it sits at the same layer as presentation layer unlike the n layered architecture.
    
    internal abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        

        private readonly ApplicationDBContext _dbContext;

        public BaseRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(T Entity)
        {
            _dbContext.Set<T>().Add(Entity);
        }

        public void Delete(T Entity)
        {
            _dbContext.Set<T>().Remove(Entity);
        }

        public IQueryable<T> GetAll()
        {

            // using set (for all other as well) since we do not know what type is being referred here it is going to come at the runtime only.
            return _dbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T Entity)
        {
             _dbContext.Set<T>().Update(Entity);
        }
    }
}
