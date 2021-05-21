using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.DT0s;
using DatingApp.API.Entities;

namespace DatingApp.API.Interfaces{

    public interface IUserRepository{
        void Update(AppUser User);

        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();

        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);

        Task<IEnumerable<MemberDto>> GetMembersAsync();

        Task<MemberDto> GetMemberAsync(string username);

    }
}