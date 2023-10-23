

using Full.Shared;

namespace Full.Server.Repositories
{
    public interface IHomeworkRepository
    {
        Task<List<Homework>> GetAllHomeworkAsync();
        Task<Homework> GetHomeworkByIdAsync(int id);
    }
}
