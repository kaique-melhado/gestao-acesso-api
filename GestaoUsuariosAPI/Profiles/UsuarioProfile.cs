using AutoMapper;
using GestaoUsuariosAPI.Data.DTOs;
using GestaoUsuariosAPI.Models;

namespace GestaoUsuariosAPI.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile() 
        {
            CreateMap<CreateUsuarioDTO, Usuario>();
        }
    }
}
