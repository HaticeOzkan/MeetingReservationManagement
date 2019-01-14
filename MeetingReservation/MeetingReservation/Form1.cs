using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReservations_Click(object sender, EventArgs e)
        {
            new Reservations().Show();
        }

        private void buttonMeetingRooms_Click(object sender, EventArgs e)
        {
            new MeetigRooms().Show();
        }

        private void buttonParticipants_Click(object sender, EventArgs e)
        {
            new Participants().Show();
        }

        private void buttonMailprocedures_Click(object sender, EventArgs e)
        {
            new MailProcedures().Show();
        }
    }
}
