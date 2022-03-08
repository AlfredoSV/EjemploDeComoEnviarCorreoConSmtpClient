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
                using (var mail = new MailMessage())
                {
                    using (var SmtpServer = new SmtpClient("smtp.gmail.com"))
                    {
                        mail.From = new MailAddress("");
                        mail.To.Add("");
                        mail.Subject = "Hola";
                        mail.Body = "<h1>Bienvenido<h1>";
                        mail.IsBodyHtml = true;
                        SmtpServer.Port = 587;
                        SmtpServer.UseDefaultCredentials = false;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("", "");

                        SmtpServer.EnableSsl = true;
                        SmtpServer.Send(mail);
                    }
                     
                }
                
                
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
