using System;

namespace iTechArt.Survey.DomainModel
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateTime { get; set; }

        public int RoleId { get; set; }

        public virtual Role Role { get; set; }


        public User() { }
    }
}