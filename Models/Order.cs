namespace Boutiquea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        [Required]
        public List<Product> Products { get; set; } = [];

        public decimal TotalAmount { get; set; }
    }
}