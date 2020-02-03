using System;
using System.Collections.Generic;
using System.Text;
using StepToDo.Core.Base;
using StepToDo.Core.Entities;

namespace StepToDo.Core.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IUserService userService;

        public ToDoService(IUnitOfWork unitOfWork, IUserService userService)
        {
            this.unitOfWork = unitOfWork;
            this.userService = userService;
        }

        public void AddTaskToList(string listId, string title)
        {
            if (userService.CurrentUser != null)
            {
                var item = new ToDoItem(title);
                item.ToDoListId = listId;
                unitOfWork.ToDoItemRepository.Create(item);
                unitOfWork.Save();
            }
        }

        public void AddToDoList(string title, string color = "#ffffff")
        {
            if (userService.CurrentUser != null)
            {
                var list = new ToDoList(title, color);
                list.UserId = userService.CurrentUser.Id;
                unitOfWork.ToDoListRepository.Create(list);
                unitOfWork.Save();
            }
        }

        public IEnumerable<ToDoItem> GetAllItemsByListId(string listId)
        {
            return unitOfWork.ToDoItemRepository.GetAllByListId(listId);
        }

        public IEnumerable<ToDoList> GetAllCurrentUserLists()
        {
            if (userService.CurrentUser != null)
            {
                var id = userService.CurrentUser.Id;
                return unitOfWork.ToDoListRepository.GetAllByUserId(id);
            }
            else return null;
        }
    }
}
