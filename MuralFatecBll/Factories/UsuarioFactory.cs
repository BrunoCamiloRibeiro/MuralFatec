using System;
using System.Collections.Generic;
using System.Text;
using MuralFatecDomain.Enitities;
using MuralFatecDomain.Values;

namespace MuralFatecBll.Factories
{
    public static class UsuarioFactory
    {
        public static UsuarioEntity CriarUsuario(int institucaoid, string email, string senha, PerfilValue perfil)
        {
            return new UsuarioEntity
            {
                InstituicaoId = institucaoid,
                Perfil = perfil,
                Email = email,
                Senha = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(senha)),
                DataCadastro = DateTime.Now
            };
        }
    }
}
