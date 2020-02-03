using StepToDo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepToDo.Core.Services
{
    interface ICsvExporter
    {
        string Export(ToDoList list);
    }
}
