using Microsoft.AspNetCore.Mvc;
using saitYP.Data.interfaces;
using saitYP.Data.Models;
using saitYP.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saitYP.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        //обращаемся к интерфейсу вместе с его классом
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)//передаем интерфей и его класс реализации
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }
        //возращает html страницу
        public ViewResult List(string category)
        {
            string _category = category;       
            ViewBag.title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
            //ViewBag.title = "Страница с автомобилями";
            ////CarsListViewModel obj = new CarsListViewModel();
            //obj.allCars = _allCars.Cars;
            //obj.currCategory = "Автомобили";


        }
    }
}
