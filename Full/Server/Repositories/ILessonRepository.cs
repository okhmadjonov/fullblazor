
using Full.Shared;

namespace Full.Server.Repositories;

public interface ILessonRepository
{
    Task<List<Lesson>> GetLessonByCourseIdAsync(int courseId);
}