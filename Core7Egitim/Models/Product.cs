using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core7Egitim.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }
        public string? Aciklama { get; set; }

        [Column("Fiyat")]
        public string? Fİyat { get; set; }

        public int KategoriId { get; set; }
        public Category? Kategori { get; set; }
    }
}
