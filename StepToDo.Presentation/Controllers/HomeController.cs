using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StepToDo.Core.Services;
using StepToDo.Presentation.Models;
using StepToDo.Presentation.ViewModels;

namespace StepToDo.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IToDoService toDoService;

        public HomeController(
            ILogger<HomeController> logger,
            IToDoService toDoService)
        {
            _logger = logger;
            this.toDoService = toDoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tasks(string id)
        {
            var viewModel = new TasksPageViewModel
            {
                CurrentListId = id,
                ToDoLists = toDoService.GetAllCurrentUserLists(),
                CurrentListToDoItems = toDoService.GetAllItemsByListId(id)
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddList(AddToDoListViewModel NewList)
        {
            toDoService.AddToDoList(NewList.Title, NewList.Color);
            TempData["Message"] = "New list added!";
            return RedirectToAction("Tasks", "Home");
        }

        [HttpPost]
        public IActionResult AddItem(AddToDoItemViewModel NewItem)
        {
            toDoService.AddTaskToList(NewItem.ToDoListId, NewItem.Title);
            TempData["Message"] = "New task added!";
            return RedirectToAction("Tasks", "Home", new { id = NewItem.ToDoListId });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
