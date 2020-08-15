using Model.Domain.Entities;
using Model.Presentation.Mapping.Interface;
using Model.Presentation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Presentation.Mapping
{
    public class MapUsuario : IMapUsuario
    {
        List<UsuarioVM> usuarios = new List<UsuarioVM>();

        public Usuario MapToEntity(UsuarioVM usuarioVM)
        {
            Usuario usuario = new Usuario
            {
                Id = usuarioVM.Id,
                Nome = usuarioVM.Nome,
                Telefone = usuarioVM.Telefone,
                Idade = usuarioVM.Idade,
                Email = usuarioVM.Email
            };

            return usuario;

        }

        public IEnumerable<UsuarioVM> MapListaUsuarios(IEnumerable<Usuario> usuario)
        {
            foreach (var item in usuario)
            {

                UsuarioVM usuarioVM = new UsuarioVM
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Telefone = item.Telefone,
                    Idade = item.Idade,
                    Email = item.Email
                };

                usuarios.Add(usuarioVM);

            }

            return usuarios;
        }

        public UsuarioVM MapToDTO(Usuario usuario)
        {

            UsuarioVM usuarioVM = new UsuarioVM
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Telefone = usuario.Telefone,
                Idade = usuario.Idade,
                Email = usuario.Email
            };

            return usuarioVM;

        }

    }
}

