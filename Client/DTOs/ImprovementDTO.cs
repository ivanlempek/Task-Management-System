using System.ComponentModel.DataAnnotations;

namespace Client.DTOs
{
    public class ImprovementDTO
    {
        public required int Id { get; set; }
        public required string Nome { get; set; }
        public string? Descricao { get; set; }
        public required Prioridade Prioridade { get; set; }
        public required Status Status { get; set; }
        public required int ProjectID { get; set; }
    }
}
