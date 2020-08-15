using Model.Domain.Entities;
using Model.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public IEnumerable<Usuario> BuscarPorNome(string nome)
        {
            return db.Usuarios.Where(n => n.Nome == nome);
        }
    }
}
