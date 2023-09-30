using AutoMapper;
using Full.Server.Data;
using Full.Server.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Full.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly AppDbContext _appDbContext;
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {

            _courseRepository = courseRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var courses = await _courseRepository.GetAll();
            return Ok(courses);
        }
    }
}
