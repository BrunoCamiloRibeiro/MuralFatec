using MuralFatecDomain.Values;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MuralFatecDomain.Contracts;

namespace MuralFatecDomain.Enitities
{
    [Table("Usuarios")]
    public class UsuarioEntity : IEntity
    {
        //propriedades
        //Pk
        [Display(Name = "Codigo")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name ="E-mail")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Perfil da conta")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public PerfilValue Perfil { get; set; }

        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public bool Ativo { get; set; }

        //FK 1
        public int InstituicaoId { get; set; }
        [ForeignKey(nameof(InstituicaoId))]
        public virtual InstituicaoEntity Instituicao { get; set; }

        //metodos
        public UsuarioEntity()
        {
            DataCadastro = DateTime.Now;
            Ativo = true;
        }
    }
}
