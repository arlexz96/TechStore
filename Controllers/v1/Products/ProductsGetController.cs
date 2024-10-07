using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using TechStore.Config;
using TechStore.Repositories;

namespace TechStore.Controllers.v1.Products
{
    [Route("[controller]")]
    public class ProductsGetController : ProductsController
    {
        public ProductsGetController(IProductRepository productRepository, Utilities utilities) : base(productRepository, utilities) { }

        [HttpGet]
        [SwaggerOperation(
            Summary = "Titulo del endpoint",
            Description = "Que hace el endpoint"
        )]
        [SwaggerResponse(200, "Respuesta 200")]
        [SwaggerResponse(404, "Respuesta 400")]
        public async Task<IActionResult> GetProducts()
        {

            return Ok(await _productRepository.GetProducts());
        }
    }
}