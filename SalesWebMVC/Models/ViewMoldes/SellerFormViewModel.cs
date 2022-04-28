using System;
using System.Collections.Generic;
using System.Linq;


namespace SalesWebMVC.Models.ViewMoldes
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
