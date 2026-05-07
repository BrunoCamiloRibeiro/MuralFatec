using MuralFatecDomain.Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuralFatecDomain.Entities
{
    public class UsuarioEntity
    {
        // Propriedades

        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public PerfilValue Perfil { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

    }
}
