﻿using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Core.EmailsModel
{
    public class MailKitEmailService : IEmailService
    {
        private readonly EmailServerConfiguration _eConfig;

        public MailKitEmailService(EmailServerConfiguration config)
        {
            _eConfig = config;
        }
        public void Send(EmailMessage msg)
        {
           
            var message = new MimeMessage();
            message.To.AddRange(msg.ToAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
            message.From.AddRange(msg.FromAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
            message.Subject = msg.Subject;
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = msg.Content;
            message.Body = bodyBuilder.ToMessageBody();


      
           
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect(_eConfig.SmtpServer, _eConfig.SmtpPort);

                client.AuthenticationMechanisms.Remove("XOAUTH2");

                client.Authenticate(_eConfig.SmtpUsername, _eConfig.SmtpPassword);
               
                client.Send(message);
               
                client.Disconnect(true);
            }

           
          
        }
    }
}
