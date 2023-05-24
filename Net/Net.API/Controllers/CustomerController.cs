using Microsoft.AspNetCore.Mvc;
using Net.API.Infra;
using Net.Data;
using Net.Data.Abstractions.Interfaces;
using Net.Data.Entities;

namespace Net.API.Controllers
{
    [TypeFilter(typeof(CustomExceptionFilter))]
    [ApiController]
    [Route("[controller]")]
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

                await _unitOfWork.CustomerRepository.InsertAsync(customer);
                await _unitOfWork.SaveAsync();
            }
            catch (Exception e)
            {
                throw new BaseException(e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<Customer> Get([FromQuery] int id)
        {
            try
            {
                var result = await _unitOfWork.CustomerRepository.GetByIDAsync(id);
                return result;

            }
            catch (Exception e)
            {
                throw new BaseException(e.Message);
            }
        }


        [HttpGet]
        public async Task<IEnumerable<Customer>> GetAll()
        {
            try
            {
                var result = await _unitOfWork.CustomerRepository.GetAsync();
                return result;

            }
            catch (Exception e)
            {
                throw new BaseException(e.Message);
            }
        }

        [HttpPut]
        public async Task Edit([FromQuery] int id, [FromBody] Customer editRequest)
        //customer would be a request class and the values of the customer would be set in services layer
        {
            try
            {
                var customer = await _unitOfWork.CustomerRepository.GetByIDAsync(id);
                
                customer.Name = editRequest.Name;
                customer.LastName = editRequest.LastName;
                customer.Age = editRequest.Age;

                _unitOfWork.CustomerRepository.Update(customer);
                await _unitOfWork.SaveAsync();

            }
            catch (Exception e)
            {
                throw new BaseException(e.Message);
            }
        }

        [HttpDelete]
        public async Task Delete([FromQuery] int id)
        {
            try
            {
                var customer = await _unitOfWork.CustomerRepository.GetByIDAsync(id);
                _unitOfWork.CustomerRepository.Delete(customer);
                await _unitOfWork.SaveAsync();

            }
            catch (Exception e)
            {
                throw new BaseException(e.Message);
            }
        }

    }
}