using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechStore.Data;
using TechStore.DTOs.Requests;
using TechStore.Models;
using TechStore.Repositories;

namespace TechStore.Services
{
    public class ProductServices(AppDbContext appDbContext) : IProductRepository
    {
        private readonly AppDbContext _dbContext = appDbContext;

        public async Task CreateUser(UserDTO userDTO)
        {
            if (await CheckExistence(userDTO.Email))
            {
                throw new ArgumentException("Email already exist");
            }
            User user = new User{
                Name = userDTO.Name,
                Email = userDTO.Email,
                Password = userDTO.Password,
                IdRol = 1
            };
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<bool> CheckExistence(string email)
        {
            return await _dbContext.Users.AnyAsync(p => p.Email.Equals(email.ToLower()));
        }
    }
}