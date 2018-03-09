using System.Collections.Generic;
using System.Threading.Tasks;
using iTechart.Survey.DAL.Interfaces;
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
            _unitOfWork.GetRepository<User>().GetById(1);
            return await _unitOfWork.GetRepository<User>().GetAllAsync();
        }
    }
}