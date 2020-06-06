using System;
using System.ComponentModel.DataAnnotations;

namespace Blazorapp.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(15,ErrorMessage = "First Name too long")]
        [MinLength(2, ErrorMessage = "First Name too short")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "First Name too long")]
        [MinLength(2, ErrorMessage = "Last Name is too short")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

    }
}
