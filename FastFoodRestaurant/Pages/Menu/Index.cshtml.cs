using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FastFoodRestaurant.Data;
using FastFoodRestaurant.Models;

namespace FastFoodRestaurant.Pages.Menu
{
    public class IndexModel : PageModel
    {
        private readonly FastFoodRestaurant.Data.FastFoodRestaurantContext _context;

        public IndexModel(FastFoodRestaurant.Data.FastFoodRestaurantContext context)
        {
            _context = context;
        }

        public IList<Food> Food { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Food = await _context.Food.ToListAsync();
        }
    }
}
