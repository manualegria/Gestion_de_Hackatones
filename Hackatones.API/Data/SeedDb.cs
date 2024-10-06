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

                _context.Mentors.Add(new Mentor
                { Name = "Pepito",
                    LastName = "Perez",
                    Email = "PepitoPerez@test.com",
                    Phone = "3128341232",
                    Epecialty = "AWS"
                });
              
   
            }
            await _context.SaveChangesAsync();
        }
       
    }
}
