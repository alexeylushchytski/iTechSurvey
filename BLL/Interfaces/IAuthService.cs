using System.Threading.Tasks;
using iTechArt.Survey.BLL.DTO.ViewModels;
using iTechArt.Survey.DomainModel;

namespace iTechArt.Survey.BLL.Interfaces
{
    public interface IAuthService
    {
        Task<bool> ValidateUser(string email, string password);


        Task<bool> UserExist(string email);


        Task<int> CreateUserAsync(RegisterUserViewModel user);


        Task<User> GetUser(string email);
    }
}