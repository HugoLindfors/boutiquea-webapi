namespace Boutiquea.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(255, ErrorMessage = "Product name cannot exceed 255 characters.")]
        public string Name { get; set; }

        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters.")]
        public string? Description { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity in stock cannot be negative.")]
        public int QuantityInStock { get; set; }

        // Optional: Category
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        // Optional: Image URLs
        public List<string> ImageUrls { get; set; } = [];

        // Optional: Product Attributes (e.g., size, color)
        public List<string>? Attributes { get; set; } = [];

        //Optional: Reviews
        public List<Review>? Reviews { get; set; } = [];

        public override string ToString()
        {
            return $"Product ID: {Id}, Name: {Name}, Price: {Price:F2} kr, Stock: {QuantityInStock}";
        }
    }

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }

    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public Product Product { get; set; }

        [Required]
        public string ReviewerName { get; set; }

        [Required]
        public string Comment { get; set; }

        [Required]
        public int Rating { get; set; }
    }
}