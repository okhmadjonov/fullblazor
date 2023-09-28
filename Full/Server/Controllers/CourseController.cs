using AutoMapper;
using Full.Server.Data;
using Full.Server.Repositories;
using Full.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Full.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly AppDbContext _appDbContext;
        private readonly ICourseRepository _courseRepository;

        public CourseController(IMapper mapper, AppDbContext appDbContext, ICourseRepository courseRepository)
        {
            _mapper = mapper;
            _appDbContext = appDbContext;
            _courseRepository = courseRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetAllCourses()
        {
            var courses = await _appDbContext.Course.ToListAsync();
            return Ok(courses);
        }
    }
}
