using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Models;

namespace BLL.Services.UserService
{
    public sealed class UserService
    {
        private readonly IUnitOfWork _unitOfWork;


        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IEnumerable<User> GetUsers()
        {
            return _unitOfWork.GenericRepository<User>().Entities;
        }
    }
}
