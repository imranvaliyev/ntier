using StepToDo.Core.Entities;
using StepToDo.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepToDo.Infrastructure.Repositories
{
    public class ToDoItemRepository : IToDoItemRepository
    {
        private readonly StepToDoDbContext context;

        public ToDoItemRepository(StepToDoDbContext context)
        {
            this.context = context;
        }

        public ToDoItem Get(string id)
        {
            var item = context.ToDoItems.Find(id);

            if (item == null)
                throw new Exception("Not found!");
            
            return item;
        }

        public IEnumerable<ToDoItem> GetAllByListId(string listId)
        {
            return context.ToDoItems.Where(x => x.ToDoListId == listId).ToList();
        }

        public IEnumerable<ToDoItem> GetAll()
        {
            return context.ToDoItems.ToList();
        }

        public void Create(ToDoItem item)
        {
            context.ToDoItems.Add(item);
        }

        public void Delete(ToDoItem item)
        {
            context.ToDoItems.Remove(item);
        }

        public void Update(ToDoItem item)
        {
            context.ToDoItems.Update(item);
        }
    }
}
