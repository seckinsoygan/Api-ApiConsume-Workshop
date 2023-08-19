using System.ComponentModel.DataAnnotations;

namespace DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Numarası Giriniz.")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Görseli Giriniz.")]
        public string RoomImage { get; set; }
        [Required(ErrorMessage = "Lütfen Fiyat Bilgisi Giriniz.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen Başlık Bilgisi Giriniz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Yatak Sayısı Giriniz.")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen Banyo Sayısı Giriniz.")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Açıklaması Giriniz.")]
        public string Description { get; set; }
    }
}
