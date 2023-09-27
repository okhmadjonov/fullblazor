using AutoMapper;
using Full.Server.Data;
using Full.Server.DTO;
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

        public CourseController(IMapper mapper, AppDbContext appDbContext)
        {
            _mapper = mapper;
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetAllCourses()
        {
            var courses = await _appDbContext.Course.ToListAsync();
            var coursesDTO = _mapper.Map<CourseDTO>(courses);
            return Ok(coursesDTO);
        }
    }
}
