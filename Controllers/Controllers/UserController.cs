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
        private UnitOfWork unitOfWork = new UnitOfWork();

        //public UserController(IUnitOfWork unit)
        //{
        //    this.unitOfWork = unit;
        //}

        public UserController() { }

        public IEnumerable<User> GetUsers()
        {
            User user = new User
            {
                Name = "Name1",
                Email = "alex@mail.com",
                Password = "Pasdsasdfasdfd"
            };
            unitOfWork.UsersRepository.Add(user);
            unitOfWork.Commit();
            return null;
        }
    }
}
