using System.ComponentModel.DataAnnotations;

namespace ImprovementService.Models
{
    public class Improvement
    {
        [Key]
        public required int Id { get; set; }
        [Required]
        [StringLength(100)]
        public required string Nome { get; set; }
        [StringLength(500)]
        public string? Descricao { get; set; }
        public required Prioridade Prioridade { get; set; }
        public required Status Status { get; set; }
        [Required]
        public required int ProjectID { get; set; }
    }
}
