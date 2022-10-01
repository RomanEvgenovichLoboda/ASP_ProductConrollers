using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApplicationASP.Model;

namespace WebApplicationASP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        static List<ProductModel> products = new List<ProductModel>() { new ProductModel("Gun", "weapon", 11000), new ProductModel("TNT", "weapon", 5000), new ProductModel("PC", "periphery", 10000) };
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        [HttpGet("GetProducts")]
        public IEnumerable<ProductModel> Get()
        {
            return products;
        }
        [HttpGet("GetProductById")]
        public ProductModel Get(int id)
        {
            foreach (ProductModel item in products)
            {
                if (item.Id == id) return item;
            }
            return null;
        }

    }

}
