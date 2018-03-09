﻿using System.Collections.Generic;
using System.Threading.Tasks;
using iTechArt.Survey.DomainModel;

namespace iTechArt.Survey.BLL.Interfaces
{
    public interface IUserService
    {
        IReadOnlyCollection<User> GetUsers();
    }
}