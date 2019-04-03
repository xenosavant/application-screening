using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Infrastructure.Data.Configurations
{
    class JobApplicationEntityTypeConfiguration : IEntityTypeConfiguration<JobApplication>
    {
        public void Configure(EntityTypeBuilder<JobApplication> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("newid()");
            builder.Property(x => x.Name).IsRequired();

            builder.HasMany(x => x.Responses).WithOne();
        }
    }
}
