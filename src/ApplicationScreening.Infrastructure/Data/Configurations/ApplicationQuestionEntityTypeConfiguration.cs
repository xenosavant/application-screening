using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Infrastructure.Data.Configurations
{
    class ApplicationQuestionEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationQuestion>
    {
        public void Configure(EntityTypeBuilder<ApplicationQuestion> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("newsqequentialid()");

            builder.OwnsOne(x => x.Answer);
        }
    }
}
