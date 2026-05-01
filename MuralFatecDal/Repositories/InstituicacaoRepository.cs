using MuralFatecDal.Data;
using MuralFatecDomain.Contracts.Repositories;
using MuralFatecDomain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuralFatecDal.Repositories
{
    public class InstituicacaoRepository : IInstituicaoRepository
    {
        private readonly SqlServerData _bancoDados;

        public InstituicacaoRepository(SqlServerData bancoDados)
        {
            _bancoDados = bancoDados;
        }

        public void Incluir(InstituicaoEntity instituicao)
        {
            //sql insert = add
            _bancoDados.Instituicoes.Add(instituicao);
            //executar o comando
            _bancoDados.SaveChanges();
        }

        public IEnumerable<InstituicaoEntity> Listar()
        {
            //sql select all = ToList 
            return _bancoDados.Instituicoes.ToList();
        }

        public void Alterar(InstituicaoEntity instituicao)
        {
            //sql update = update
            _bancoDados.Instituicoes.Update(instituicao);
            //executar o comando
            _bancoDados.SaveChanges();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }



        public InstituicaoEntity Obter(int id)
        {
            throw new NotImplementedException();
        }

        public bool Salvar()
        {
            throw new NotImplementedException();
        }
    }
}
