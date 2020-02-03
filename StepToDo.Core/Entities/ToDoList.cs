using System;
using System.Collections.Generic;
using System.Text;

namespace StepToDo.Core.Entities
{
    public class ToDoList
    {
        private ToDoList()
        {
            ToDoItems = new List<ToDoItem>();
        }

        public ToDoList(string title, string color) : this()
        {
            Title = title;
            Color = color;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }

        public string UserId { get; set; }

        public ICollection<ToDoItem> ToDoItems { get; set; }
    }
}
