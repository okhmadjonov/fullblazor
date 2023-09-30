using Full.Server.Data;
using Full.Server.Repositories;
using Full.Shared;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace Full.Server.Services
{
    public class CourseService : ICourseRepository
    {
        private readonly AppDbContext _context;

        public CourseService(AppDbContext context)
        {
            _context = context;
        }

        public Task Add(Course course)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Course> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Course>> GetAll()
        {
            return await _context.Course.ToListAsync();

        }

        public Task Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
