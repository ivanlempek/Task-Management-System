using System.ComponentModel.DataAnnotations;

namespace Client.DTOs
{
    public class ProjectDTO
    {
        public required int Id { get; set; }
        public required string Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataLancamento { get; set; }
        public required Status Status { get; set; }
        public string? Fundador { get; set; }
    }
}
