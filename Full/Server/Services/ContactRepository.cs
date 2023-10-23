using Full.Server.Data;
using Full.Server.Repositories;
using Full.Shared;
using Task = System.Threading.Tasks.Task;

namespace Full.Server.Services
{
    public class ContactRepository : IContactRepository
    {
        private readonly AppDbContext _context;

        public ContactRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddTaskAnswerAsync(Contact contact)
        {
            _context.Contact.Add(contact);
            await _context.SaveChangesAsync();
        }
    }
}
