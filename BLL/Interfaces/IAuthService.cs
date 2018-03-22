using System.Threading.Tasks;
using iTechArt.Survey.DomainModel;

namespace iTechArt.Survey.BLL.Interfaces
{
    public interface IAuthService
    {
        Task<string> Login(User email);
    }
}
