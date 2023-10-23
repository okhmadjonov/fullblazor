using Full.Server.DTO;
using Task = System.Threading.Tasks.Task;

namespace Full.Server.Repositories
{
    public interface ITaskAnswerRepository
    {
        Task AddTaskAnswerAsync(TaskAnswerDTO taskAnswer);
    }
}
