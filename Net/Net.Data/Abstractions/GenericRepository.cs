using Microsoft.EntityFrameworkCore;
using Net.Data.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Net.Data.Abstractions
{
    public class GenericRepository<TEntity, TDbContext> : IGenericRepository<TEntity> where TEntity : class where TDbContext : DbContext, IDisposable
    {
        protected TDbContext _Context;
        protected DbSet<TEntity> _DbSet;

        
        public GenericRepository(TDbContext context)
        {
            this._Context = context;
            this._DbSet = _Context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get()
        {
            return _DbSet.ToList();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync()
        {
            return await _DbSet.ToListAsync();
        }


        public virtual TEntity? GetByID(object id)
        {
            return _DbSet.Find(id);
        }

        public virtual async Task<TEntity?> GetByIDAsync(object id)
        {
            return await _DbSet.FindAsync(id);
        }


        public virtual async Task InsertAsync(TEntity entity)
        {
           await _DbSet.AddAsync(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = _DbSet.Find(id);
            Delete(entityToDelete);
        }

        private void Delete(TEntity entityToDelete)
        {
            if (_Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _DbSet.Attach(entityToDelete);
            }
            _DbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            _DbSet.Attach(entityToUpdate);
            _Context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        #region Dispose 

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _Context?.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
