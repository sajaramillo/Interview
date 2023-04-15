using Net.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Data
{
    public interface IUnitOfWork
    {
        IRepository<Customer> customerRepository { get; }
        Task SaveChangesAsync();
    }
}
