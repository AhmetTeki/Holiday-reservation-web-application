using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalRezervasyonApp.Models;

namespace TraversalRezervasyonApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage=new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", mailRequest.SenderMail);
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo=new MailboxAddress("User",mailRequest.ReceiverMail);

            mimeMessage.To.Add(mailboxAddressTo);

            BodyBuilder bodyBuilder = new BodyBuilder();    
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();

            mimeMessage.Subject=mailRequest.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smpt.gmail.com",587,false);
            client.Authenticate(mailRequest.SenderMail,"abcdef");
            client.Send(mimeMessage);
            client.Disconnect(true);
          
            return View();
        }
    }
}
