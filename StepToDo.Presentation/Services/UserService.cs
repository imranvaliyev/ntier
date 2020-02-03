using Microsoft.AspNetCore.Http;
using StepToDo.Core.Entities;
using StepToDo.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StepToDo.Presentation.Services
{
    public class UserService : IUserService
    {
        private readonly User currentUser;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            var context = httpContextAccessor.HttpContext;
            currentUser = new User();
            currentUser.Id = context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }

        public User CurrentUser => currentUser;
    }
}
