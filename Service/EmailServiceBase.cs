using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailServer.Service
{
    public abstract class EmailServiceBase : IEmailService
    {
        public abstract void SendEmail(string to, string subject, string body);
        
    }
}
