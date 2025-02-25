namespace Boutiquea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Customer(int id, string fullName)
    {
        public int Id { get; set; } = id;
        public string FullName { get; set; } = fullName;
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
        public List<Order> Orders { get; set; } = [];
    }
}