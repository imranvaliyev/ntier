using StepToDo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepToDo.Core.Services
{
    public interface IUserService
    {
        User CurrentUser { get; }
    }
}
