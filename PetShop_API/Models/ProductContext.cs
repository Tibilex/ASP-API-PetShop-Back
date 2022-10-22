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
            optionsBuilder.UseSqlServer("Data Source=SQL8001.site4now.net,1433;Initial Catalog=db_a8dfe9_aspdb;User Id=db_a8dfe9_aspdb_admin;Password=Bozic901;");
        }
    }
}
