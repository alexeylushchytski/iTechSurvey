using System.Collections.Generic;
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
            return _unitOfWork.GetRepository<User>().Entities;
        }
    }
}
