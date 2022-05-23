using CarOLiner.Shared.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Data.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        /// <summary>
        /// General Db functions for all classes
        /// </summary>
        protected readonly CarOLineDbContext _carOLineDbContext;

        public BaseRepository(CarOLineDbContext carOLineDbContext)
        {
            _carOLineDbContext = carOLineDbContext;
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _carOLineDbContext.Set<T>().FindAsync(id);
        }

        /// <summary>
        /// Returns list of all the objects of one type
        /// </summary>
        /// <returns></returns>
        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _carOLineDbContext.Set<T>().ToListAsync();
        }



        public async Task<T> AddAsync(T entity)
        {
            await _carOLineDbContext.Set<T>().AddAsync(entity);
            await _carOLineDbContext.SaveChangesAsync();

            return entity;
        }

        public T Add(T entity)
        {
            _carOLineDbContext.Set<T>().Add(entity);
            _carOLineDbContext.SaveChanges();

            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _carOLineDbContext.Set<T>().AddRangeAsync(entities);
            await _carOLineDbContext.SaveChangesAsync();

            return entities;
        }

        public async Task UpdateAsync(T entity)
        {
            _carOLineDbContext.Update(entity).State = EntityState.Modified;
            await _carOLineDbContext.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            _carOLineDbContext.UpdateRange(entities);
            await _carOLineDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _carOLineDbContext.Set<T>().Remove(entity);
            await _carOLineDbContext.SaveChangesAsync();
        }
    }
}
