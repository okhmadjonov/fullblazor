using Full.Shared;

namespace Full.Server.Repositories
{
    public interface ITeacherRepository
    {
        Task<List<Teacher>> GetAllTeachers();
    }
}
