using Full.Server.Data;
using Full.Server.Repositories;
using Full.Shared;
using Microsoft.EntityFrameworkCore;

namespace Full.Server.Services;

public class LessonRepository : ILessonRepository
{
    private readonly AppDbContext _context;

    public LessonRepository(AppDbContext context) => _context = context;

    public async Task<List<Lesson>> GetLessonByCourseIdAsync(int courseId)
    {
        var course = await _context.Lesson.Where(l => l.Course.Id == courseId).ToListAsync();
        return course;
    }
}