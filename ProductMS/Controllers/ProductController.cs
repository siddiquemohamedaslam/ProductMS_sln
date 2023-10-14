using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMS.Models;

namespace ProductMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public List<ProductDTO> GetAll() 
        {
            return new List<ProductDTO> {

                new ProductDTO {Id=1,Name="Laptop" },
                new ProductDTO {Id=2,Name="Anchor" }
            };
        }
    }
}
