using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApplicationASP.Model;

namespace WebApplicationASP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SortedProductController
    {
        static List<ProductModel> products = new List<ProductModel>() { new ProductModel("Gun", "weapon", 11000), new ProductModel("TNT", "weapon", 5000), new ProductModel("PC", "periphery", 10000) };
        private readonly ILogger<SortedProductController> _logger;
        public SortedProductController(ILogger<SortedProductController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name ="GetSortedProducts")]
        public IEnumerable<ProductModel> Get()
        {
            return products.OrderBy(e => e.Price).ToArray();
        }
    }
}
