using Microsoft.EntityFrameworkCore;
using SchoolDistrictTracker.Data.Entities;
using SchoolDistrictTracker.Domain.Interfaces;
using SchoolDistrictTracker.Domain.Models;

namespace SchoolDistrictTracker.Data.DataConfig
{
    internal class SchoolDistrictTrackerContext : DbContext
    {
        public DbSet<SchoolDTO> Schools { get; set; } = null!;

        private readonly IConfig _config;

        private readonly string _configSection;

        public SchoolDistrictTrackerContext(IConfig config, string configSection)
        {
            _config = config;
            _configSection = configSection;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_config.GetConnectionString(_configSection));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolDTO>()
                .HasMany(s => s.Courses)
                .WithOne()
                .HasForeignKey(c => c.SchoolId);
        }
    }
}
