using Full.Server.Data;
using Full.Server.Repositories;
using Full.Shared;
using Microsoft.EntityFrameworkCore;

namespace Full.Server.Services;

public class TestRepository : ITestRepository
{
    private readonly AppDbContext _context;
    public TestRepository(AppDbContext context) => _context = context;

    public async Task<List<Test>> GetTestListAsync(int lessonId) => await _context.Test.Include(e => e.Lesson).Where(f => f.Lesson.Id == lessonId).ToListAsync();
}
