using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Builds a model of the entity classes used in the application
/// </summary>
namespace UWofS.CS7
{
    public class HomeIndexViewModel
    {
        public int VisitorCount;
        public IList<Category> Categories { get; set; }//puts Category entities into an abstract list of the objects categories
        public IList<Product> Products { get; set; }
        public IList<Employee>Employees { get; set; }
    }
}
