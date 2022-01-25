using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorreAcademy.Core.Data;
using TorreAcademy.Core.Dtos;
using TorreAcademy.Services.Interfaces;

namespace TorreAcademy.Services.Services
{
    public class UserService: IUserService
    {
        private readonly TorreAcademyDbContext dbContext;
        private readonly IMapper mapper;

        public UserService(TorreAcademyDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<List<UserDto>> GetUsersBySkill(Guid skillId)
        {
            var users = await (from user in dbContext.Users
                         join userSkill in dbContext.UserSkills on user.Id equals userSkill.UserId
                         where userSkill.SkillId == skillId
                         select user).ToListAsync();

            return mapper.Map<List<UserDto>>(users);
        }

        public async Task<List<UserDto>> GetUsers()
        {
            var users = await (from user in dbContext.Users
                               select user).ToListAsync();

            return mapper.Map<List<UserDto>>(users);
        }
    }
}
