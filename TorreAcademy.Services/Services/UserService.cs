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
                               join userExp in dbContext.Experiences on user.Id equals userExp.UserId
                               where user.Status == Core.Enum.Status.Active && userExp.Highlighted == true
                               orderby user.FirstName
                                   select new UserDto
                                   {
                                       FirstName = user.FirstName,
                                       LastName = user.LastName,
                                       UserName = user.UserName,
                                       Email = user.Email,
                                       Phone = user.Phone,
                                       CreatedDate = user.CreatedDate,
                                       Id = user.Id,
                                       ProfilePicture = user.ProfilePicture,
                                       Status = user.Status,
                                       RecentExperience = new ExperienceDto
                                       {
                                           Name = userExp.Name
                                       }

                                   }
                               ).ToListAsync();


            return mapper.Map<List<UserDto>>(users);
        }

        public async Task<SkillWiseUserAndSkillDetailDto> GetSkillWiseUserAndSkillDetail(Guid userId, Guid skillId)
        {
            var data = await (from user in dbContext.Users
                              join userskill in dbContext.UserSkills on user.Id equals userskill.UserId
                              join skill in dbContext.Skills on userskill.SkillId equals skill.Id
                              join skProf in dbContext.Proficiencies on userskill.ProficiencyId equals skProf.Id
                              join userExp in dbContext.Experiences on user.Id equals userExp.UserId
                              join expOrg in dbContext.Organizations on userExp.OrganizationId equals expOrg.Id
                              where skill.Id == skillId
                              select new
                              {
                                  userId = user.Id,
                                  FirstName = user.FirstName,
                                  LastName = user.LastName,
                                  Email = user.Email,
                                  Phone = user.Phone,
                                  Status = user.Status,
                                  ProfilePicture = user.ProfilePicture,
                                  SkillId = skill.Id,
                                  SkillName = skill.Name,
                                  Proficiency = skProf.Name,
                                  ProficiencyOrder = skProf.Order,
                                  userExp,
                                  expOrg
                              }).ToListAsync();

            if (data.Count() == 0) return null;

            var output = new SkillWiseUserAndSkillDetailDto();
            output.SkillId = data.FirstOrDefault().SkillId;
            output.SkillName = data.FirstOrDefault().SkillName;
            output.SkillProficiency = data.FirstOrDefault().Proficiency;

            var expDto = from d in data
                      where d.userId == userId && d.userExp.Category == Core.Enum.OrganizationCategory.Job
                      select new ExperienceDto {
                        Id = d.userExp.Id,
                          FromMonth = d.userExp.FromMonth,
                          FromYear = d.userExp.FromYear,
                          ToMonth = d.userExp.ToMonth,
                          ToYear = d.userExp.ToYear,
                          Highlighted = d.userExp.Highlighted,
                          Name = d.userExp.Name,
                          Organization = new OrganizationDto { 
                            Id = d.expOrg.Id,
                            Name = d.expOrg.Name
                          }
                      };

            output.UserExperiences = expDto.ToList();

            var relatedUsersGroup = from d in data
                                    where d.userId != userId && d.userExp.Highlighted == true
                                    group new { d.userId, d.FirstName, d.LastName, d.Email, d.Phone, d.Status, d.ProfilePicture, d.userExp.Name } by d.userId into grp
                                    select grp.First();


            var relatedUsers = relatedUsersGroup.Select(x => new UserDto
            {
                Id = x.userId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Phone = x.Phone,
                Status = x.Status,
                ProfilePicture = x.ProfilePicture,
                RecentExperience = new ExperienceDto { Name = x.Name }
            });

            output.RelatedUsers = relatedUsers.ToList();

            return output;
        }
    }
}
