using AutoMapper;
using HotelProject.DTO.Dtos.RoomDto;
using HotelProject.Entities.Concrete;

namespace HotelProject.WebAPI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AddRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
