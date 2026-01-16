using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FastFoodRestaurant.Models;

namespace FastFoodRestaurant.Data
{
    public class FastFoodRestaurantContext : DbContext
    {
        public FastFoodRestaurantContext (DbContextOptions<FastFoodRestaurantContext> options)
            : base(options)
        {
        }

        public DbSet<FastFoodRestaurant.Models.Food> Food { get; set; } = default!;
        public DbSet<FastFoodRestaurant.Models.Order> Order { get; set; } = default!;
    }
}
