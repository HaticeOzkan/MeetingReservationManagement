using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingReservation
{
    static class Program
    {
         public static void Control()
        {
            ReservationsEntities3 Db = new ReservationsEntities3();
            List<int> ReservationIDList = Db.Reservations.Select(x => x.ReservationID).ToList();
            List<string> MailList = new List<string>();
            List<int> RoomID = new List<int>();
            List<string> Time = new List<string>();
            foreach (var item in ReservationIDList)
            {
                if (DateTime.Today.Date.AddDays(1) == Convert.ToDateTime(Db.Reservations.Where(x => x.ReservationID == item).Select(x => x.Date.Value)))
                {
                    MailList = Db.Participants.Where(x => x.ReservationID == item).Select(x => x.MailAdress).ToList();
                    Time = Db.Reservations.Where(x => x.ReservationID == item).Select(x => x.StartTime).ToList();
                    RoomID = Db.Reservations.Where(x => x.ReservationID == item).Select(x => x.MeetingRoomID).ToList();
                    MailProcedure.SendMail(MailList, RoomID[0], Time[0]);
                }

            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
