namespace PetShop_API.Models
{
    public class ProductsModel
    {
        public int Id { get; set; }
        public string Animal { get; set; }
        public List<CatFeedModel> Cats { get; set; } = new();
        public List<DogFeedModel> Dogs { get; set; } = new();
        public List<ParrotFeedModel> Parrots { get; set; } = new(); 
        public List<FishFeedModel> Fishes { get; set; } = new();
    }
}
