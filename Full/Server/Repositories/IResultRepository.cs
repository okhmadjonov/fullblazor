using Full.Shared;

namespace Full.Server.Repositories
{
    public interface IResultRepository
    {
        Task<List<Result>> GetResultListAsync(int educationId);
    }
}
