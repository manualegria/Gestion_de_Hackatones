using Hackatones.Shared.Entities;
using Hackatones.Shered.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hackatones.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Award> Awards { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<MentorHackaton> MentorHackatons { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamAward> TeamAwards { get; set; }
        public DbSet<TeamParticipant> TeamParticipants { get; set; }
        public DbSet<TeamMentor> TeamMentors { get; set; }
        public DbSet<Hackaton> Hackatons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
