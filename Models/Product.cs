using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// The Employee class provides methods for getters and setters to hold the information stored about each employee.
/// This means that the methods can be made public but the information remains private.  
/// </summary>

namespace UWofS.CS7

{
    public class Product
    {
        public int ProductID { get; set; }//getter and setter method for ProductID
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public Supplier Supplier { get; set; }
        public int? CategoryID { get; set; }
        public Category Category { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; } = 0;
        public short? UnitsInStock { get; set; } = 0;
        public short? UnitsOnOrder { get; set; } = 0;
        public short? ReorderLevel { get; set; } = 0;
        public bool Discontinued { get; set; } = false;
    }
}
