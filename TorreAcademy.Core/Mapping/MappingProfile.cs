using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TorreAcademy.Core.Dtos;
using TorreAcademy.Core.Entities;

namespace TorreAcademy.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Skill, SkillDto>().ReverseMap();

            //GET
            CreateMap<Skill, SkillDto>()
                .ForMember(dest => dest.Proficiency, opt => opt.MapFrom(x => x.UserSkill.Proficiency));
        }
    }
}
