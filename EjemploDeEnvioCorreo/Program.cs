using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EjemploDeEnvioCorreo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var res = Send();
            Console.WriteLine(res);
        }

        public static bool Send()
        {
            try
            {
                
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("");
                mail.From = new MailAddress("");
                mail.To.Add("");
                mail.Subject = "";
                mail.Body = "<p><p>";
                mail.IsBodyHtml = true;
                SmtpServer.Port = 465;
       
                SmtpServer.Credentials = new System.Net.NetworkCredential("", "");
                SmtpServer.EnableSsl = false;
                SmtpServer.Send(mail);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
