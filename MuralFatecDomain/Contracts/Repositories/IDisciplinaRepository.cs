using MuralFatecDomain.Enitities;
using System.Collections.Generic;

namespace MuralFatecDomain.Contracts.Repositories
{
    public interface IDisciplinaRepository
    {
        IEnumerable<DisciplinaEntity> Listar();
        void Incluir(DisciplinaEntity disciplina);
        void Alterar(DisciplinaEntity disciplina);
        void Excluir(int id);
        DisciplinaEntity Obter(int id);
        bool Salvar();
    }
}