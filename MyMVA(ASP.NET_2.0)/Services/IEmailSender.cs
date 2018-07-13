using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVA_ASP.NET_2._0_.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
