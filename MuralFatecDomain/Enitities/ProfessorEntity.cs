using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MuralFatecDomain.Contracts;


namespace MuralFatecDomain.Enitities
{
    [Table("Professores")]
    public class ProfessorEntity : UsuarioEntity
    {
        public virtual ICollection<MensagemEntity> Mensagens { get; set; }
    }
}
