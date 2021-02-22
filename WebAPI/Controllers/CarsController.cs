﻿using Business.Abstract;
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
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        
        
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
                    
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success) { return Ok(result.Message); }
            return BadRequest(result);
        }
        [HttpGet("getcardetail")]
        public IActionResult GetDetail()
        {
            var result = _carService.GetCarDetailDetails();
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }
        [HttpGet("getbymodelyear")]
        public IActionResult GetByModelYear(int year)
        {
            var result = _carService.GetByModelYear(year);
            if (result.Success) { return Ok(result); }
            return BadRequest(result);


        }
        [HttpGet("getbydailyprice")]
        public IActionResult GetByDailyprice(decimal min,decimal max)
        {
            var result = _carService.GetByDailyPrice(min,max);
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }
        
        
    }
}
