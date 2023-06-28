using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        [Required(ErrorMessage = "Please enter a room ID!")]
        public int RoomId { get; set; }

        [Required(ErrorMessage = "Please enter a room number!")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Please enter a room cover image !")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please enter a price for room!")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter a title for room!")]
        [StringLength(100, ErrorMessage = "Please enter max 100 character")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a bed count for room!")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Please enter a bath count for room!")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }

        [Required(ErrorMessage = "Please enter a description for room!")]
        public string Descripton { get; set; }
    }
}
