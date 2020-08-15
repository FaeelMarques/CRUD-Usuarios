using Model.Domain.Entities;
using Model.Domain.Interfaces.Repositories;
using Model.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        private readonly Contexto db;
        public UsuarioRepository(Contexto contexto) : base(contexto)
        {
            db = contexto;
        }

        public IEnumerable<Usuario> BuscarPorNome(string nome)
        {
            return db.Usuarios.Where(n => n.Nome == nome);
        }
    }
}
