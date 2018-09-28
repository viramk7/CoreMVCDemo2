using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCDemo2.Models;

namespace CoreMVCDemo2.Services.City
{
    public class CityService : ICityService
    {
        public List<Models.City> GetCities()
        {
            return new List<Models.City>
            {
                new Models.City { CityId = 1,CityName ="Ahmedabad"},
                new Models.City { CityId = 2,CityName ="Pune"},
            };
        }
    }
}
