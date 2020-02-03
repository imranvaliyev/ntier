using System;
using System.Collections.Generic;
using System.Text;

namespace StepToDo.Core.Exceptions
{
    class ToDoItemValidationException : ArgumentException
    {
        public ToDoItemValidationException(string message, string paramName) : base(message, paramName)
        {
        }
    }
}
