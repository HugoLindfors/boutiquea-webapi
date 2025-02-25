namespace Boutiquea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Customer
    {
        [Key]
        public string CustomerId { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [StringLength(255, ErrorMessage = "Email address cannot exceed 255 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        [StringLength(20, ErrorMessage = "Phone number cannot exceed 20 characters.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Shipping Address is required.")]
        public string ShippingAddress { get; set; }

        public string ShippingCity { get; set; }

        public string ShippingPostalCode { get; set; }

        public string ShippingCountry { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;

        public List<Order> Orders { get; set; } = new List<Order>();

        //Optional: Billing Address (if different from shipping)
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingCountry { get; set; }

        //Optional: Customer Loyalty Points
        public int LoyaltyPoints { get; set; } = 0;

        //Optional: List of payment methods.
        public List<Payment> PaymentMethods { get; set; } = new List<Payment>();

    }
}