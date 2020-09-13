using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApplication.CarAppServices.Service;
using CarSalesApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarSalesApplication.Controllers
{
    public class CarController : Controller

    {

        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<IActionResult> CreateNewCar([FromBody]CreateCarViewModel carData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Json(new { IsSuccess = false, Message = "Parameter can not be null" });
                }

                bool result = await _carService.AddNewCar(carData);

                return Json(new { IsSuccess = true, Message = "Car Added Successfully" });
            }
            catch (ApplicationException e)
            {
                return Json(new { IsSuccess = false, e.Message });
            }
        }
    }
}