using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailServer.Service
{
    public class EhsatEmailService: EmailServiceBase
    {
        private readonly string _username;
        private readonly string _password;
        public EhsatEmailService(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public override void SendEmail(string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
