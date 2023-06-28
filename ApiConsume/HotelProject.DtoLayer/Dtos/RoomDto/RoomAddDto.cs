using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage = "Please enter a room number!")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }

        [Required (ErrorMessage = "Please enter a price for room!")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter a title for room!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a bed count for room!")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Please enter a bath count for room!")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Descripton { get; set; }
    }
}
