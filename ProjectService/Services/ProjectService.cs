using Microsoft.EntityFrameworkCore;
using ProjectService.Data;
using ProjectService.Models;
using ProjectService.Services.Interfaces;

namespace ProjectService.Services
{
    public class ProjectService(AppDbContext appDbContext) : IProjectService
    {
        public async Task<Project> CreateProjectAsync(Project project)
        {
            if (project == null) throw new ArgumentException("O modelo de projeto está vazio");

            var checkProject = await GetProjectByIdAsync(project.Id);
            if (checkProject != null) throw new InvalidOperationException("Este projeto já está registrado");

            //Salva o projeto
            var newProject = new Project()
            {
                Nome = project.Nome,
                Descricao = project.Descricao,
                DataInicio = project.DataInicio,
                DataLancamento = project.DataLancamento,
                Status = project.Status,
                Fundador = project.Fundador
            };

            appDbContext.Projects.Add(newProject);
            await appDbContext.SaveChangesAsync();

            return newProject;
        }

        public async Task DeleteProjectAsync(int id)
        {
            var project = await appDbContext.Projects.FindAsync(id);
            if (project == null) throw new KeyNotFoundException("Projeto não encontrado");

            appDbContext.Projects.Remove(project);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            return await appDbContext.Projects.ToListAsync();
        }

        public async Task<Project> GetProjectByIdAsync(int id)
        {
            var project = await appDbContext.Projects.FirstOrDefaultAsync(x => x.Equals(x.Id == id));
            if (project == null) throw new KeyNotFoundException("Projeto não encontrado");

            return project;
        }

        public async Task UpdateProjectAsync(Project project)
        {
            if (project == null) throw new ArgumentException("O modelo de projeto está vazio");
            var checkProject = await appDbContext.Projects.FindAsync(project.Id);
            if (checkProject == null) throw new KeyNotFoundException("Projeto não encontrado.");

            // Atualiza o projeto
            checkProject.Nome = project.Nome;
            checkProject.Descricao = project.Descricao;
            checkProject.DataInicio = project.DataInicio;
            checkProject.DataLancamento = project.DataLancamento;
            checkProject.Status = project.Status;
            checkProject.Fundador = project.Fundador;

            appDbContext.Projects.Update(checkProject);
            await appDbContext.SaveChangesAsync();
        }
    }
}
