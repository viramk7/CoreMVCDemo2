using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCDemo2.Services.City
{
    public interface ICityService
    {
        List<Models.City> GetCities();
    }
}
