using Full.Server.Data;
using Full.Server.Repositories;
using Full.Shared;
using Microsoft.EntityFrameworkCore;

namespace Full.Server.Services
{
    public class TeacherService : ITeacherRepository
    {

        private readonly AppDbContext _appDbContext;

        public TeacherService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Teacher>> GetAllTeachers()
        {
            return await _appDbContext.Teacher.ToListAsync();
        }
    }
}
