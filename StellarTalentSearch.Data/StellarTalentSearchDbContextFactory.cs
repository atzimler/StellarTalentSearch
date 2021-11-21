using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StellarTalentSearch.Data
{
    public class StellarTalentSearchDbContextFactory : IDesignTimeDbContextFactory<StellarTalentSearchDbContext>
    {
        public StellarTalentSearchDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StellarTalentSearchDbContext>();
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            var connectionString = "Data Source=sts_db; Database=master;User=sa;Password=password123!;";
            optionsBuilder.UseSqlServer(connectionString);

            return new StellarTalentSearchDbContext(optionsBuilder.Options);
        }
    }
}