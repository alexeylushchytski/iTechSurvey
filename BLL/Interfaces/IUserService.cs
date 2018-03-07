using System.Collections.Generic;
using Models;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
    }
}