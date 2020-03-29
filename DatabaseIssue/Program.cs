using DatabaseIssue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseIssue
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ProductCategoryContext())
            {

                var product1 = new Product
                {
                    ProductName = "product1",
                };
                var product2 = new Product
                {
                    ProductName = "product2",
                };
                var category1 = new Category
                {
                    CategoryName = "category1",
                };
                var category2 = new Category
                {
                    CategoryName = "category2",
                };
                var productCategory1 = new ProductCategory
                {
                    Product = product1,
                    Category = category2
                };
                var productCategory2 = new ProductCategory
                {
                    Product = product2
                };
                db.Products.Add(product1);
                db.Products.Add(product2);
                db.Categories.Add(category1);
                db.Categories.Add(category2);
                db.ProductCategories.Add(productCategory1);
                db.ProductCategories.Add(productCategory2);
                db.SaveChanges();
            }
        }
    }
}
