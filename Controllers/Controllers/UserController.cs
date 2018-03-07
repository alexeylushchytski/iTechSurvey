using System.Collections.Generic;
using System.Web.Http;
using BLL.Interfaces;
using Models;

namespace Controllers.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public IEnumerable<User> Users()
        {
            return _userService.GetUsers();
        }
    }
}