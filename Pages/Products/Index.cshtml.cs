using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Colton_Aycock_Final_Project.Models;

namespace Colton_Aycock_Final_Project.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Colton_Aycock_Final_Project.Models.ProductDbContext _context;

        public IndexModel(Colton_Aycock_Final_Project.Models.ProductDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}

