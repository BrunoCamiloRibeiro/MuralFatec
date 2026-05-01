using Microsoft.EntityFrameworkCore;
using MuralFatecDomain.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MuralFatecDomain.Enitities
{
    [Table("Tag_Mensagem")]
    [PrimaryKey(nameof(MensagemId), nameof(TagId))]
    public class TagMensagemEntity
    {
        public int MensagemId { get; set; }
        [ForeignKey(nameof(MensagemId))]
        public virtual MensagemEntity Mensagem { get; set; }

        public int TagId { get; set; }
        [ForeignKey(nameof(TagId))]
        public virtual TagEntity Tag { get; set; }
    }
}
