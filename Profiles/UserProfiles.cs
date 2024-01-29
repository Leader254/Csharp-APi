using AutoMapper;
using csharp_crud_api.Models;
using csharp_crud_api.Models.Dtos;

namespace csharp_crud_api.Profiles
{
    public class UserProfiles : Profile
    {
        public UserProfiles()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}