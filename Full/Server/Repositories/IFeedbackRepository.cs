

using Full.Shared;

namespace Full.Server.Repositories
{
    public interface IFeedbackRepository
    {
        Task<List<Feedback>> GetFeedbackListAsync(int educationId);
    }
}
