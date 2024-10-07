using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.DTOs.Requests;
using TechStore.Models;

namespace TechStore.Repositories
{
    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetProducts();
        public Task CreateUser(UserDTO userDTO);
    }
}