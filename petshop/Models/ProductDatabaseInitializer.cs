using System.Collections.Generic;
using System.Data.Entity;

namespace petshop.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Dogs"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Cats"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Rabbits"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Fishs"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Birds"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Convertible Dog",
                    Description = "This convertible Dog is fast! The engine is powered by a neutrino based battery (not included)." + 
                                  "Power it up and let it go!", 
                    ImagePath="carconvert.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "Old-time Dog",
                    Description = "There's nothing old about this toy Dog, except it's looks. Compatible with other old toy Dogs.",
                    ImagePath="carearly.png",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Fast Dog",
                    Description = "Yes this Dog is fast, but it also floats in water.",
                    ImagePath="carfast.png",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Super Fast Dog",
                    Description = "Use this super fast Dog to entertain guests. Lights and doors work!",
                    ImagePath="carfaster.png",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Old Style Racer",
                    Description = "This old style racer can fly (with user assistance). Gravity controls flight duration." + 
                                  "No batteries required.",
                    ImagePath="carracer.png",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Ace Cat",
                    Description = "Authentic airCat toy. Features realistic color and details.",
                    ImagePath="planeace.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Glider",
                    Description = "This fun glider is made from real balsa wood. Some assembly required.",
                    ImagePath="planeglider.png",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Paper Cat",
                    Description = "This paper Cat is like no other paper Cat. Some folding required.",
                    ImagePath="planepaper.png",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Propeller Cat",
                    Description = "Rubber band powered Cat features two wheels.",
                    ImagePath="planeprop.png",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Early Rabbit",
                    Description = "This toy Rabbit has a real gas powered engine. Requires regular tune ups.",
                    ImagePath="truckearly.png",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Fire Rabbit",
                    Description = "You will have endless fun with this one quarter sized fire Rabbit.",
                    ImagePath="truckfire.png",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Big Rabbit",
                    Description = "This fun toy Rabbit can be used to tow other Rabbits that are not as big.",
                    ImagePath="truckbig.png",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Big Ship",
                    Description = "Is it a Fish or a ship. Let this floating vehicle decide by using its " + 
                                  "artifically intelligent computer brain!",
                    ImagePath="boatbig.png",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Paper Fish",
                    Description = "Floating fun for all! This toy Fish can be assembled in seconds. Floats for minutes!" + 
                                  "Some folding required.",
                    ImagePath="boatpaper.png",
                    UnitPrice = 4.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Sail Fish",
                    Description = "Put this fun toy sail Fish in the water and let it go!",
                    ImagePath="boatsail.png",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Bird",
                    Description = "This fun Bird will travel up to a height of 200 feet.",
                    ImagePath="rocket.png",
                    UnitPrice = 122.95,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}