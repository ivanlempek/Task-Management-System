using ImprovementService.Models;

namespace ImprovementService.Services.Interfaces
{
    public interface IImprovementService
    {
        Task<IEnumerable<Improvement>> GetAllImprovementsAsync();
        Task<Improvement> GetImprovementByIdAsync(int id);
        Task<Improvement> CreateImprovementAsync(Improvement improvement);
        Task UpdateImprovementAsync(Improvement improvement);
        Task DeleteImprovementAsync(int id);
    }
}
