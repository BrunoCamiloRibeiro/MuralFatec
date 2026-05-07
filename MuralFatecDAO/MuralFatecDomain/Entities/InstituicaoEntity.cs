using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MuralFatecDomain.Entities
{
    [Table("Instituicoes")]
    public class InstituicaoEntity
    {
        // Propriedades
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio idiota")]
        [DataType(DataType.Text)]
        public string Nome { get; set; }

        [Display(Name = "Endereço")]
        [AllowNull]
        [DataType(DataType.Text)]
        public string Endereco { get; set; }

        [AllowNull]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [AllowNull]
        [DataType(DataType.Text)]
        public string Sigla { get; set; }

        [Display(Name = "DATA DE CADASTRO")]
        [Required(ErrorMessage = "PQP")]
        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }

        [Required]
        public bool Ativo { get; set; }

        // Metodos
        public InstituicaoEntity()
        {
                // ELE MUDOU A PORRA TODA DENOVO AAHAHAHAHAHAHAHAHAHAHAHHAHAHAHAHAHAHAHAH
                DataCadastro = DateTime.Now;
                Ativo = true;
        }

    }
}
