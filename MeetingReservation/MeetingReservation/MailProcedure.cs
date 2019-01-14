using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MeetingReservation
{
    class MailProcedure
    {
        ReservationsEntities3 Db = new ReservationsEntities3();
        public static void SendMail(List<string> mailList, int roomNo, string time)
        {
            string MailBody = "Yarin " + roomNo + " Nolu Toplantı odasında " + time + " Saatinde başlayacak olan toplantınız var";
            MailMessage Eposta = new MailMessage();
            Eposta.From = new MailAddress("mail@gmail.com");
            foreach (var item in mailList)
            {
                Eposta.To.Add(item);
            }
            Eposta.Subject = "Toplantınız var!!";
            Eposta.Body = MailBody;
            SmtpClient smtp = new SmtpClient();
            #region
            smtp.Credentials = new System.Net.NetworkCredential("htcozkn24@gmail.com", "Aliye1453.");
            #endregion
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Send(Eposta);

        }

    }

}

