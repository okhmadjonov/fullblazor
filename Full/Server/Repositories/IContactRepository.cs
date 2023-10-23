using Full.Shared;
using Task = System.Threading.Tasks.Task;

namespace Full.Server.Repositories
{
    public interface IContactRepository
    {
        Task AddTaskAnswerAsync(Contact contact);
    }
}
