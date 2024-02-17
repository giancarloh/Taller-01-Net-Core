using Microsoft.AspNetCore.Mvc;
using MyTaller01.Bll;
using MyTaller01.Models;

namespace MyTaller01.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ServicesBllController : ControllerBase
    {
        ServicesBll _servicesBll = new(); // intancia de la logica de negocios

        [HttpGet("categories")]
        public ActionResult<IEnumerable<ProductsModel>> GetCategories()
        {
            return Ok(_servicesBll.GetCategories());
        }

        [HttpGet("products/category/{categoryId}")]
        public ActionResult<IEnumerable<ProductsModel>> GetProductsByCategory(int categoryId)
        {
            return Ok(_servicesBll.GetProductsByCategory(categoryId));
        }

        [HttpGet("product-names")]
        public ActionResult<IEnumerable<string>> GetProductNames()
        {
            return Ok(_servicesBll.GetProductNames());
        }

        [HttpGet("products/quantity/{number}")]
        public ActionResult<IEnumerable<string>> GetProductsByQuantufy(int number)
            {
            return Ok(_servicesBll.GetProductsByQuantity(number));
        }
    }
}