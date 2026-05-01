using MuralFatecDomain.Enitities;
using System.Collections.Generic;

namespace MuralFatecDomain.Contracts.Repositories
{
    public interface IProfessorRepository
    {
        IEnumerable<ProfessorEntity> Listar();
        void Incluir(ProfessorEntity professor);
        void Alterar(ProfessorEntity professor);
        void Excluir(int id);
        ProfessorEntity Obter(int id);
        bool Salvar();
    }
}