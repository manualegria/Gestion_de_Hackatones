using Hackatones.Shared.Entities;
using Hackatones.Shered.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hackatones.API.Data
{
    public class SeedDb
    {
        private readonly  DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;  
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckMentorAsync();

            
        }

        private async Task CheckMentorAsync()
        {
            if (!_context.Mentors.Any())
            {

                _context.Mentors.Add(new Mentor { Name = "Pepito" });
                _context.Mentors.Add(new Mentor { LastName = "Perez" });
                _context.Mentors.Add(new Mentor { Email = "PepitoPerez@test.com" });
                _context.Mentors.Add(new Mentor { Phone = "3128341232" });
                _context.Mentors.Add(new Mentor { Epecialty = "AWS" });
   
            }
            await _context.SaveChangesAsync();
        }
       
    }
}
