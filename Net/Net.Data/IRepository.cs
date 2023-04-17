using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Net.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> Get();
        Task Insert(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
            
    }
}