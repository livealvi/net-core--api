using System;
namespace Villa_API.Models.DTO.LocalUser
{
    public class RegisterationRequestDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}

