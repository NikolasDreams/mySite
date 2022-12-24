using saitYP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saitYP.Data.interfaces
{
   public interface IAllCars
    {
        //возращает все товар
        IEnumerable<Car> Cars { get; }
        //возращает избранные
        IEnumerable<Car> getFavCars { get; set; }
        //возращает по ID
        Car getObjectCar(int CarID);
    }
}
