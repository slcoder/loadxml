namespace ProductModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductModel.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductModel.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Products.AddOrUpdate(
              p => p.ProductName,
              new Product { ProductName = "Visual Studio 2017 development pack", ProductCost = 100, Quantity = 3000, ProductImageFullUrl = "https://www.smashingmagazine.com/wp-content/uploads/2015/06/10-dithering-opt.jpg" },
              new Product { ProductName = "isual Studio 2015 development pack", ProductCost = 85, Quantity = 2500, ProductImageFullUrl = "https://3.bp.blogspot.com/-W__wiaHUjwI/Vt3Grd8df0I/AAAAAAAAA78/7xqUNj8ujtY/s1600/image02.png" },
              new Product { ProductName = "Dell inspiron i5", ProductCost = 150, Quantity = 50, ProductImageFullUrl = "https://3.bp.blogspot.com/-W__wiaHUjwI/Vt3Grd8df0I/AAAAAAAAA78/7xqUNj8ujtY/s1600/image02.png" }
            );
            context.SaveChanges();
        }
    }
}
