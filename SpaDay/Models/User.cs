using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        private string Username { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }

        public User() { }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
