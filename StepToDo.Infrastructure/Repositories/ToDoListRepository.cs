using StepToDo.Core.Entities;
using StepToDo.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepToDo.Infrastructure.Repositories
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly StepToDoDbContext context;

        public ToDoListRepository(StepToDoDbContext context)
        {
            this.context = context;
        }

        public ToDoList Get(string id)
        {
            var item = context.ToDoLists.Find(id);

            if (item == null)
                throw new Exception("Not found!");

            return item;
        }

        public IEnumerable<ToDoList> GetAllByUserId(string userId)
        {
            return context.ToDoLists.Where(x => x.UserId == userId).ToList();
        }

        public IEnumerable<ToDoList> GetAll()
        {
            return context.ToDoLists.ToList();
        }

        public void Create(ToDoList item)
        {
            context.ToDoLists.Add(item);
        }

        public void Delete(ToDoList item)
        {
            context.ToDoLists.Remove(item);
        }

        public void Update(ToDoList item)
        {
            context.ToDoLists.Update(item);
        }
    }
}
