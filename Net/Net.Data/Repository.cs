using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Net.Data
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public async Task<TEntity> GetById(int id) => await _dbSet.FindAsync(id);
        public async Task<IEnumerable<TEntity>> Get() => await _dbSet.ToListAsync();
        public async Task Insert(TEntity entity) => await _dbSet.AddAsync(entity);
        public void Update(TEntity entity) => _dbSet.Update(entity);
        public void Remove(TEntity entity) => _dbSet.Remove(entity);
        

    }
}
