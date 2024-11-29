namespace NimapMachineTestSolution.Migrations
{
    using NimapMachineTestSolution.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            // Add initial categories
            context.Categories.AddOrUpdate(
                c => c.CategoryName,
                new Category { CategoryName = "Electronics" },
                new Category { CategoryName = "Clothing" }
            );

            // Save changes
            context.SaveChanges();

            // Add initial products
            context.Products.AddOrUpdate(
                p => p.ProductName,
                new Product { ProductName = "Mobile Phone", CategoryId = 1 },
                new Product { ProductName = "Jeans", CategoryId = 2 }
            );

            context.SaveChanges();

        }
        }
    }
