using System.Threading.Tasks;
using iTechart.Survey.DAL.Interfaces;
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

        public async Task<string> Login(User user)
        {
            User tempUser = await _unitOfWork.GetRepository<User>().GetByAsync(x => user.Email == x.Email);
            if (tempUser == null)
            {
                return null;
            }

            return null;
        }
    }
}
