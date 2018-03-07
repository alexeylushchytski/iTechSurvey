using System.Collections.Generic;
using iTechArt.Survey.DomainModel;

namespace iTechArt.Survey.BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
    }
}