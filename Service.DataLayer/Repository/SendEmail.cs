using Service.DataLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Service.DataLayer.Repository
{
    public class SendEmail : ISendEmail
    {       
        bool ISendEmail.SendEmailToCustomer(EmailInfo emailInfo)
        {
            try
            {
                string messageBody = "<font><h2>You have new Customer Enquiries  : </h2></font><br><br>" +
                    "Name: " + emailInfo.Name + 
                    "<br />Email: " + emailInfo.Email +
                    "<br />Phone No: " + emailInfo.Phoneumer +
                    "<br />Comments & Enquiries: " + emailInfo.Comments +
                    "<br /><br /><br /> <h1> Green Factory Auto Email Sender </h1>";

                var fromEmail = "userf2249@gmail.com";
                var toEmail = emailInfo.Email;

                MailMessage mail = new MailMessage();
                mail.To.Add(toEmail);
                //mail.To.Add("Secondry@gmail.com");
                mail.From = new MailAddress(fromEmail);
                mail.Subject = "Green Factory Customr Notification";
                //string Body = "Hi, this mail is to test sending mail using Gmail in ASP.NET";
                mail.Body = messageBody;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                // smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential(fromEmail, "User@123456");
                // smtp.Port = 587;
                //Or your Smtp Email ID and Password
                smtp.Send(mail);               

                return true;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
