using AutoMapper;
using SSMA.DTOs.PrincipalDTOs;
using SSMA.Models.Models;

namespace SSMA.Utilities
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Principal, AddPrincipalDTO>().ReverseMap();

            CreateMap<Principal, UpdatePrincipalDTO>().ReverseMap();

            CreateMap<AppUser, AddPrincipalDTO>()
                .ForMember(principal => principal.BusinessEmail, u => u.MapFrom(user => user.Email))
                .ForMember(principal => principal.Username, u => u.MapFrom(user => user.UserName))
                .ForMember(principal => principal.BusinessPhone, u => u.MapFrom(user => user.PhoneNumber))
                .ReverseMap();


        }
    }
}
