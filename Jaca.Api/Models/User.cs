using System;

namespace Jaca.Api.Models
{
    public class User
    {
        public User()
        {
            this.Id = new Guid().ToString();
        }
        public string Id { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
