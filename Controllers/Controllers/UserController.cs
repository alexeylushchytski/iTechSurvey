using System.Collections.Generic;
using System.Web.Http;
using BLL.Services.UserService;
using Models;

namespace Controllers.Controllers
{
    public class UserController : ApiController
    {
        private readonly UserService _userService;


        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public UserController() { }

        [HttpGet]
        public IEnumerable<User> Users()
        {
            return _userService.GetUsers();
        }
        
    }
}
