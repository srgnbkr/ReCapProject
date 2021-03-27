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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("getallbrands")]
        public IActionResult GetAllBrands()
        {
            var result = _brandService.GetAll();
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetByBrandId(int id)
        {
            var result = _brandService.GetCarsByBrandId(id);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult AddBrands(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult DeleteBrands(Brand brand)
        {
            var result = _brandService.Delete(brand);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult UpdateBrands(Brand brand)
        {
            var result = _brandService.Update(brand);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }

    }
}
