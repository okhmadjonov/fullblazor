using Full.Server.Repositories;
using Full.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Full.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(Contact contact)
        {
            await _contactRepository.AddTaskAnswerAsync(contact);
            return Ok();
        }
    }
}
