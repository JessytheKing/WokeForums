using System;

using System.ComponentModel.DataAnnotations;


namespace WokeForums.Models.AccountModels
{
    public class ForgotPassWord
    {
        [Required] [EmailAddress] public string Email { get; set; }
    }
}
