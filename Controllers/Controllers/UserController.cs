using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using DAL.Interfaces;
using Models;

namespace Controllers.Controllers
{
    public class UserController : ApiController
    {
        public UserController() { }

        public IEnumerable<User> GetUsers()
        {
            return null;
        }
    }
}
