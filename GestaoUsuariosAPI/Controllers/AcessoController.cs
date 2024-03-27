using GestaoUsuariosAPI.Data.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GestaoUsuariosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcessoController : ControllerBase
    {
        [HttpGet]
        [Authorize(Policy = "IdadeMinima")]
        public async Task<IActionResult> Get(CreateUsuarioDTO createUsuarioDTO)
        {
            return Ok("Acesso permitido!");
        }
    }
}
