using Model.Application.Interface;
using Model.Domain.Entities;
using Model.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Application
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService)
            : base(usuarioService)
        {
            _usuarioService = usuarioService;
        }

    }
}
