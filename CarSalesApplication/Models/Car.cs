using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApplication.Models
{
    public class Car : Vehicle 
    {
        public string BodyType { get; set; }

        public string carType { get; set; }

        public string Badge { get; set; }

        public string Color { get; set; }

    }
}
