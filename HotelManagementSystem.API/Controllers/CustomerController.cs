using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagementSystem.Core.Entities;
using HotelManagementSystem.Core.RepositoryInterfaces;
using HotelManagementSystem.Core.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerRepository _CustomerRepository;
        

        public CustomerController(ICustomerService customerService, ICustomerRepository customerRepository)

        {
            _customerService = customerService;
            _CustomerRepository = customerRepository;
        }

        [HttpPost]
        [Route("AddCustomer")]
        public async Task<IActionResult> AddCustomer([FromBody] Customer customer)
        {
            var customerAdded = await _customerService.AddCustomer(customer);
            return Ok(customerAdded);
        }

        [HttpGet]
        [Route("customers")]
        public async Task<IActionResult> ListAllCustomer()
        {
            var allCustomer = await _customerService.GetAllCustomers();
            return Ok(allCustomer);
        }

        [HttpGet]
        [Route("{customerId:int}")]
        public async Task<IActionResult> ListCustomerDetails(int customerId)
        {
            var getCustDetails = await _CustomerRepository.GetByIdAsync(customerId);
            return Ok(getCustDetails);
        }

    }
}
