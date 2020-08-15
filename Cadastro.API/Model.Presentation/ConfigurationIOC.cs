using Autofac;
using Model.Application;
using Model.Application.Interface;
using Model.Domain.Interfaces.Repositories;
using Model.Domain.Interfaces.Services;
using Model.Domain.Services;
using Model.Infra.Data.Repositories;
using Model.Presentation.Mapping;
using Model.Presentation.Mapping.Interface;

namespace Model.Presentation
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {

            builder.RegisterType<UsuarioAppService>().As<IUsuarioAppService>();

            builder.RegisterType<UsuarioService>().As<IUsuarioService>();

            builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();

            builder.RegisterType<MapUsuario>().As<IMapUsuario>();

        }
    }
}
