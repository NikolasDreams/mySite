using saitYP.Data.interfaces;
using saitYP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saitYP.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories 
        {
            get
            {
                return new List<Category> {
                    new Category {categoryName = "Электромобили", desc= "Совреенный вид транспорта"},
                    new Category {categoryName = "Классические автомобили", desc= "Машины с двигателем внетреннего згорания"}
                };
            }
        }
    }
}
