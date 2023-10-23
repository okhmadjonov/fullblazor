namespace Full.Server.Repositories;

public interface ITaskRepository
{
    Task<List<Full.Shared.Task>> GetAllTaskAsync();
    Task<Full.Shared.Task> GetTaskByIdAsync(int id);
}