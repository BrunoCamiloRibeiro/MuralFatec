using MuralFatecDomain.Contracts.Services;
using MuralFatecDomain.Enitities;
using MuralFatecDomain.Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuralFatecBll.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly UsuarioRepository

        public UsuarioEntity AutenticarUsuario(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioEntity> ListarUsuarios()
        {
            throw new NotImplementedException();
        }

        public void RegistraUsuario(int institucaoid, string email, string senha, PerfilValue perfil)
        {
            throw new NotImplementedException();
        }
    }
}
