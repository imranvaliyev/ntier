using StepToDo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepToDo.Core.Services
{
    public interface IToDoService
    {
        void AddToDoList(string title, string color = "#ffffff");
        //void AddTaskToList(string listId, ToDoItem item);
        void AddTaskToList(string listId, string title);

        IEnumerable<ToDoList> GetAllCurrentUserLists();
        IEnumerable<ToDoItem> GetAllItemsByListId(string listId);
    }
}
