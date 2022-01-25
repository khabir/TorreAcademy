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

        public async Task<SkillWiseUserAndSkillDetailDto> GetSkillWiseUserAndSkillDetail(Guid userId, Guid skillId)
        {
            var data = await (from user in dbContext.Users
                              join userskill in dbContext.UserSkills on user.Id equals userskill.UserId
                              join skill in dbContext.Skills on userskill.SkillId equals skill.Id
                              join skProf in dbContext.Proficiencies on userskill.ProficiencyId equals skProf.Id
                              join userExp in dbContext.Experiences on user.Id equals userExp.UserId
                              where skill.Id == skillId
                              select new
                              {
                                  userId = user.Id,
                                  FirstName = user.FirstName,
                                  LastName = user.LastName,
                                  Email = user.Email,
                                  Phone = user.Phone,
                                  Status = user.Status,
                                  SkillId = skill.Id,
                                  SkillName = skill.Name,
                                  Proficiency = skProf.Name,
                                  ProficiencyOrder = skProf.Order,
                                  userExp
                              }).ToListAsync();

            if (data.Count() == 0) return null;

            var output = new SkillWiseUserAndSkillDetailDto();
            output.SkillId = data.FirstOrDefault().SkillId;
            output.SkillName = data.FirstOrDefault().SkillName;
            output.SkillProficiency = data.FirstOrDefault().Proficiency;

            var exp = from d in data
                      where d.userId == userId
                      select d.userExp;

            var expDto = mapper.Map<List<ExperienceDto>>(exp);
            output.UserExperiences = expDto;

            var relatedUsersGroup = from d in data
                                    where d.userId != userId
                                    group new { d.userId, d.FirstName, d.LastName, d.Email, d.Phone, d.Status } by d.userId into grp
                                    select grp.First();


            var relatedUsers = relatedUsersGroup.Select(x => new UserDto
            {
                Id = x.userId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Phone = x.Phone,
                Status = x.Status
            });

            output.RelatedUsers = relatedUsers.ToList();

            return output;
        }
    }
}
