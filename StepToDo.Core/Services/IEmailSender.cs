using System;
using System.Collections.Generic;
using System.Text;

namespace StepToDo.Core.Services
{
    public interface IEmailSender
    {
        void SendMail(string to, string subject, string message);
    }
}
