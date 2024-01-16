using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using System.Runtime;

namespace HotelWebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Room,ResultRoomDto>().ReverseMap();
            CreateMap<Room,CreateRoomDto>().ReverseMap();
            CreateMap<Room,UpdateRoomDto>().ReverseMap();
            

        }
    }
}
