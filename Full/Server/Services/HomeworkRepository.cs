using Full.Server.Data;
using Full.Server.Repositories;
using Full.Shared;
using Microsoft.EntityFrameworkCore;

namespace Full.Server.Services
{
    public class HomeworkRepository : IHomeworkRepository
    {
        private readonly AppDbContext _context;

        public HomeworkRepository(AppDbContext context) => _context = context;


        public async Task<List<Homework>> GetAllHomeworkAsync()
        {
            return await _context.Homework.Include(h => h.Task).ToListAsync();
        }

        public async Task<Homework> GetHomeworkByIdAsync(int id)
        {
            return (await _context.Homework.Include(h => h.Task).FirstOrDefaultAsync(h => h.Id == id))!;
        }


    }
}
