using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailServer.Service
{
    public class SendGridEmailService : EmailServiceBase
    {
        private readonly string _apiKey;
        public SendGridEmailService(string apiKey)
        {
            _apiKey = apiKey;
        }

        public override void SendEmail(string to, string subject, string body)
        {
            throw new NotImplementedException();
        }

    }
}
