using TaskService.Data;
using TaskService.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TaskService.Services
{
    public class TaskService(AppDbContext appDbContext) : ITaskService
    {
        public async Task<Models.Task> CreateTaskAsync(Models.Task task)
        {
            if (task == null) throw new ArgumentException("O modelo de tarefa está vazio");

            var checkTask = await GetTaskByIdAsync(task.Id);
            if (checkTask != null) throw new InvalidOperationException("Esta tarefa já está registrada");

            //Salva o projeto
            var newTask = new Models.Task
            {
                Nome = task.Nome,
                Descricao = task.Descricao,
                Prioridade = task.Prioridade,
                Status = task.Status,
                Prazo = task.Prazo,
                Responsavel = task.Responsavel,
                Criador = task.Criador,
                ImprovementID = task.ImprovementID,
                ProjectID = task.ProjectID
            };

            appDbContext.Tasks.Add(newTask);
            await appDbContext.SaveChangesAsync();

            return newTask;
        }

        public async Task DeleteTaskAsync(int id)
        {
            var task = await appDbContext.Tasks.FindAsync(id);
            if (task == null) throw new KeyNotFoundException("Tarefa não encontrada");

            appDbContext.Tasks.Remove(task);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Models.Task>> GetAllTasksAsync()
        {
            return await appDbContext.Tasks.ToListAsync();
        }

        public async Task<Models.Task> GetTaskByIdAsync(int id)
        {
            var task = await appDbContext.Tasks.FirstOrDefaultAsync(x => x.Equals(x.Id == id));
            if (task == null) throw new KeyNotFoundException("Tarefa não encontrada");

            return task;
        }

        public async Task UpdateTaskAsync(Models.Task task)
        {
            if (task == null) throw new ArgumentException("O modelo de projeto está vazio");
            var checkTask = await appDbContext.Tasks.FindAsync(task.Id);
            if (checkTask == null) throw new KeyNotFoundException("Projeto não encontrado.");

            // Atualiza o projeto
            checkTask.Nome = task.Nome;
            checkTask.Descricao = task.Descricao;
            checkTask.Prioridade = task.Prioridade;
            checkTask.Status = task.Status;
            checkTask.Prazo = task.Prazo;
            checkTask.Responsavel = task.Responsavel;
            checkTask.Criador = task.Criador;
            checkTask.ImprovementID = task.ImprovementID;
            checkTask.ProjectID = task.ProjectID;


            appDbContext.Tasks.Update(checkTask);
            await appDbContext.SaveChangesAsync();
        }
    }
}
