using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Extensions;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        /*
        This class maps from one object to 
        another thats all it does.
        */
        public AutoMapperProfiles()
        {
            CreateMap<AppUser,MemberDto>()
                .ForMember(dest => dest.PhotoUrl, 
                opt => opt.
                MapFrom(src => src.Photos.
                FirstOrDefault(x => x.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src=>src.DateOfBirth.CalculateAge ()));
            CreateMap<Photo, PhotoDto>();
            CreateMap<MemberUpdateDto, AppUser>();
            CreateMap<RegisterDto, AppUser>();
            
        }
    }
}