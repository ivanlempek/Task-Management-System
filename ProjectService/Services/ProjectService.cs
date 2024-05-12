using ProjectService.Data;
using ProjectService.Models;
using ProjectService.Services.Interfaces;

namespace ProjectService.Services
{
    public class ProjectService(AppDbContext appDbContext) : IProjectService
    {
        public async Task<Project> CreateProjectAsync(Project project)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProjectAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Project> GetProjectByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProjectAsync(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
