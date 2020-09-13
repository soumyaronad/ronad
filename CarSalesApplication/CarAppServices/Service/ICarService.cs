using CarSalesApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApplication.CarAppServices.Service
{
    public interface ICarService
    {
        Task<bool> AddNewCar(CreateCarViewModel car);
    }
}
