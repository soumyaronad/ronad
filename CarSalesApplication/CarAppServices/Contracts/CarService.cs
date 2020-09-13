using CarSalesApplication.DataPersistance.Contracts;
using CarSalesApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApplication.CarAppServices.Contracts
{
    public class CarService
    {
        private readonly IRepository _dataRepository;


        public CarService(IRepository repository)
        {
            _dataRepository = repository;
        }

        public async Task<bool> AddNewCar(CreateCarViewModel newCar)
        {
            Car car = new Car();
            try
            {
                if (newCar != null)
                {
                    car.Make = newCar.Make;
                    car.Model = newCar.Model;
                    car.VehicleType = VehicleTypes.Car;
                    car.BodyType = newCar.BodyType;
                    car.Badge = newCar.Badge;
                    car.Color = newCar.Badge;
                    car.Condition = newCar.Badge;
                    car.carType = newCar.carType;


                    await _dataRepository.CreateCar(car);
                    return true;
                }

                return false;
            }


            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
