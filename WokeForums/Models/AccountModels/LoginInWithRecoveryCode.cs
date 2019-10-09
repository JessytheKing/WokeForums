using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace WokeForums.Models.AccountModels
{
    public class LoginInWithRecoveryCode
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Recovery Code")]
        public string RecoveryCode { get; set; }
    }
}
