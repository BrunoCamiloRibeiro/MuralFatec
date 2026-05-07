using MuralFatecDomain.Enitities;
using MuralFatecDomain.Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuralFatecDomain.Contracts.Services
{
    public interface IUsuarioService
    {
        void RegistraUsuario(int institucaoid, string email, string senha, PerfilValue perfil);

        UsuarioEntity AutenticarUsuario(string  email, string senha);

        IEnumerable<UsuarioEntity> ListarUsuarios();
    }
}
