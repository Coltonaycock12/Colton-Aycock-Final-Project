using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Colton_Aycock_Final_Project.Models;
using System.Drawing;

namespace Colton_Aycock_Final_Project.Models 
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) 
        {
            using (var context = new ProductDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ProductDbContext>>()))
                {
                    if (context == null || context.Products == null)
                    {
                        throw new ArgumentNullException("Null RazorPagesProductDbContext");
                    }

                    //Look for any products.
                    if (context.Products.Any())
                    {
                        return; //DB has been seeded
                    }

                  context.Products.AddRange(
                        new Product{
                            Name= "Nike React Infinity Run 3",
                            Size= 8,
                            Gender= "Mens",
                            Price= 159.99M 
                        },

                        new Product{
                          Name= "Nike Pegasus 40",
                            Size= 9,
                            Gender= "Mens",
                            Price= 139.99M
                        },

                        new Product{
                            Name= "Brooks Adrenaline GTS 22",
                            Size= 6,
                            Gender= "Womens",
                            Price= 140.00M
                        },

                        new Product{
                            Name= "Brooks Ghost 15",
                            Size= 10,
                            Gender= "Mens",
                            Price= 139.95M
                        },

                        new Product{
                            Name= "Adidas Solar Boost 5",
                            Size= 11,
                            Gender= "Mens",
                            Price= 160.00M
                        },

                        new Product{
                            Name= "New Balance Fresh Foam X 1080 v13",
                            Size= 7,
                            Gender= "Womens",
                            Price= 164.95M
                        },

                        new Product{
                            Name= "HOKA Mach 5",
                            Size= 8,
                            Gender= "Womens",
                            Price= 139.95M
                        },

                        new Product{
                            Name= "Saucony Endorphin Speed 3",
                            Size= 9,
                            Gender= "Womens",
                            Price= 169.95M,
                        },

                        new Product{
                            Name= "Asics Gel Nimbus 25",
                            Size= 10,
                            Gender= "Womens",
                            Price= 160.00M
                        },

                        new Product{
                            Name= "Hoka Clifton 9",
                            Size= 12,
                            Gender= "Mens",
                            Price= 144.95M
                        },

                        new Product{
                            Name= "Saucony Kinvara Pro",
                            Size= 9,
                            Gender= "Mens",
                            Price= 179.95M
                        },

                        new Product{
                            Name= "Altra Torin 7",
                            Size= 7,
                            Gender= "Mens",
                            Price= 149.95M 
                        },

                        new Product{
                            Name= "Adidas Adizero Boston 12",
                            Size= 8,
                            Gender= "Mens",
                            Price= 159.95M
                        },

                        new Product{
                            Name= "Adidas Adizero Takumi Sen 9",
                            Size= 11,
                            Gender= "Womens",
                            Price= 179.95M
                        },

                        new Product{
                            Name= "Adidas Adizero SL",
                            Size= 6,
                            Gender= "Womens",
                            Price= 119.95M
                        },

                        new Product{
                            Name= "Nike Vaporfly Next% 3",
                            Size= 9,
                            Gender= "Mens",
                            Price= 259.95M
                        },

                        new Product{
                            Name= "Nike ZoomX Dragonfly",
                            Size= 9,
                            Gender= "Mens",
                            Price= 159.95M
                        },

                        new Product{
                            Name= "ASICS Novablast 3",
                            Size= 11,
                            Gender= "Mens",
                            Price= 140.00M
                        },

                        new Product{
                            Name= "Brooks Adrenaline GTS 23",
                            Size= 10,
                            Gender= "Mens",
                            Price= 139.95M
                        },

                        new Product{
                            Name= "Nike ZoomX Dragonfly XC Spikes",
                            Size= 10,
                            Gender= "Womens",
                            Price= 149.95M
                        },

                        new Product{
                            Name= "Nike Zoom Superfly Elite 2 Spikes",
                            Size= 6,
                            Gender= "Mens",
                            Price= 159.95M
                        },

                        new Product{
                            Name= "ASICS HyperSprint 8 Spikes",
                            Size= 7,
                            Gender= "Mens",
                            Price= 84.95M
                        },

                        new Product{
                            Name= "Adidas Adizero Finesse Spikes",
                            Size= 8,
                            Gender= "Womens",
                            Price= 129.95M
                        },

                        new Product{
                            Name= "ASICS Metasprint Spikes",
                            Size= 13,
                            Gender= "Womens",
                            Price= 200.00M
                        },

                        new Product{
                            Name= "Nike Wildhorse 8",
                            Size= 10,
                            Gender= "Womens",
                            Price= 139.95M
                        }
                    );

                    context.SaveChanges();
                }
            
        }
    }
}
