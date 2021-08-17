using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<string> cities = new List<string> {"Baku", "Moskow", "Manhattan" };
            List<Employers> employers = new List<Employers>
            {
                new Employers{Id=1,Name="Bob",Surname="Bob",Department="IT"},
                new Employers{Id=2,Name="Alex",Surname="Alex",Department="IT"},
                new Employers{Id=3,Name="Emma",Surname="Emma",Department="IT"},
                new Employers{Id=4,Name="Jhon",Surname="Jhon",Department="IT"},
            };

            HomeViewModel model = new HomeViewModel
            {
                employers = employers,
                Cities = cities

            };

            return View(employers);
        }
    }
}
