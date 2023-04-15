using Microsoft.EntityFrameworkCore;
using Net.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        
        public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        } 


        //public async Task<Customer> GetById(int id) 
        //{
        //    return await _dbContext.Customers.FindAsync(id);
        //}

        //public async Task<IEnumerable<Customer>> Get()
        //{
        //    return await _dbContext.Customers.ToListAsync();
        //}

        //public async Task Insert(Customer customer)
        //{
        //    await _dbContext.Customers.AddAsync(customer);
        //    await _dbContext.SaveChangesAsync();
        //}

        //public async Task Update(Customer customer)
        //{
        //    _dbContext.Entry(customer).State = EntityState.Modified;
        //    await _dbContext.SaveChangesAsync();
        //}

        //public async Task Delete(Customer customer)
        //{
        //    _dbContext.Customers.Remove(customer);
        //    await _dbContext.SaveChangesAsync();
        //}
    }
}
