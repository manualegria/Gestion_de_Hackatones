using Hackatones.Shared.Entities;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
