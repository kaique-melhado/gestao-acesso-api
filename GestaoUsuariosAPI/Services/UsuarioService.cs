using AutoMapper;
using GestaoUsuariosAPI.Data.DTOs;
using GestaoUsuariosAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace GestaoUsuariosAPI.Services
{
    public class UsuarioService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;
        private SignInManager<Usuario> _signInManager;
        private TokenService _tokenService;

        public UsuarioService(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }
        public async Task Cadastrar(CreateUsuarioDTO createUsuarioDTO)
        {
            Usuario usuario = _mapper.Map<Usuario>(createUsuarioDTO);

            var result = await _userManager.CreateAsync(usuario, createUsuarioDTO.Password);
            if (!result.Succeeded)
                throw new ApplicationException("Falha ao cadastrar usuário!");
        }

        public async Task<string> Logar(LoginUsuarioDTO loginUsuarioDTO)
        {
            var result = await _signInManager.PasswordSignInAsync(loginUsuarioDTO.Username, loginUsuarioDTO.Password, false, false);
            if (!result.Succeeded)
                throw new ApplicationException("Usuário não autenticado!");

            var usuario = _signInManager.UserManager.Users.FirstOrDefault(user => user.NormalizedUserName == loginUsuarioDTO.Username.ToUpper());

            var token = _tokenService.GenerateToken(usuario);

            return token;
        }
    }
}
