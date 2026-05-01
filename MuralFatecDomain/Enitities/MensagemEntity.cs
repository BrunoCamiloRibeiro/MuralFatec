using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MuralFatecDomain.Contracts;

namespace MuralFatecDomain.Enitities
{
    [Table("Mensagens")]
    public class MensagemEntity : IEntity
    {
        // MensagemID
        [Display(Name = "MensagemID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Professor
        public int ProfessorId { get; set; }
        [ForeignKey(nameof(ProfessorId))]
        public virtual ProfessorEntity Professor { get; set; }

        // Curso
        public int CursoId { get; set; }
        [ForeignKey(nameof(CursoId))]
        public virtual CursoEntity Curso { get; set; }

        // Disciplina (Não faço ideia de como fazer isso ser lógico)
        public int DisciplinaId { get; set; }
        [ForeignKey(nameof(DisciplinaId))]
        public virtual DisciplinaEntity Disciplina { get; set; }

        // Titulo
        [Display(Name = "Titulo")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [DataType(DataType.Text)]
        public string Titulo { get; set; }

        // Corpo da mensagem
        [Display(Name = "Mensagem")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [DataType(DataType.MultilineText)]
        public string Corpo { get; set; }

        public virtual ICollection<AnexoEntity> Anexos { get; set; }
        public virtual ICollection<TagMensagemEntity> Tags { get; set; } 

        // Data
        [Display(Name = "Data de Publicação")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public bool Ativo { get; set; }

        public MensagemEntity()
        {
            DataCadastro = DateTime.Now;
            Ativo = true;
        }
    }
}
