using System.ComponentModel.DataAnnotations;

namespace FastFoodRestaurant.Models
{
    public class Food
    {
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Tên món ăn")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Giá tiền")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N0} VNĐ")]
        [Range(1000, 500000)]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Danh mục")]
        public string Category { get; set; }

        [Display(Name = "Mô tả")]
        public string? Description { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Hình ảnh")]
        public string? ImageURL { get; set; }

        
        [Display(Name = "Calo (kCal)")]
        [DisplayFormat(DataFormatString = "{0} kCal")]
        public int? Calories { get; set; }

        [Display(Name = "Protein (g)")]
        [DisplayFormat(DataFormatString = "{0} g")]
        public int? Protein { get; set; }

        [Display(Name = "Chất béo (g)")]
        [DisplayFormat(DataFormatString = "{0} g")]
        public int? Fat { get; set; }

    }
}
