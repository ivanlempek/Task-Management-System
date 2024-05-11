using System.ComponentModel.DataAnnotations;

namespace Client.DTOs
{
    public class Register : AccountBase
    {
        [Required]
        [MinLength(15)]
        public required string NomeCompleto { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Senha))]
        public string ConfirmarSenha { get; set; }
    }
}
