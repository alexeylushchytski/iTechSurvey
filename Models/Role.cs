using System.Collections.Generic;

namespace iTechArt.Survey.DomainModel
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}