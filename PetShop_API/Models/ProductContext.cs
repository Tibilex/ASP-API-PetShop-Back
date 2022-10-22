using Microsoft.EntityFrameworkCore;

namespace PetShop_API.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<ProductsModel> Products { get; set; }
        public DbSet<CatFeedModel> CatProducts { get; set; }
        public DbSet<DogFeedModel> DogProducts { get; set; }
        public DbSet<ParrotFeedModel> ParrotProducts { get; set; }
        public DbSet<FishFeedModel> FishProducts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Test_EF_DB;Integrated Security=True;");
        }
    }
}
