using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using MuralFatecDomain.Contracts;

namespace MuralFatecDomain.Enitities
{
    [Table("Instituicoes")]
    public class InstituicaoEntity : IEntity
    {
        //propriedades
        //Pk
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")] //not null
        [DataType(DataType.Text)]
        public string Nome { get; set; }

        [Display(Name = "Endereço")]
        [AllowNull]
        [DataType(DataType.Text)]
        public string Endereco { get; set; }

        [AllowNull]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Campo obrigatório!")] //not null
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [AllowNull]
        [DataType(DataType.Text)]
        public string Sigla { get; set; }

        [Display(Name = "Data de cadastro")]
        [Required(ErrorMessage = "Campo obrigatório!")] //not null
        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")] //not null
        public bool Ativo { get; set; }

        //FK N
        public virtual ICollection<UsuarioEntity> Usuarios { get; set; }

        //metodos
        public InstituicaoEntity()
        {
            //configuracao padrao
            DataCadastro = DateTime.Now; // dia de criacao do objeto
            Ativo = true;
        }
    }
}
