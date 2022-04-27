using System.Collections.Generic;

/// <summary>
/// The Category class provides methods for getters and setters to hold the information stored about each category.
/// This means that the methods can be made public but the information remains private. 
/// </summary>

namespace UWofS.CS7
{
    public class Category
    {
        public int CategoryID { get; set; }//getter and setter method for categoryID
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }//Builds a collection of Products and contains methods to manipulate that collection.


    }
}

