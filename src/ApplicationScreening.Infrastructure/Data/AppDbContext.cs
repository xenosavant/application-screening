using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using ApplicationScreening.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationQuestion> ApplicationQuestions { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<Response> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationQuestionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JobApplicationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ResponseEntityTypeConfiguration());
        }
    }
}
