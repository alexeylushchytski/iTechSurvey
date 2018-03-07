using System.Collections.Generic;
using DAL.Interfaces;
using iTechArt.Survey.BLL.Interfaces;
using iTechArt.Survey.DomainModel;

namespace iTechArt.Survey.BLL.Services.UserService
{
    public sealed class UserService : IUserService
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