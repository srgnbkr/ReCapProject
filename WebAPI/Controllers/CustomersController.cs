using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("getall")]
        public IActionResult GetAllCustomers()
        {
            var result = _customerService.GetAllCustomers();
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpGet("getname")]
        public IActionResult GetName(string key)
        {
            var result = _customerService.GetByCompanyName(key);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult AddCustomers(Customer customer)
        {
            var result = _customerService.Add(customer);
            if(result.Success) { return Ok(result); }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult DeleteCustomers(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult UpdateCustomers(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }

        [HttpGet("getcustomerdetail")]
        public IActionResult GetDetail()
        {
            var result = _customerService.GetCustomerDetails();
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }


    }
}
