
using System.Globalization;
using System.Security.AccessControl;

namespace WokeForums.Models.AppUser
{
    public class AppUserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string ProfileImageUrl { get; set; }
        public int Rating { get; set; }
        public bool IsActive { get; set; }
    }
}
