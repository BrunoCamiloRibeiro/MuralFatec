using MuralFatecDomain.Enitities;
using System.Collections.Generic;

namespace MuralFatecDomain.Contracts.Repositories
{
    public interface ICursoRepository
    {
        IEnumerable<CursoEntity> Listar();
        void Incluir(CursoEntity curso);
        void Alterar(CursoEntity curso);
        void Excluir(int id);
        CursoEntity Obter(int id);
        bool Salvar();
    }
}