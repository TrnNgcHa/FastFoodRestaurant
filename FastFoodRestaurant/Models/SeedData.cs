using Microsoft.EntityFrameworkCore;
using FastFoodRestaurant.Data;

namespace FastFoodRestaurant.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new FastFoodRestaurantContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<FastFoodRestaurantContext>>()))
        {
            if (context == null || context.Food == null)
            {
                throw new ArgumentNullException("Null FastFoodRestaurantContext");
            }

            // Look for any foods.
            if (context.Food.Any())
            {
                return;   // DB has been seeded
            }

            context.Food.AddRange(
                new Food
                {
                    Name = "Cheeseburger",
                    Price = 30000,
                    Category = "Burger",
                    Description = "A delicious cheeseburger with all the fixings.",
                    ImageURL = "https://example.com/images/cheeseburger.jpg",
                    Calories = 750,
                    Protein = 40,
                    Fat = 45
                },

                new Food
                {
                    Name = "Veggie Pizza",
                    Price = 80000,
                    Category = "Pizza",
                    Description = "A healthy veggie pizza loaded with fresh vegetables.",
                    ImageURL = "https://example.com/images/veggie_pizza.jpg",
                    Calories = 600,
                    Protein = 20,
                    Fat = 25
                },

                new Food
                {
                    Name = "Caesar Salad",
                    Price = 25000,
                    Category = "Đồ ăn kèm",
                    Description = "Crisp romaine lettuce with Caesar dressing and croutons.",
                    ImageURL = "https://example.com/images/caesar_salad.jpg",
                    Calories = 350,
                    Protein = 10,
                    Fat = 20
                },

                new Food
                {
                    Name = "Chocolate Milkshake",
                    Price = 20000,
                    Category = "Thức uống",
                    Description = "A creamy chocolate milkshake topped with whipped cream.",
                    ImageURL = "https://example.com/images/chocolate_milkshake.jpg",
                    Calories = 500,
                    Protein = 15,
                    Fat = 18
                }
            );
            context.SaveChanges();
        }
    }
}