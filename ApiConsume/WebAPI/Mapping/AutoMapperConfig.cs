using AutoMapper;
using DtoLayer.Dtos.RoomDto;
using EntityLayer.Concrete;

namespace WebAPI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>().ReverseMap();
            CreateMap<RoomUpdateDto, Room>().ReverseMap();
        }
    }
}
