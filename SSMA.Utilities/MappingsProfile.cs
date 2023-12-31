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
                .ForMember(principal => principal.Email, u => u.MapFrom(user => user.Email))
                .ForMember(principal => principal.Username, u => u.MapFrom(user => user.UserName))
                .ForMember(principal => principal.Phone, u => u.MapFrom(user => user.PhoneNumber))
                .ReverseMap();
            CreateMap<AppUser, UpdatePrincipalDTO>()
               .ForMember(principal => principal.Email, u => u.MapFrom(user => user.Email))
               .ForMember(principal => principal.Phone, u => u.MapFrom(user => user.PhoneNumber))
               .ReverseMap();


        }
    }
}
