using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Project.TOOLS.CustomTools
{
   public static class MailSender
    {
        public static void Send(string receiver,string password="1234567899876543210.",string body="Hoppalaa",string subject="Test", string sender = "webdeyemek@outlook.com")
        {
            MailAddress senderMail = new MailAddress(sender);
            MailAddress receiverMail = new MailAddress(receiver);

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp-mail.outlook.com",
                Port = 587,
                EnableSsl = true, // ssl sertifikası
                DeliveryMethod=SmtpDeliveryMethod.Network,//Mail ulaştırma yöntemi smtp netwoek ile olacak
                UseDefaultCredentials=false,// kendimiz şifre mail adresi girdiğimiz için false yaptık 
                Credentials= new NetworkCredential(senderMail.Address,password)

            };

            using (MailMessage mesaj = new MailMessage(senderMail, receiverMail)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(mesaj);
            }
        }
    }
}
