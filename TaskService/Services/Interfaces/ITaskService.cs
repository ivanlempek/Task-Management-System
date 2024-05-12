namespace TaskService.Services.Interfaces
{
    public interface ITaskService
    {
        Task<IEnumerable<Models.Task>> GetAllTasksAsync();
        Task<Models.Task> GetTaskByIdAsync(int id);
        Task<Models.Task> CreateTaskAsync(Models.Task project);
        Task UpdateTaskAsync(Models.Task project);
        Task DeleteTaskAsync(int id);
    }
}
