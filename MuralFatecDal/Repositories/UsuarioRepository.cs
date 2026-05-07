using MuralFatecDal.Data;
using MuralFatecDomain.Contracts.Repositories;
using MuralFatecDomain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuralFatecDal.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SqlServerData _bancoDados;

        public UsuarioRepository(SqlServerData bancoDados)
        {
            _bancoDados = bancoDados;
        }

        public void Incluir(UsuarioEntity usuario)
        {
            //sql insert = add
            _bancoDados.Usuarios.Add(usuario);
            //executar o comando
            _bancoDados.SaveChanges();
        }

        public IEnumerable<UsuarioEntity> Listar()
        {
            //sql select all = ToList 
            return _bancoDados.Usuarios.ToList();
        }

        public void Alterar(UsuarioEntity usuario)
        {
            //sql update = update
            _bancoDados.Usuarios.Update(usuario);
            //executar o comando
            _bancoDados.SaveChanges();
        }

        public void Excluir(int id)
        {
            var usuario = _bancoDados.Usuarios.FirstOrDefault(x => x.Id == id);
            _bancoDados.Usuarios.Remove(usuario);
            _bancoDados.SaveChanges();
        }



        public UsuarioEntity Obter(int id)
        {
            var usuario = _bancoDados.Usuarios.FirstOrDefault(x => x.Id == id);
            return usuario;
        }

        public UsuarioEntity Obter(string email, string senha)
        {
            var usuario = _bancoDados.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
            return usuario;
        }
    }
}
