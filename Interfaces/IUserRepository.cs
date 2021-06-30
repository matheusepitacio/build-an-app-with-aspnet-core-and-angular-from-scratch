using System.Collections.Generic;
using System.Threading.Tasks;
using API.Helpers;
using DatingApp.API.DT0s;
using DatingApp.API.Entities;

namespace DatingApp.API.Interfaces
{

    public interface IUserRepository
    {
        void Update(AppUser User);
        Task<IEnumerable<AppUser>> GetUsersAsync();

        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);

        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);

        Task<MemberDto> GetMemberAsync(string username);

        Task<string> GetUserGender(string username);

    }
}