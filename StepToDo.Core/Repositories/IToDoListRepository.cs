using StepToDo.Core.Base;
using StepToDo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepToDo.Core.Repositories
{
    public interface IToDoListRepository : IRepository<ToDoList>
    {
        IEnumerable<ToDoList> GetAllByUserId(string userId);
    }
}
