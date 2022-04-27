using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

/// <summary>
/// The Employee class provides methods for getters and setters to hold the information stored about each employee.
/// This means that the methods can be made public but the information remains private.  By setting the display name and validation 
/// rules in the employee class which is the basis for the model this results in keeping the code DRY.  
/// Every other class which uses Employee will inherit all of the below rules for each of the variables.
/// </summary>

namespace UWofS.CS7
{
  
   public class Employee
    {
        public int EmployeeID { get; set; }// getter and setter method for EmployeeID

        [Display(Name = "Last Name")]//will display the LastName variable as Last Name
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Last Name entered must be between 3 and 10 letters")]//Input validation checks that the user has entered between 3 and 10 characters.
        [Required]//Makes this variable required.
        public string LastName { get; set; }// getter and setter method for LastName

        [Display(Name = "First Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "First Name entered must be between 3 and 20 letters")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Job Title")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Job Title entered must be between 5 and 30 letters")]
        public string Title { get; set; }

        [Display(Name = "Title")]
        [RegularExpression(@"/^(Mr.)|(Ms.)|(Dr.)|(Sir.)|(Mrs.)|(Miss.)\.$/",
            ErrorMessage ="Please enter one of the following - Mr, Ms, Dr, Mrs, Miss, Sir")]//Input validaton checks that the user has only entered one of the accepted combinations of characters.
        public string TitleOfCourtesy { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public DateTime? HireDate { get; set; }

        [Display(Name = "Address")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Address entered must be between 5 and 60 letters")]
        public string Address { get; set;}

        [Display(Name = "City")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "City entered must be between 5 and 15 letters")]
        public string City { get; set; }

        [Display(Name = "Region")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Region entered must be between 2 and 15 letters")]
        public string Region { get; set; }

        [Display(Name = "Post Code")]
        [RegularExpression(@"(^[A-Z]{1,2}\d[A-Z\d]? ?\d[A-Z]{2}$)|(^\d{5}(?:[-\s]\d{4})?$)",
            ErrorMessage ="Please enter a correct UK/US Post/Zip Code")]//Input validation - checks that only a valid US or UK postcode will be accepted.
        public string PostalCode { get; set; }

        [Display(Name = "Country")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Country entered must be between 5 and 15 letters")]
        public string Country { get; set; }

        [Display(Name = "Contact Number")]
        [RegularExpression(@"(^[0-9]{11}$)|(^[0-9]{2}-[0-9]{3}-[0-9]{4}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)", 
            ErrorMessage =" You must enter a phone number in a the correct format ie 07xxxxxxxxx or 41-xxx-xxxx or 689-xxx-xxxx")]//Input validation - checks that only a valid phone number is entered b
        public string HomePhone { get; set; }

        [Display(Name = "Ext")]
        public string Extension { get; set; }

        [Display(Name = "Notes")]
        public string Notes { get; set; }

        [Display(Name = "Manager")]
        public int? ReportsTo { get; set; }

        public Employee Manager { get; set; }

        public ICollection<Order> Orders { get; set; }//Builds a collection of orders and contains methods to manipulate that collection

    }
}
