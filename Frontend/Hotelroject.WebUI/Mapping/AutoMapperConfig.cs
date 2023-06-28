using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProjectEntityLayer.Concrete;
using Hotelroject.WebUI.Dtos.AboutDto;
using Hotelroject.WebUI.Dtos.BookingDto;
using Hotelroject.WebUI.Dtos.LoginDto;
using Hotelroject.WebUI.Dtos.RegisterDto;
using Hotelroject.WebUI.Dtos.StaffDto;
using Hotelroject.WebUI.Dtos.SubscribeDto;
using Hotelroject.WebUI.Dtos.TestimonialDto;

namespace Hotelroject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();
            CreateMap<Room, UpdateRoomDto>().ReverseMap();
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap(); 
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap <ResultAboutDto,About>().ReverseMap(); 
            CreateMap <UpdateAboutDto,About>().ReverseMap();

            CreateMap <ResultStaffDto,Staff>().ReverseMap();

            CreateMap <CreateSubscribeDto,Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();    
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();  




        }
    }
}
