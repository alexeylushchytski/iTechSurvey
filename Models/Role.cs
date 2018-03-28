using System.Collections.Generic;

namespace iTechArt.Survey.DomainModel
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}