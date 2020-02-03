using StepToDo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepToDo.Presentation.ViewModels
{
    public class TasksPageViewModel
    {
        public string CurrentListId { get; set; }

        public IEnumerable<ToDoList> ToDoLists { get; set; } = new List<ToDoList>();
        
        public IEnumerable<ToDoItem> CurrentListToDoItems { get; set; } = new List<ToDoItem>();

        public AddToDoItemViewModel NewItem { get; set; }

        public AddToDoListViewModel NewList { get; set; }
    }
}
