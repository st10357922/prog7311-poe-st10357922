using System;
using System.ComponentModel.DataAnnotations; // For validation and metadata attributes
// Reference: https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations

namespace AgriEnergyConnect.Models
{
    // Represents a product submitted by a farmer
    public class Product
    {
        // Primary key
        public int Id { get; set; }
        // Name of the product (required)
        [Required(ErrorMessage = "Product name is required")]
        // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.requiredattribute
        public string Name { get; set; }
        // Optional category of the product
        public string Category { get; set; }
        // Date the product was produced (date only, no time)
        [DataType(DataType.Date)]
        // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.datatypeattribute
        public DateTime ProductionDate { get; set; }
        // Foreign key to the Identity user who submitted the product
        public string FarmerId { get; set; }
    }
}


