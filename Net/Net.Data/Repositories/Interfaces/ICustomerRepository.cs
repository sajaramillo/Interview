using Net.Data.Abstractions.Interfaces;
using Net.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Data.Repositories.Interfaces
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
    }
}
