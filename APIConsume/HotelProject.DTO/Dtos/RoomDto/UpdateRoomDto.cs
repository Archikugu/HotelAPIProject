using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DTO.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Numarası Giriniz")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Görseli Giriniz")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen Fiyat Bilgisi Giriniz")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Başlığı Giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen Yatak Sayısı Giriniz")]
        public string BedCount { get; set; }
        public string Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Açıklaması Giriniz")]
        public string Description { get; set; }
    }
}
