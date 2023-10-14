using ProductMS.Models.DTO;

namespace ProductMS.Data
{
    public static class ProductDB
    {
        public static List<ProductDTO> ProductList= new List<ProductDTO> {

                new ProductDTO {Id=1,Name="Laptop" },
                new ProductDTO {Id=2,Name="Anchor" }
            };
    }
}
