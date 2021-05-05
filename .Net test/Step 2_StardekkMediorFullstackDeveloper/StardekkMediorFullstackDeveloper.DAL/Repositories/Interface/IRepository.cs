using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.Repository.Interface
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        Task<List<TEntity>> GetAll();

        Task<bool> AddAsync(TEntity entity);

        Task<bool> UpdateAsync(TEntity entity);

        Task<TEntity> GetByIdAsync(int id);

        Task<bool> DeleteByIdAsync(int id);
    }
}
