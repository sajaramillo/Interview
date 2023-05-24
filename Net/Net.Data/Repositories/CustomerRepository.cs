using Microsoft.EntityFrameworkCore;
using Net.Data.Abstractions;
using Net.Data.Abstractions.Interfaces;
using Net.Data.Entities;
using Net.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Data.Repositories
{
    public class CustomerRepository<TDbContext> : GenericRepository<Customer, TDbContext>, ICustomerRepository where TDbContext : DbContext
    {
        public CustomerRepository(TDbContext context) : base(context)
        {

        }
    }
}
