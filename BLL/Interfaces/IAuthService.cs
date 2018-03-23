﻿using System.Threading.Tasks;
using iTechArt.Survey.BLL.DTO.ViewModels;

namespace iTechArt.Survey.BLL.Interfaces
{
    public interface IAuthService
    {
        Task<string> Login(LoginUserViewModel user);
    }
}
