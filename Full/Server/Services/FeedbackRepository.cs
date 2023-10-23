using Full.Server.Data;
using Full.Server.Repositories;
using Full.Shared;
using Microsoft.EntityFrameworkCore;

namespace Full.Server.Services
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext _context;
        public FeedbackRepository(AppDbContext context) => _context = context;
        public async Task<List<Feedback>> GetFeedbackListAsync(int educationId) => await _context.Feedback.Include(e => e.Education).Include(u => u.User).Where(f => f.Education.Id == educationId).ToListAsync();
    }
}
