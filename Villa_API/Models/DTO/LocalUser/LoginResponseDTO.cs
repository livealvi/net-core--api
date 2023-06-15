using System;
namespace Villa_API.Models.DTO.User
{
    public class LoginResponseDTO
    {
        public LocalUser User { get; set; }
        public string Token { get; set; }
    }
}

