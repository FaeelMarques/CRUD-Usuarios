using Model.Domain.Entities;
using Model.Presentation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Presentation.Mapping.Interface
{
    public interface IMapUsuario
    {
        Usuario MapToEntity(UsuarioVM usuario);

        IEnumerable<UsuarioVM> MapListaUsuarios(IEnumerable<Usuario> usuarios);

        UsuarioVM MapToDTO(Usuario usuario);
    }
}
