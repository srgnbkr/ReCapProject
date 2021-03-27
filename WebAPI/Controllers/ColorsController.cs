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
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }
        [HttpGet("getallcolors")]
        public IActionResult GetAllColors()
        {
            var result = _colorService.GetAll();
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int id)
        {
            var result = _colorService.GetCarsByColorId(id);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult AddColors(Color color)
        {
            var result = _colorService.Add(color);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult DeleteColors(Color color)
        {
            var result = _colorService.Delete(color);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult UpdateColors(Color color)
        {
            var result = _colorService.Update(color);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }

    }
}
