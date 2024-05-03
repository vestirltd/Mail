using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mailSender.Interface
{
    public interface IMail
    {
        Task SendEmailAsync(string email, string subject, string message, string mail, string password);
    }
}