using System.ComponentModel.DataAnnotations;

namespace WokeForums.Models.AccountModels
{
    public class ExternalLogIn
    {
        [Required] [EmailAddress] public string Email { get; set; }
    }
}
