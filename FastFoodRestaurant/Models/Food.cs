namespace FastFoodRestaurant.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }

        public int? Calories { get; set; }
        public int? Protein { get; set; }
        public int? Fat { get; set; }

    }
}
