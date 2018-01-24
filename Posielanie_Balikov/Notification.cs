using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Posielanie_Balikov
{
    class Notification
    {
        public static void WriteNotificationToConsole(string nazovZasielky, int cenaZasielky, int trackingNo)
        {
            Console.WriteLine("{0} was shipped for {1} Eur.\nYour tracking number is \"{2}\".", nazovZasielky,cenaZasielky,trackingNo);
        }

        public static void SendNotificationViaEmail(string nazovZasielky, int cenaZasielky, int trackingNo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("im545545@gmail.com");
                mail.To.Add("rfazekas.pe3xon@gmail.com");
                mail.Subject = string.Format("Notifikácia zásielky číslo: {0}", trackingNo);
                mail.Body = string.Format("Vaša zásielka číslo \"{0}\" bola odoslaná.\n\nNázov zásielky: {1}\nCena zásieky: {2} EUR",trackingNo, nazovZasielky,cenaZasielky);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("im545545", "XwJjv35WGMEv6BeCK6a6");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("mail Send");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
         
    }
}
