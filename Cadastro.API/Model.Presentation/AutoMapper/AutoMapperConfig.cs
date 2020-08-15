using AutoMapper;
using Model.Domain.Entities;
using Model.Presentation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Presentation.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<UsuarioVM, Usuario>();
            CreateMap<Usuario, UsuarioVM>();
        }
    }
}
