using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WokeForums.Models.AccountModels
{
    public class LoginWith2f
    {
        [Required]
        [StringLength(7, ErrorMessage = "The {0} must be have a min {2} and a max of {1} character long.",
            MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Authenticator code")]
        public string TwoFactorCode { get; set; }

        [Display(Name = "Should we remember this computer?")]
        public bool RememberComputer { get; set; }

        public bool RememberMe { get; set; }
    }
}
