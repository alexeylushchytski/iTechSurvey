using System.Collections.Generic;
using System.Web.Http;
using iTechArt.Survey.BLL.Interfaces;
using iTechArt.Survey.DomainModel;

namespace iTechArt.Survey.WebApi.Controllers
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