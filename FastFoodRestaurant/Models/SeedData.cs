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
                    Name = "Hamburger Bò",
                    Category = "Burger",
                    Description = "Hamburger bò nướng thơm ngon với xà lách, cà chua và phô mai.",
                    Price = 50000,
                    Calories = 550,
                    Protein = 30,
                    Fat = 25,
                    ImageURL = "https://sf-static.upanhlaylink.com/img/image_20260116b3709f17f10f3035764f5193c55a960a.jpg"
                },

                new Food
                {
                    Name = "Hamburger Gà",
                    Category = "Burger",
                    Description = "Hamburger gà nướng thơm ngon kèm rau tươi và sốt mayonnaise.",
                    Price = 50000,
                    Calories = 450,
                    Protein = 35,
                    Fat = 15,
                    ImageURL = "https://sf-static.upanhlaylink.com/img/image_202601168e78013d0cc96c19ec1d7624929e7fdb.jpg"
                },

                new Food
                {
                    Name = "Coca Cola",
                    Category = "Drinks",
                    Description = "Nước giải khát Coca Cola mát lạnh giúp giải khát tức thì.",
                    Price = 15000,
                    Calories = 150,
                    Protein = 0,
                    Fat = 0,
                    ImageURL = "https://sf-static.upanhlaylink.com/img/image_202601162cc9b44e11fb99e818f50c73bc86680d.jpg"
                },

                new Food
                {
                    Name = "Pepsi",
                    Category = "Drinks",
                    Description = "Nước ngọt Pepsi ướp lạnh mang lại cảm giác sảng khoái.",
                    Price = 15000,
                    Calories = 150,
                    Protein = 0,
                    Fat = 0,
                    ImageURL = "https://sf-static.upanhlaylink.com/img/image_202601168006d7de87ad6ce5b7872dd6e334db83.jpg"
                },
                new Food
                {
                    Name = "Pizza Hawaii",
                    Category = "Pizza",
                    Description = "Pizza thơm ngon phủ giăm bông và dứa ngọt.",
                    Price = 80000,
                    Calories = 700,
                    Protein = 25,
                    Fat = 30,
                    ImageURL = "https://sf-static.upanhlaylink.com/img/image_20260116f6a13576543e35c82858634cd7f10260.jpg"
                }


            );

            context.SaveChanges();
        }
    }
}