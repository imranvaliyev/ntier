using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StepToDo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepToDo.Infrastructure.Configurations
{
    class ToDoListConfiguration : IEntityTypeConfiguration<ToDoList>
    {
        public void Configure(EntityTypeBuilder<ToDoList> builder)
        {
            builder.Property(u => u.Id)
                .IsRequired()
                .HasDefaultValueSql("NEWID()");

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
