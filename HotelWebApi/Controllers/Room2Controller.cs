﻿using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(CreateRoomDto createRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            var values = _mapper.Map<Room>(createRoomDto);
            _roomService.TInsert(values);
            return Ok();
        }

        [HttpPut    ]
        public IActionResult UpdateRoom(UpdateRoomDto updateRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            var values = _mapper.Map<Room>(updateRoomDto);
            _roomService.TUpdate(values);
            return Ok();
        }
    }
}
