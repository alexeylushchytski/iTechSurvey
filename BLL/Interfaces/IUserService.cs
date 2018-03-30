using System.Collections.Generic;
using System.Threading.Tasks;
using iTechArt.Survey.BLL.DTO.ViewModels;
using iTechArt.Survey.DomainModel;

namespace iTechArt.Survey.BLL.Interfaces
{
    public interface IUserService
    {
        Task<IReadOnlyCollection<User>> GetUsers();

        Task<IReadOnlyCollection<UserViewModel>> GetUserViewModels();
    }
}