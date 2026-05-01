using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MuralFatecDomain.Contracts;

namespace MuralFatecDomain.Enitities
{
    [Table("Anexos")]
    public class AnexoEntity : IEntity
    {
        [Display(Name = "AnexoID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Mensagem
        public int MensagemId { get; set; }
        [ForeignKey(nameof(MensagemId))]
        public virtual MensagemEntity Mensagem { get; set; }

        // Nome do Arquivo
        [Display(Name = "Nome do Arquivo")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [DataType(DataType.Text)]
        public string NomeArquivo { get; set; }

        // Extensão do Arquivo
        [Display(Name = "Extensão do Arquivo")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [DataType(DataType.Text)]
        public string ExtensaoArquivo { get; set; }

        // Tamanho do Arquivo
        [Display(Name = "Tamanho do Arquivo")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [Range(1, 50000000, ErrorMessage = "O arquivo deve ter no máximo 50MB")]
        public long TamanhoArquivo { get; set; }

        // Path do Arquivo
        [Display(Name = "Caminho do Arquivo")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [DataType(DataType.Text)]
        public string PathArquivo { get; set; }

        // Data de Publicação
        [Display(Name = "Data de Publicação")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public DateTime DataCadastro { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        public bool Ativo { get; set; }

        public AnexoEntity()
        {
            DataCadastro = DateTime.Now;
            Ativo = true;
        }
    }
}