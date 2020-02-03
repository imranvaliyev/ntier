using JetBrains.Annotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StepToDo.Core.Entities;
using StepToDo.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace StepToDo.Infrastructure
{
    public class StepToDoDbContext : IdentityDbContext<IdentityUser>
    {
        public StepToDoDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
    }
}
