// CRIE UMA CLASSE USUÁRIO

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeuSite.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Required(ErrorMessage = "Id requerido")]
        public int UsuarioId { get; set; }

        [Display(Name = "Nome: ")]
        [Required(ErrorMessage = "Nome inválido")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Minimo 4, Máximo de 50 caracteres")]
        [RegularExpression(@"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ'\s]+$", ErrorMessage = "Nome inválido")]
        public string Nome { get; set; }


        [Display(Name = "CPF: ")]
        [Required(ErrorMessage = "CPF obrigatório")]
        [CustomValidationCPF(ErrorMessage = "CPF inválido")]
        public string Cpf { get; set; }

    }

