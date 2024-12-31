using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    // Class only intented to do the saving of changes inside the in memory database.
    internal sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _dbContext;

        public UnitOfWork(ApplicationDBContext context)
        {
            _dbContext = context;
        }

        public async Task<int> SaveChangesAsync()
        {
          return await _dbContext.SaveChangesAsync();
        }

    }
}
