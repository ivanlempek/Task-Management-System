using System.ComponentModel.DataAnnotations;

namespace ProjectService.Models
{
    public class Project
    {
        [Key]
        public required int Id { get; set; }
        [Required]
        [StringLength(100)]
        public required string Nome { get; set; }
        [StringLength(500)]
        public string? Descricao { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataLancamento { get; set; }
        public required Status Status { get; set; }
        public string? Fundador { get; set; }
    }
}
