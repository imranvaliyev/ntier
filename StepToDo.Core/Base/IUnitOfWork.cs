using StepToDo.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepToDo.Core.Base
{
    public interface IUnitOfWork : IDisposable
    {
        IToDoItemRepository ToDoItemRepository { get; }
        IToDoListRepository ToDoListRepository { get; }

        void Save();
    }
}
