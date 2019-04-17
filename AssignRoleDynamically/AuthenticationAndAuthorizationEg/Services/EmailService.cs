using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace AuthenticationAndAuthorizationEg.Services
{
    public static class EmailService
    {
        public static void Send(string ToAddress,string Subject,string Body)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("md.manzoorahmed@gmail.com", "XXXXXXXXYourPasswordXXXXXXX"),
                EnableSsl = true
            };
            client.Send("info@manzoorthetrainer.com", ToAddress, Subject, Body);
        }
    }
}
