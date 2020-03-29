using DatabaseIssue.Models;
using System.Data.Entity;

namespace DatabaseIssue
{
    public class ProductCategoryContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasOptional(x => x.Category)
                .WithMany(x => x.ProductCategories)
                .HasForeignKey(x => x.CategoryId);
            
            modelBuilder.Entity<ProductCategory>()
                .HasOptional(x => x.Product)
                .WithMany(x => x.ProductCategories)
                .HasForeignKey(x => x.ProductId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
