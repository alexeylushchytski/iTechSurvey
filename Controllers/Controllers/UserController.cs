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
        private readonly IUnitOfWork _unitOfWork;


        public UserController(IUnitOfWork unit)
        {
            this._unitOfWork = unit;
        }

        public UserController() { }


        public IEnumerable<User> GetUsers()
        {
            User user = new User
            {
                Name = "Name11",
                Email = "ale1x@mail.com",
                Password = "Pasdsasdfasdfd"
            };
            _unitOfWork.GenericRepository<User>().Add(user);
            _unitOfWork.Commit();
            return null;
        }
    }
}
