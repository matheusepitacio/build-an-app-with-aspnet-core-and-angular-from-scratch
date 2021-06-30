using System.Threading.Tasks;
using DatingApp.API.Entities;

namespace DatingApp.API.Interfaces
{

    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}