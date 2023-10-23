using Full.Shared;

namespace Full.Server.Repositories;

public interface ITestRepository
{
    Task<List<Test>> GetTestListAsync(int lessonId);
}
