using MuralFatecDomain.Enitities;
using System.Collections.Generic;

namespace MuralFatecDomain.Contracts.Repositories
{
    public interface ITagRepository
    {
        IEnumerable<TagEntity> Listar();
        void Incluir(TagEntity tag);
        void Alterar(TagEntity tag);
        void Excluir(int id);
        TagEntity Obter(int id);
        bool Salvar();
    }
}