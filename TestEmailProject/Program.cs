using System;
using System.Net.Mail;
using TestEmailProject;




/// <summary>
/// test project to send message from code.
/// </summary>
namespace TestEmailProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MailSender mailSender = new MailSender();

            mailSender.SendMail();
        }
    }
}
