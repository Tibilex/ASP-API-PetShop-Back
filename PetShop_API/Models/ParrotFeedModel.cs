namespace PetShop_API.Models
{
    public class ParrotFeedModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Transcrypt { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public int Code { get; set; }
        public string Image { get; set; }
        public ProductsModel Product { get; set; }
    }
}
