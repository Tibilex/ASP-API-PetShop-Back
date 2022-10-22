using Microsoft.AspNetCore.Mvc;
using PetShop_API.Models;

namespace PetShop_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet("AllProducts")]
        public IEnumerable<ProductsModel> GetAll() => new ProductContext().Products;

        [HttpGet("CatsFeed")]
        public IEnumerable<CatFeedModel> GetCats() => new ProductContext().CatProducts;

        [HttpGet("DogFeed")]
        public IEnumerable<DogFeedModel> GetDogs() => new ProductContext().DogProducts;

        [HttpGet("ParrotFeed")]
        public IEnumerable<ParrotFeedModel> GetParrots() => new ProductContext().ParrotProducts;

        [HttpGet("FishFeed")]
        public IEnumerable<FishFeedModel> GetFishes() => new ProductContext().FishProducts;
    }
}
