using Microsoft.AspNetCore.Mvc;
using Net.API.Exceptions;
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
        public async Task Create([FromBody] Customer customer)
        {
            try
            {

                await _unitOfWork.CustomerRepository.Insert(customer);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new CustomException(e.Message);
            }
        }

        [HttpGet]
        public async Task<Customer> Get([FromQuery] int id)
        {
            try
            {
                var result = await _unitOfWork.CustomerRepository.GetById(id);
                return result;

            }
            catch (Exception e)
            {
                throw new CustomException(e.Message);
            }
        }


        [HttpGet]
        public async Task<IEnumerable<Customer>> GetAll()
        {
            try
            {
                var result = await _unitOfWork.CustomerRepository.Get();
                return result;

            }
            catch (Exception e)
            {
                throw new CustomException(e.Message);
            }
        }

        [HttpPut]
        public async Task Edit([FromQuery]int id,[FromBody] Customer editRequest)
            //customer would be a request class and the values of the customer would be set in services layer
        {
            try
            {
                var customer = await _unitOfWork.CustomerRepository.GetById(id);
                _unitOfWork.CustomerRepository.Update(customer);
                await _unitOfWork.SaveChangesAsync();

            }
            catch (Exception e)
            {
                throw new CustomException(e.Message);
            }
        }

        [HttpDelete]
        public async Task Delete([FromQuery] int id)
        {
            try
            {
                var customer = await _unitOfWork.CustomerRepository.GetById(id);
                _unitOfWork.CustomerRepository.Remove(customer);
                await _unitOfWork.SaveChangesAsync();

            }
            catch (Exception e)
            {
                throw new CustomException(e.Message);
            }
        }

    }
}
