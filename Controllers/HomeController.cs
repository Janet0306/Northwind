using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;

/// <summary>
/// The HomeController class handles all browser requests from any views connected to Home/index.  They take the data from NorthwindDB which 
/// is the data Model and then call the respective views to return a response.  Any user input and interaction is handled by this controller.
/// </summary>

namespace UWofS.CS7
{

    public class HomeController : Controller
    {
        //initialises the model which is NorthwindDB and passes it to the controller.

        private readonly NorthwindDB _context;

        public HomeController(NorthwindDB context)
        {
            _context = context;
        }

        //IActionReult is how the server should respond.  In this case it loads the data from the HomeIndexViewModel and passes it to a new object 
        //model.  Then performs calculations by adding products to a list and categories to a list and loading a new random int for VisitorCount.
        //This is then passed to the view.
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel
            {
                VisitorCount = (new Random()).Next(1, 1001),//generates a random int
                Categories = _context.Categories.ToList(),//loads catogries into a new list
                Products = _context.Products.ToList(),//loads products into a new list
               
            };
            return View(model);//returns an updated view.
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
