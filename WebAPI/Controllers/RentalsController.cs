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
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        [HttpGet("getrentdetail")]
        public IActionResult GetAllDetail()
        {
            var result = _rentalService.GetCarDetail();
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetAllRentals()
        {
            var result = _rentalService.GetAllRentCars();
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpGet("getrentdate")]
        public IActionResult GetRentDate(DateTime min,DateTime max)
        {
            var result = _rentalService.GetByRentDate(min,max);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
       [HttpPost("add")]
       public IActionResult AddRent(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult DeleteRent(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult UpdateRent(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
    }
}
