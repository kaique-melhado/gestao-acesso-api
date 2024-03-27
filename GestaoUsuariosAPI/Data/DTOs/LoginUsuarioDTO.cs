using System.ComponentModel.DataAnnotations;

namespace GestaoUsuariosAPI.Data.DTOs
{
    public class LoginUsuarioDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
