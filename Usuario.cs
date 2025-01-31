// CRIE UMA CLASSE USU�RIO

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
        [Required(ErrorMessage = "Nome inv�lido")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Minimo 4, M�ximo de 50 caracteres")]
        [RegularExpression(@"^[A-Za-z�������������������������������'\s]+$", ErrorMessage = "Nome inv�lido")]
        public string Nome { get; set; }


        [Display(Name = "CPF: ")]
        [Required(ErrorMessage = "CPF obrigat�rio")]
        [CustomValidationCPF(ErrorMessage = "CPF inv�lido")]
        public string Cpf { get; set; }

    }

