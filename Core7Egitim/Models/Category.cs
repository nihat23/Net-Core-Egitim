using System.ComponentModel.DataAnnotations;//

namespace Core7Egitim.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public ICollection<Product>? Products { get; set; }//? bos gecebılır..
    }
}
