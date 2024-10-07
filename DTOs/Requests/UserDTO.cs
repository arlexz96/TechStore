using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.DTOs.Requests
{
    public class UserDTO
    {
        public required string Name {get; set;}
        public required string Email {get; set;}
        public required string Password {get; set;}
    }
}