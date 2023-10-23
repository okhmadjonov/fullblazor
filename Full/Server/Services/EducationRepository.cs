using Full.Server.Data;
using Full.Server.Repositories;
using Full.Shared;
using Microsoft.EntityFrameworkCore;

namespace Full.Server.Services
{
    public class EducationRepository : IEducationRepository
    {
        private readonly AppDbContext _context;

        public EducationRepository(AppDbContext context) => _context = context;

        public async Task<Education> GetEducationById(int courseId)
        {
            var firstOrDefault = _context.Education.Include(e => e.Course).FirstOrDefault(e => e.Course.Id == courseId);
            return firstOrDefault;
        }
    }
}
