using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MuralFatecDomain.Contracts;
using System.Globalization;

namespace MuralFatecDomain.Enitities
{
    [Table("Tags")]
    public class TagEntity : IEntity
    {
        [Display(Name = "TagID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Nome da Tag")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [DataType(DataType.Text)]
        public string Nome { get; set; }

        [Display(Name = "Cor da Tag")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Cor {  get; set; }

        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public bool Ativo { get; set; }

        public TagEntity() 
        {
            DataCadastro = DateTime.Now;
            Ativo = true;
        }
    }
}
