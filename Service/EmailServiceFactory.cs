using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailServer.Service
{
    public static class EmailServiceFactory
    {

        public static IEmailService CreateEmailService(string authenticationType, string apiKey, string username, string password)
        {
            if (authenticationType == "ApiKey")
            {
                return new SendGridEmailService(apiKey);
            }
            else if (authenticationType == "Password")
            {
                return new EhsatEmailService(username, password);
            }
            else
            {
                throw new NotSupportedException("Authentication type not supported.");
            }
        }
    }
}
