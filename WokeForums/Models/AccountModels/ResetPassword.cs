
using System.ComponentModel.DataAnnotations;

namespace WokeForums.Models.AccountModels
{
    public class ResetPassword
    {
        [Required] [EmailAddress] public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and {1} character max", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set;  }

        [DataType(DataType.Password)]
        [Display(Name = "Confrim password")]
        [Compare(otherProperty: "Password", ErrorMessage = "The Password did not match")]
        public string ConfrimPassword { get; set; }

        public string Code { get; set; }
    }
}

