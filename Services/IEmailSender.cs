using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace world_cup.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
