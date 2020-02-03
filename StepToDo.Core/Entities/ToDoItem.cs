using StepToDo.Core.Enums;
using StepToDo.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepToDo.Core.Entities
{
    public class ToDoItem
    {
        private DateTime? deadline;

        private ToDoItem()
        {

        }

        public ToDoItem(string title, DateTime? deadline = null, string description = "", Priority priority = Priority.Low)
        {
            //Id = Guid.NewGuid().ToString();
            Title = title;
            Deadline = deadline;
            Description = description;
            Priority = priority;
            Done = false;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Done { get; private set; }

        public DateTime? Deadline 
        { 
            get => deadline;
            set
            {
                if (value.HasValue && value.Value <= DateTime.Now)
                    throw new ToDoItemValidationException("Date can't be less than DateTime.Now", nameof(Deadline));

                deadline = value;
            }
        }

        public Priority Priority { get; set; }


        public string ToDoListId { get; set; }
        public ToDoList ToDoList { get; set; }


        public void SetCompleted()
        {
            Done = true;
        }
    }
}
