using Full.Server.Data;
using Full.Server.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Full.Server.Services
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;

        public TaskRepository(AppDbContext context) => _context = context;

        public async Task<List<Full.Shared.Task>> GetAllTaskAsync()
        {
            return await _context.Task.ToListAsync();
        }

        public async Task<Full.Shared.Task> GetTaskByIdAsync(int id)
        {
            return await _context.Task.FirstOrDefaultAsync(t => t.Id == id);
        }
    }
}
