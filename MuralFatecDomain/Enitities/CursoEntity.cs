using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MuralFatecDomain.Contracts;

namespace MuralFatecDomain.Enitities
{
    [Table("Cursos")]
    public class CursoEntity : IEntity
    {
        [Display(Name = "Codigo")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public bool Ativo { get; set; }

        public virtual ICollection<MensagemEntity> Mensagens { get; set; }

        public CursoEntity() 
        {
            DataCadastro = DateTime.Now;
            Ativo = true;
        }
    }
}
