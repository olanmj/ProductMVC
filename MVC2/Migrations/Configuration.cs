namespace MVC2.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC2.Models.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVC2.Models.ProductContext";
        }

        protected override void Seed(MVC2.Models.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );

            context.Products.AddOrUpdate(
                p => p.Name,
                new Product { Name = "Widget", Description = "Medium widget", Price = 50, Category = "Hardware" },
                new Product { Name = "Hammer", Description = "For pounding nails", Price = 15, Category = "Hardware" },
                new Product { Name = "Lawn Mower", Description = "For cutting grass", Price = 250, Category = "Power Tools" }
                );
        }
    }
}
