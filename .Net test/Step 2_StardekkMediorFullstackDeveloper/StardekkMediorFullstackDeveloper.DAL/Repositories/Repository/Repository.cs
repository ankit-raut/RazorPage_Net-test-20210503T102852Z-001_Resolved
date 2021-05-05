using Microsoft.EntityFrameworkCore;
using StardekkMediorFullstackDeveloper.DAL;
using StardekkMediorFullstackDeveloper.Repository.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.Model.Repositories.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly StardekkDatabaseContext _stardekkDatabaseContext;

        public Repository(StardekkDatabaseContext stardekkDatabaseContext)
        {
            _stardekkDatabaseContext = stardekkDatabaseContext;
        }

        public Task<List<TEntity>> GetAll()
        {
            try
            {
                return _stardekkDatabaseContext.Set<TEntity>().AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<bool> AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await _stardekkDatabaseContext.AddAsync(entity);
                await _stardekkDatabaseContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                _stardekkDatabaseContext.Update(entity);
                await _stardekkDatabaseContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException($"{nameof(GetByIdAsync)} Id must not be null or Zero");
            }
            try
            {
                return await _stardekkDatabaseContext.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(TEntity)} could not be updated: {ex.Message}");
            }
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException($"{nameof(DeleteByIdAsync)} Id must not be null or Zero");
            }
            try
            {
                var entity = await GetByIdAsync(id);
                _stardekkDatabaseContext.Remove<TEntity>(entity);
                await _stardekkDatabaseContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(TEntity)} could not be delete: {ex.Message}");
            }
        }

    }
}
