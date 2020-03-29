using System;
using System.Collections.Generic;

namespace DatabaseIssue.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public virtual List<ProductCategory> ProductCategories { get; set; }
        public Product()
        {
            ProductCategories = new List<ProductCategory>();
        }
    }
}
