using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
	public class Item
	{
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Desscription { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public int AvailQuantity { get; set; }

       public Status Status { get; set; }

        
    }
}

public enum Status
{
    Ok, Defective
}