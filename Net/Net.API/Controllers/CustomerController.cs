using Microsoft.AspNetCore.Mvc;
using Net.Data;
using Net.Data.Entities;

namespace Net.API.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }

        [HttpPost]
        public async Task Create([FromBody]Customer customer)
        {
            try
            {

                await _unitOfWork.customerRepository.Insert(customer);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }

    }
}
