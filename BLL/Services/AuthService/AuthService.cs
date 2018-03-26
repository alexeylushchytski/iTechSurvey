using System.Threading.Tasks;
using iTechart.Survey.DAL.Interfaces;
using iTechArt.Survey.BLL.DTO.ViewModels;
using iTechArt.Survey.BLL.Interfaces;
using iTechArt.Survey.DomainModel;

namespace iTechArt.Survey.BLL.Services.AuthService
{
    public sealed class AuthService : IAuthService
    {
        private readonly ISurveyUnitOfWork _unitOfWork;


        public AuthService(ISurveyUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> ValidateUser(string email, string password)
        {
            User tempUser = await _unitOfWork.GetRepository<User>().GetByAsync(x => x.Email == email && x.Password == password);
            if (tempUser != null)
            {
                return true;
            }

            return false;
        }
    }
}
