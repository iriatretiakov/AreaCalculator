using System;
using System.Collections.Generic;

namespace DatabaseIssue.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual List<ProductCategory> ProductCategories { get; set; }

        public Category()
        {
            ProductCategories = new List<ProductCategory>();
        }
    }
}
