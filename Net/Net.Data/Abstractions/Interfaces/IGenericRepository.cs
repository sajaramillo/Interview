using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Net.Data.Abstractions.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get();
        Task<IEnumerable<TEntity>> GetAsync();

        TEntity? GetByID(object id);
        Task<TEntity?> GetByIDAsync(object id);

        Task InsertAsync(TEntity entity);
        void Update(TEntity entityToUpdate);
        void Delete(object id);
    }
}
