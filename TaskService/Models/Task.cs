using System.ComponentModel.DataAnnotations;

namespace TaskService.Models
{
    public class Task
    {
        [Key]
        public required int Id { get; set; }
        [Required]
        [StringLength(100)]
        public required string Nome { get; set; }
        [StringLength(500)]
        public required string Descricao { get; set; }
        [Required(ErrorMessage = "A prioridade é obrigatória.")]
        public required Prioridade Prioridade { get; set; }
        [Required(ErrorMessage = "O estado da tarefa é obrigatório.")]
        public required Status Status { get; set; }
        [Required]
        public required string Prazo { get; set; }
        [Required]
        public required string Responsavel { get; set; }
        [Required]
        public required string Criador { get; set; }
        [Required]
        public int ImprovementID { get; set; }
        [Required]
        public int ProjectID { get; set; }
    }
}
