using System.Collections.Generic;
using System.Threading.Tasks;
using iTechart.Survey.DAL.Interfaces;
using iTechArt.Survey.BLL.DTO.ViewModels;
using iTechArt.Survey.BLL.Interfaces;
using iTechArt.Survey.DomainModel;

namespace iTechArt.Survey.BLL.Services.UserService
{
    public sealed class UserService : IUserService
    {
        private readonly ISurveyUnitOfWork _unitOfWork;


        public UserService(ISurveyUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<IReadOnlyCollection<User>> GetUsers()
        {
            return await _unitOfWork.UsersRepository.GetAllAsync();
        }


        public async Task<IReadOnlyCollection<UserViewModel>> GetUserViewModels()
        {
            var users = await _unitOfWork.UsersRepository.GetAllAsync();
            List<UserViewModel> usersList = new List<UserViewModel>();
            foreach (var user in users)
            {
                usersList.Add(new UserViewModel
                {
                    Name = user.Name,
                    RoleName = user.Role.Name,
                    RegisterDate = user.DateTime.ToShortDateString()
                });
            }
            return usersList;
        }
    }
}