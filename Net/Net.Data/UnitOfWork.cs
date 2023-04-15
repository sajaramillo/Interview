using Microsoft.EntityFrameworkCore;
using Net.Data.Entities;
using Net.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IRepository<Customer> customerRepository { get; }
        public UnitOfWork(ApplicationDbContext context,IRepository<Customer> customerRepository)
        {
            _context = context;
             this.customerRepository = customerRepository;
        }

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();


        



    }
}
