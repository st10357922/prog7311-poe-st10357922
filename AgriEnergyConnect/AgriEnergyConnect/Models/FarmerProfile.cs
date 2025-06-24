using System.ComponentModel.DataAnnotations; // Provides attributes for data validation
// Reference: https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations

namespace AgriEnergyConnect.Models
{
    // Represents a farmer's profile in the system
    public class FarmerProfile
    {
        // Primary key
        public int Id { get; set; }
        // Full name of the farmer (required)
        [Required(ErrorMessage = "Full Name is required")]
        // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.requiredattribute
        public string FullName { get; set; }
        // Contact number of the farmer (required)
        [Required(ErrorMessage = "Contact Number is required")]
        public string ContactNumber { get; set; }
        // Email address of the farmer (required)
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.emailaddressattribute
        public string Email { get; set; }
        public string UserId { get; set; }
    }
}

