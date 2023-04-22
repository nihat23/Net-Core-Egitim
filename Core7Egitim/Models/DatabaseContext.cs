using Microsoft.EntityFrameworkCore;
using Core7Egitim;

namespace Core7Egitim.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categoriesb { get; set; }
        public DbSet<Product> Productsb  { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB ; database=Core7Egitim;Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }
    }
}//DESKTOP-0OAMK3J\SQLEXPRESS

//   (localdb)\MSSQLLocalDB
