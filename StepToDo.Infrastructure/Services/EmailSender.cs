using StepToDo.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepToDo.Infrastructure.Services
{
    public class EmailSender : IEmailSender
    {
        public void SendMail(string to, string subject, string message)
        {
            throw new NotImplementedException();
        }
    }
}
