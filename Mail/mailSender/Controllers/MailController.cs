using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using mailSender.Interface;
using mailSender.Models;
using mailSender.Services;
using Microsoft.AspNetCore.Mvc;

namespace mailSender.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MailController : ControllerBase
    {
        private readonly IMail _mail;
        public MailController(IMail mail)
        {
            _mail = mail;
        }
        [HttpPost]
        [Route("/Mail")]
        public async Task<string> Index([FromBody]MailModel mailModel)
        {
            string mail= "rajevp01@gmail.com";
            string password = "fgfnwqqesykgebpw";
            await _mail.SendEmailAsync(mailModel.Email, mailModel.subject, mailModel.message, mail, password);
            return "mail sent Successfully";
        }
    }
}