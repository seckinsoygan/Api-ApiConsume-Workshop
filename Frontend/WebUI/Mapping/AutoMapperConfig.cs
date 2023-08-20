using AutoMapper;
using EntityLayer.Concrete;
using WebUI.Dtos.IdentityDto.LoginDto;
using WebUI.Dtos.IdentityDto.RegisterDto;
using WebUI.Dtos.ServiceDto;

namespace WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
        }
    }
}
