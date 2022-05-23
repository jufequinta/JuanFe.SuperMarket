using JuanFe.Supermarket.Product.Interface.Solution;
using JuanFe.Supermarket.Product.Solution.DataContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Swashbuckle.Examples;
using System;
using System.Threading.Tasks;

namespace JuanFe.Supermarket.Product.Solution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBussinesLogic _productBussinesLogic;
        
        public ProductController(IProductBussinesLogic productBussinesLogic, IConfiguration configuration)
        {
            _productBussinesLogic = productBussinesLogic;
        }

        [HttpPost]
        [Route("AddProduct")]
        [SwaggerRequestExample(typeof(ProductInput), typeof(ProductInput))]
        public async Task<ActionResult<Guid>> AddProduct([FromBody] ProductInput productInput)
        {
           return Ok(await _productBussinesLogic.AddProductProcess(productInput));
        }
    }
}
