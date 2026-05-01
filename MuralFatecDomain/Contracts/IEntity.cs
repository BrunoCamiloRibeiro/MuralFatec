using System;
using System.Collections.Generic;
using System.Text;

namespace MuralFatecDomain.Contracts
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime DataCadastro { get; set; }
        bool Ativo {  get; set; }
    }
}
