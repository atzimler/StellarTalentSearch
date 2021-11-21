using Microsoft.EntityFrameworkCore;
using StellarTalentSearch.Domain;

namespace StellarTalentSearch.Data
{
    public class StellarTalentSearchDbContext : DbContext
    {
        public DbSet<DescriptionItem> DescriptionItems { get; set; }
        public DbSet<JobDescription> JobDescriptions { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<JobVacancy> JobVacancies { get; set; }

        public StellarTalentSearchDbContext(DbContextOptions<StellarTalentSearchDbContext> options)
            : base(options)
        {
        }
    }
}