using MuralFatecDomain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuralFatecDomain.Contracts.Repositories
{
    public interface IInstituicaoRepository
    {
        IEnumerable<InstituicaoEntity> Listar();
        void Incluir(InstituicaoEntity instituicao);
        void Alterar(InstituicaoEntity instituicao);
        void Excluir(int id);
        InstituicaoEntity Obter(int id);
        bool Salvar();
    }
}
