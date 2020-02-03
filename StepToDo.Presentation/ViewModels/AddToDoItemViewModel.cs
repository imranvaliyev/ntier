using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepToDo.Presentation.ViewModels
{
    public class AddToDoItemViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ToDoListId { get; set; }
    }
}
