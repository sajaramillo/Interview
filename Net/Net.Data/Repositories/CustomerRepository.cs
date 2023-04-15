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
   }
}
