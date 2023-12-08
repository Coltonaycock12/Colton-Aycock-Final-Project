using Colton_Aycock_Final_Project.Pages;
using Microsoft.EntityFrameworkCore;

namespace Colton_Aycock_Final_Project.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext (DbContextOptions<ProductDbContext> options) 
                :base(options)
    {
    }

    public DbSet<Product> Products {get; set;} = default!;
    }
}

