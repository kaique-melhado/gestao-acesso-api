using GestaoUsuariosAPI.Data.DTOs;
using GestaoUsuariosAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestaoUsuariosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _usuarioService;

        public UsuarioController(UsuarioService cadastroService)
        {
            _usuarioService = cadastroService;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastrarUsuario(CreateUsuarioDTO createUsuarioDTO)
        {
            await _usuarioService.Cadastrar(createUsuarioDTO);
            return Ok("Usuário cadastrado com sucesso!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Logar(LoginUsuarioDTO loginUsuarioDTO)
        {
            var token = await _usuarioService.Logar(loginUsuarioDTO);
            return Ok(token);
        }
    }
}
