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
    [Route("api/v1/products")]
    public class ProductsController(IProductRepository productRepository, Utilities utilities) : Controller
    {
        protected readonly IProductRepository _productRepository = productRepository;
        protected readonly Utilities _utilities = utilities;
    }
}