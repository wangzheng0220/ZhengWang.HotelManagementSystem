using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HotelManagementSystem.Core.RepositoryInterfaces;
using HotelManagementSystem.Infrastructure.Data;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Linq;

namespace HotelManagementSystem.Infrastructure.Repositories
{
    public class EfRepository<T>: IAsyncRepository<T> where T: class
    {
        protected readonly HotelManagementSystemDbContext _dbContext; // constructor injection
        public EfRepository(HotelManagementSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbContext.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<int> GetCountAsync(Expression<Func<T, bool>> filter = null)
        {
            if (filter != null)
            {
                return await _dbContext.Set<T>().Where(filter).CountAsync();
            }
            return await _dbContext.Set<T>().CountAsync();
        }

        public async Task<bool> GetExistsAsync(Expression<Func<T, bool>> filter = null)
        {
            return filter != null && await _dbContext.Set<T>().Where(filter).AnyAsync();
        }


        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<T> UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
