using System.Net;
using System.Net.Mail;

namespace devitemapi.Core.Utils
{
    public class EMailHepler
    {
        public EMailHepler()
        {
            // SmtpClient smtpClient = new SmtpClient();            
         }

         public static void Send()
         {
             SmtpClient smtpClient = new SmtpClient();
              smtpClient.Host = "mail.yurun.com";
            // smtpClient.EnableSsl = true;
            //  smtpClient.Host = "smtp.qq.com";
            // smtpClient.Port = 465;
            // smtpClient.UseDefaultCredentials = false;

            // NetworkCredential network = new NetworkCredential("name","password");
            // smtpClient.Credentials = network;

            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(new MailAddress("xxx@xxx.xxx"));
            mailMessage.Subject = "测试邮件";
            mailMessage.Body = "<h1>Hello</h1>";
            mailMessage.IsBodyHtml = true;

            mailMessage.Priority = MailPriority.Normal;

            mailMessage.From = new MailAddress("xxxx@xxx.xxx");
            smtpClient.Send(mailMessage);
         }
    }
}