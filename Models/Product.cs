namespace Boutiquea.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product(int id, string name, decimal price, int quantityInStock)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public decimal Price { get; set; } = price;
        public int QuantityInStock { get; set; } = quantityInStock;
        public override string ToString()
        {
            return $"Product ID: {Id}, Name: {Name}, Price: {Price:F2} kr";
        }
    }
}