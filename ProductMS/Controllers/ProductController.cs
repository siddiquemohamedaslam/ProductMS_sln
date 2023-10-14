using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMS.Data;
using ProductMS.Models.DTO;

namespace ProductMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public List<ProductDTO> GetAll() 
        {
            return ProductDB.ProductList;
        }

        [HttpGet("{id:int}")]
        public ProductDTO GetById(int id)
        {
            return ProductDB.ProductList.FirstOrDefault(p => p.Id == id);
        }
    }
}
