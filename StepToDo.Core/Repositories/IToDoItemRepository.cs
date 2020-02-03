using StepToDo.Core.Base;
using StepToDo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepToDo.Core.Repositories
{
    public interface IToDoItemRepository : IRepository<ToDoItem>
    {
        IEnumerable<ToDoItem> GetAllByListId(string listId);
    }
}
