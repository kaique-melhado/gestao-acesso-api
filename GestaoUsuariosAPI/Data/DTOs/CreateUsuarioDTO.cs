using System.ComponentModel.DataAnnotations;

namespace GestaoUsuariosAPI.Data.DTOs
{
    public class CreateUsuarioDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [Compare("Password")]
        public string PasswordConfirmation{ get; set; }
    }
}
