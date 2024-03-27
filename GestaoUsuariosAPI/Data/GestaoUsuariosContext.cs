using GestaoUsuariosAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestaoUsuariosAPI.Data
{
    public class GestaoUsuariosContext : IdentityDbContext<Usuario>
    {
        public GestaoUsuariosContext(DbContextOptions<GestaoUsuariosContext> opts) : base(opts)
        {
            
        }
    }
}
