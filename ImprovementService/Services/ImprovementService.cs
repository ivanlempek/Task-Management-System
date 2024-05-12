using ImprovementService.Data;
using ImprovementService.Models;
using ImprovementService.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ImprovementService.Services
{
    public class ImprovementService(AppDbContext appDbContext) : IImprovementService
    {
        public async Task<Improvement> CreateImprovementAsync(Improvement improvement)
        {
            if (improvement == null) throw new ArgumentException("O modelo de melhoria está vazio");

            var checkImprovement = await GetImprovementByIdAsync(improvement.Id);
            if (checkImprovement != null) throw new InvalidOperationException("Esta melhoria já está registrada");

            //Salva a melhoria
            var newImprovement = new Improvement()
            {
                Nome = improvement.Nome,
                Descricao = improvement.Descricao,
                Prioridade = improvement.Prioridade,
                Status = improvement.Status,
                ProjectID = improvement.ProjectID
            };

            appDbContext.Improvements.Add(newImprovement);
            await appDbContext.SaveChangesAsync();  

            return newImprovement;
        }

        public async Task DeleteImprovementAsync(int id)
        {
            var improvement = await appDbContext.Improvements.FindAsync(id);
            if (improvement == null) throw new KeyNotFoundException("Melhoria não encontrada");

            appDbContext.Improvements.Remove(improvement);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Improvement>> GetAllImprovementsAsync()
        {
            return await appDbContext.Improvements.ToListAsync();
        }

        public async Task<Improvement> GetImprovementByIdAsync(int id)
        {
            var improvement = await appDbContext.Improvements.FirstOrDefaultAsync(x => x.Equals(x.Id == id));
            if (improvement == null) throw new KeyNotFoundException("Melhoria não encontrada");

            return improvement;
        }

        public async Task UpdateImprovementAsync(Improvement improvement)
        {
            if (improvement == null) throw new ArgumentException("O modelo de melhoria está vazio");
            var checkImprovement = await appDbContext.Improvements.FindAsync(improvement.Id);
            if (checkImprovement == null) throw new KeyNotFoundException("Melhoria não encontrada.");

            // Atualiza a melhoria
            checkImprovement.Nome = improvement.Nome;
            checkImprovement.Descricao = improvement.Descricao;
            checkImprovement.Prioridade = improvement.Prioridade;
            checkImprovement.Status = improvement.Status;
            checkImprovement.ProjectID = improvement.ProjectID;

            appDbContext.Improvements.Update(checkImprovement);
            await appDbContext.SaveChangesAsync();
        }
    }
}
