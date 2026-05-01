using MuralFatecDomain.Enitities;
using System.Collections.Generic;

namespace MuralFatecDomain.Contracts.Repositories
{
    public interface IMensagemRepository
    {
        IEnumerable<MensagemEntity> Listar();
        void Incluir(MensagemEntity mensagem);
        void Alterar(MensagemEntity mensagem);
        void Excluir(int id);
        MensagemEntity Obter(int id);
        bool Salvar();
    }
}
