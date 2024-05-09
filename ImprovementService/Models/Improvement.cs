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
        public string? Prioridade { get; set; }
        public bool? Status { get; set; }
        [Required]
        public required string ProjetoID { get; set; }
    }
}
