using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatingApp.API.Controllers;
using Microsoft.AspNetCore.Authorization;
using DatingApp.API.Interfaces;
using DatingApp.API.DT0s;
using AutoMapper;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers(){
            var users = await userRepository.GetMembersAsync();
            
            return Ok(users);
        }

        [HttpGet("{username}")]
         public async Task<ActionResult<MemberDto>> GetUser(string username)
         {
            return await userRepository.GetMemberAsync(username);
        }


    }
}