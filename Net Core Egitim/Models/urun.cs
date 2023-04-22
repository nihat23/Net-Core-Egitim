using System.ComponentModel.DataAnnotations;

namespace Net_Core_Egitim.Models
{
    public class urun
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad Kısmı Boş Geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Fiyat Girilmelidir..")]
        public decimal UrunFiyat { get; set; }
        public string Aciklama { get; set; }
    }
}
