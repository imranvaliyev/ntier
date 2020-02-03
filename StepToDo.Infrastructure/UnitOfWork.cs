using StepToDo.Core.Base;
using StepToDo.Core.Repositories;
using StepToDo.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepToDo.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StepToDoDbContext context;

        public UnitOfWork(StepToDoDbContext context)
        {
            this.context = context;
        }

        public IToDoItemRepository ToDoItemRepository => new ToDoItemRepository(context);
        public IToDoListRepository ToDoListRepository => new ToDoListRepository(context);

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(true);
        }

        ~UnitOfWork()
        {
            context.Dispose();
        }
    }
}
