namespace Boutiquea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }

        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; } = [];
        public decimal TotalAmount { get; set; }
    }
}