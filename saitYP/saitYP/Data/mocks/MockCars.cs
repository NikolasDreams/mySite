using saitYP.Data.interfaces;
using saitYP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saitYP.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();//указываем категоорию
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> {

                 new Car{name="Tesla Model 5",
                     shortDesc ="Быстрый автомобиль",
                     longDesc = "Красивый",
                     img ="https://www.zero2turbo.com/wp-content/uploads/2021/02/tesla-model-x.jpg",
                     price = 20000000,
                     isFavourite = true,
                     available =true,
                     Category =_categoryCars.AllCategories.First() },

                 new Car{name="Lamborghini Urus",
                     shortDesc ="Тихий спокойный",
                     longDesc = "Удобный для города",
                     img ="https://www.fonstola.ru/images/202009/fonstola.ru_407850.jpg",
                     price = 40000000,
                     isFavourite = false,
                     available =true,
                     Category =_categoryCars.AllCategories.Last() },

                 new Car{name="BMW x6",
                     shortDesc ="БСтильный",
                     longDesc = "Удобный для города",
                     img ="https://aybaz.ru/wp-content/uploads/a/a/0/aa0a7f27d524f40140473957e1362048.jpeg",
                     price = 13000000,
                     isFavourite = true,
                     available =true,
                     Category =_categoryCars.AllCategories.Last() },

                 new Car{name="Mercedes-AMG CLA 45",
                     shortDesc ="Уютный и большой",
                     longDesc = "Удобный для города",
                     img ="http://www.dragtimes.com/images/28870-2015-Mercedes-Benz-CLA45-AMG.jpg",
                     price = 7000000,
                     isFavourite = false,
                     available =false,
                     Category =_categoryCars.AllCategories.Last() },

                 new Car{name="Nissan Leaf",
                     shortDesc ="Бесшумный и экономный",
                     longDesc = "Удобный для города",
                     img ="https://avatars.dzeninfra.ru/get-zen_doc/3963198/pub_604f7655e781846a40e53fdd_604f76810a7d51654a059693/scale_1200",
                     price = 12000000,
                     isFavourite = true,
                     available =true,
                     Category =_categoryCars.AllCategories.First() }

                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
