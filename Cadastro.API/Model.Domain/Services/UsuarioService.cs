using Model.Domain.Entities;
using Model.Domain.Interfaces.Repositories;
using Model.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Domain.Services
{
    public class UsuarioService: ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
            : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IEnumerable<Usuario> BuscarPorTitulo(string nome)
        {
            return _usuarioRepository.BuscarPorNome(nome);
        }
    }
}
