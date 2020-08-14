using Model.Application.Interface;
using Model.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Application
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioAppService _usuarioService;

        public UsuarioAppService(IUsuarioAppService usuarioService)
            : base(usuarioService)
        {
            _usuarioService = usuarioService;
        }

    }
}
