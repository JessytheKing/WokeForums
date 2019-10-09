using System;
using System.Globalization;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Http;
namespace WokeForums.Models.AppUser
{
    public class ProfileModel
    {
        public string UserID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string UserRating { get; set; }

        public string ProfileImageUrl { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime DateJoined { get; set; }
        public IFormFile ImageUpload { get; set; }
    }
}
