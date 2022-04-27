using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UWofS.CS7;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

/// <summary>
/// The HomeController class handles all browser requests from any views connected to Employees.  They take the data from NorthwindDB which 
/// is the data Model and then call the respective views to return a response.  Any user input and interaction is handled by this controller.
/// </summary>

namespace WebApp1.Controllers
{


    public class EmployeesController : Controller
    {
        //initialises the model which is NorthwindDB and passes it to the controller.

        private readonly NorthwindDB _context;

        public EmployeesController(NorthwindDB context)
        {
            _context = context;
        }

        // GET method it returns the employees view index
        
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();// puts all objects of employee into a list and stores them in a new object employees.
            return View(employees); //returns an updated view 
        }


        // GET: method returns Employees/Details/ and what record has been selected based on the employeesID 
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest(); // if no id is entered then returns 400 Bad Request
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.EmployeeID == id);// Asynchronously returns element based on the id selected
            if (employee == null)
            {
                return NotFound();// Returns 404 Not Found if no record matches
            }

            return View(employee);// Returns an updated view
        }

    }
}
