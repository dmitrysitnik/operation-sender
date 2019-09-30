using System;
using System.Net.Mail;

namespace TestEmailProject
{
    public class MailSender
    {

        
        public MailSender()
        {
        }

        

        public void SendMail()
        {
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.Credentials = new System.Net.NetworkCredential("test.sitnik@gmail.com", "6n903Zs12U78.");
                //smtp.UseDefaultCredentials = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;

                using (MailMessage mail = new MailMessage
                {
                    From = new MailAddress("test.sitnik@gmail.com")
                })
                {
                    mail.To.Add(new MailAddress("h.a.t.e46@yandex.ru"));
                    mail.Body = "Test body text";
                    mail.Subject = "test mail from ds";
                    smtp.Send(mail);
                }
            }
        }
    }
}
