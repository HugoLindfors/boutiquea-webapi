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

        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        [Required]
        public List<OrderItem> OrderItems { get; set; } = [];

        public decimal TotalAmount { get; set; }

        // Shipping Information
        [Required]
        public string ShippingAddress { get; set; }

        public string ShippingCity { get; set; }

        public string ShippingPostalCode { get; set; }

        public string ShippingCountry { get; set; }

        // Billing Information (can be the same as shipping)
        [Required]
        public string BillingAddress { get; set; }

        public string BillingCity { get; set; }

        public string BillingPostalCode { get; set; }

        public string BillingCountry { get; set; }

        //Optional: Tracking Number
        public string TrackingNumber { get; set; }

        //Optional: Payment Information.
        public Payment Payment { get; set; }

    }

    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        [Required]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }

    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled,
        Refunded
    }

    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public string PaymentMethod { get; set; }
        public string TransactionId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}