using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingReservation
{
    public partial class MailProcedures : Form
    {
        public MailProcedures()
        {
            InitializeComponent();
        }
        ReservationsEntities3 Db = new ReservationsEntities3();
        private void MailProcedures_Load(object sender, EventArgs e)
        {
            FillComboBox();
            FillDataGrid();

        }

        private void FillDataGrid()
        {
            int ID = Convert.ToInt32(comboBoxReservationID.SelectedItem);
            dataGridViewParticipants.DataSource = null;
            dataGridViewParticipants.DataSource = Db.Participants.Where(x => x.ReservationID == ID).ToList();
        }

        private void FillComboBox()
        {
            comboBoxReservationID.SelectedValue = "ReservationID";
            comboBoxReservationID.DisplayMember = "ReservationID";
            comboBoxReservationID.DataSource = Db.Reservations.Select(x => x.ReservationID).ToList();
        }

        private void comboBoxReservationID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void radioButtonSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewParticipants.SelectAll();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewParticipants.ClearSelection();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            int ReservationID = 0;
            List<string> MailList = new List<string>();
            List<string> Time = new List<string>();
            List<int> RoomID = new List<int>();
  
            foreach (DataGridViewRow item in dataGridViewParticipants.SelectedRows)
            {
                string MailAdress = item.Cells[1].Value.ToString();
                ReservationID = (int)comboBoxReservationID.SelectedItem;
               Time = Db.Reservations.Where(x => x.ReservationID == ReservationID ).Select(x => x.StartTime).ToList();
               RoomID = Db.Reservations.Where(x => x.ReservationID == ReservationID).Select(x => x.MeetingRoomID).ToList();
                MailList.Add(MailAdress);
            }
            MailProcedure.SendMail(MailList, RoomID[0], Time[0]);
        }

    } 

}
