using Business.Abstract;
using Entity.Concrete;
using Grpc.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        IWebHostEnvironment _webHostEnvironment;

        public CarImagesController(ICarImageService carImageService, IWebHostEnvironment webHostEnvironment)
        {
            _carImageService = carImageService;
            _webHostEnvironment = webHostEnvironment;
        }

     

        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFileCollection getfiles, [FromForm] int carId)
        {
            var files = getfiles;//HttpContext.Request.Form.Files;
            var result = _carImageService.Add(files, carId);

            if (result.Succes)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }   

        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            if (result.Succes)
            {
                return Ok(result.Message);
            }
            return BadRequest("Başaramadık abi");

          // return Ok(carImage);

        }

        [HttpPost("update")]

        public IActionResult Update([FromForm] IFormFileCollection getfiles, [FromForm] int carId)
        {
            var files = getfiles;//HttpContext.Request.Form.Files;
            var result = _carImageService.Update(files, carId);

            if (result.Succes)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("images")]
        public IActionResult GetCarPicturesByCarId(CarImage carImage)
        {
            var result = _carImageService.GetCarPictureWithCarId(carImage);

            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
       
    }
}
