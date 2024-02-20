using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIProducts.Models;

namespace WebAPIProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> products = new List<Product>()
        {
            new() {PId=1, PName="Herbal Shampoo", Price=500},

            new() {PId=2, PName="Face Mask", Price=700},

           new() {PId=3, PName="Face Wash", Price=700},

        new() {PId=5,PName="Glow & Shine", Price=300},

     new() {PId=6, PName="Anti Aging Cream", Price=890},

        };


        [HttpGet(Name = "GetProducts")]

        public IEnumerable<Product> Get()
        { 

return products;
}


    }
}
