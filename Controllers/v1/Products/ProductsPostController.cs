using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechStore.Config;
using TechStore.DTOs.Requests;
using TechStore.Repositories;

namespace TechStore.Controllers.v1.Products
{
    [Route("[controller]")]
    public class ProductsPostController : ProductsController
    {
        public ProductsPostController(IProductRepository productRepository, Utilities utilities) : base(productRepository, utilities){}
        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDTO userDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            userDTO.Password = _utilities.EncryptSHA256(userDTO.Password);
            await _productRepository.CreateUser(userDTO);
            return Ok("User registered sucessfully");
        }
    }
}