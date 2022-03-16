using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Core.Models;

namespace Todo.Data.Configurations
{
    public class TodosConfiguration : IEntityTypeConfiguration<Todos>
    {
        public void Configure(EntityTypeBuilder<Todos> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(150);
            builder.Property(x => x.IsDone).IsRequired();
            builder.ToTable("Todos");
        }
    }
}
