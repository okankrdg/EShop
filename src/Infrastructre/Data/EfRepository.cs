using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructre.Data
{
    public class EfRepository<T> : IAsyncRepository<T> where T:BaseEntity
    {
        private readonly ShopContext _dbcontext;

        public EfRepository(ShopContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _dbcontext.Set<T>().ToListAsync();
        }
    }
}
