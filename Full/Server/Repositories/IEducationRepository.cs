

using Full.Shared;

namespace Full.Server.Repositories
{
    public interface IEducationRepository
    {
        Task<Education> GetEducationById(int courseId);
    }
}
