using ECommerce.Contexts;
using ECommerce.Enums;
using ECommerce.Models;

namespace ECommerce.Data
{
    public class AppDbInitializer
    {
        // This method is used to seed (add) initial data into the database when the application starts.
        // It creates a temporary service scope to safely get the database context (ECommerceDbContext),
        // ensures the database is created, and then you can add your initial data inside it.
        public static void Seed(IApplicationBuilder Builder)
        {
                       using (var serviceScope = Builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ECommerceDbContext>();
                context.Database.EnsureCreated();

                // Add Categories
                if (!context.Categories.Any())
                {
                    var Categories = new List<Category>()
                    {
                        new Category
                        {
                            Name = "C1",
                            Description = "C1"

                        },

                        new Category
                        {
                            Name = "C2",
                            Description = "C2"
                        },

                        new Category
                        {
                            Name = "C3",
                            Description = "C3" 
                            
                        },
                    };

                    context.Categories.AddRange(Categories);
                    context.SaveChanges();
                    }

                // Add Products
                if (!context.Products.Any())
                {
                    var Products = new List<Product>()
                        {
                            new Product
                            {
                                Name = "P1",
                                Description = "P1",
                                Price = 1200,
                                ImageUrl = "/Images/t100-plus-purple--1000x1000.jpg",
                                ProductColor = ProductColor.Red,
                                CategoryId = 1
                            },

                            new Product
                            {
                                Name = "P2",
                                Description = "P2",
                                Price = 1350,
                                ImageUrl = "/Images/product_309525_product_shots1.jpg",
                                ProductColor = ProductColor.Green,
                                CategoryId = 2
                            },

                            new Product
                            {
                                Name = "P3",
                                Description = "P3",
                                Price = 1500,
                                ImageUrl = "/Images/S8-Ultra-Smart-Watch-Unique-Gadget-BD.jpg",
                                ProductColor = ProductColor.Yellow,
                                CategoryId = 3
                            },

                            new Product
                            {
                                Name = "P4",
                                Description = "P4",
                                Price = 2000,
                                ImageUrl = "/Images/s-l1600.jpg",
                                ProductColor = ProductColor.Black,
                                CategoryId = 2

                            }
                        };

                    context.Products.AddRange(Products);
                    context.SaveChanges();
                }
            }
        }
    }
}
