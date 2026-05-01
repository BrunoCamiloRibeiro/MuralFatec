using MuralFatecDomain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuralFatecDomain.Contracts.Repositories
{
    public interface UsuarioRepository
    {
        IEnumerable<InstituicaoEntity> Listar();
        void Incluir(InstituicaoEntity instuicao);
        void Alterar(InstituicaoEntity instuicao);
        void Excluir(int id);
        InstituicaoEntity Obter(int id);
        bool Salvar();
    }
}
