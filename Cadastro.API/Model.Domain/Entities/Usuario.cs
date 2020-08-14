using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
