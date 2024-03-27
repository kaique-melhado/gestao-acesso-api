using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GestaoUsuariosAPI.Models
{
    public class Usuario : IdentityUser
    {
        [Required]
        [Compare("Password")]
        public string PasswordConfirmation { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public Usuario() : base()
        {
            
        }
    }
}
