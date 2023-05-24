using Net.Data.Abstractions.Interfaces;
using Net.Data.Entities;
using Net.Data.Repositories;
using Net.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Data.Abstractions
{
    public class UnitOfWork : IUnitOfWork
    {
        private InterviewDbContext _Context;
        private ICustomerRepository _CustomerRepository;

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_CustomerRepository == null)
                {
                    _CustomerRepository = new CustomerRepository<InterviewDbContext>(_Context);
                }

                return _CustomerRepository;
            }
        }

        public UnitOfWork(InterviewDbContext context)
        {
            _Context = context;
        }

        public void Save()
        {
            _Context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _Context.SaveChangesAsync();
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
