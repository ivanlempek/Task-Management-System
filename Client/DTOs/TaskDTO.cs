namespace Client.DTOs
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public Prioridade Prioridade { get; set; }
        public Status Status { get; set; }
        public required string Prazo { get; set; }
        public required string Responsavel { get; set; }
        public required string Criador { get; set; }
        public int ImprovementID { get; set; }
        public int ProjectID { get; set; }
    }
}

