using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using MailKit.Security;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace SimpleEmailApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService) 
        {
            this._emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            Console.WriteLine("Please enter your username:");
            var username = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            var password = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            var recipient = Console.ReadLine();

            Console.WriteLine("Please enter the subject of your email:");
            var subject = Console.ReadLine();

            Console.WriteLine("Please enter the body of your email:");
            var body = Console.ReadLine();



            EmailDto emailDto = new EmailDto()
            {
                To = recipient,
                Subject = subject,
                Body = body
            };

            _emailService.SendEmail(emailDto);

            return Ok();
        }

    }
}

