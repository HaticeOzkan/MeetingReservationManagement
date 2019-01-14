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
    public partial class Participants : Form
    {
        public Participants()
        {
            InitializeComponent();
        }
        ReservationsEntities3 Db = new ReservationsEntities3();

        private void Participants_Load(object sender, EventArgs e)
        {
            FillDataGrid();
            FillCombox();
        }

        private void FillDataGrid()
        {
            dataGridViewParticipant.DataSource = null;
            int ID = Convert.ToInt32(comboBoxReservationID.SelectedItem);
            dataGridViewParticipant.DataSource = Db.Participants.Where(x => x.ReservationID == ID).ToList();
            
        }

        private void FillCombox()
        {
            comboBoxReservationID.DataSource = null;
            comboBoxReservationID.ValueMember = "ReservationID";
            comboBoxReservationID.DisplayMember = "ReservationID";
            comboBoxReservationID.DataSource = Db.Reservations.Select(x => x.ReservationID).ToList();
            
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Participant NewPartic = new Participant();
            NewPartic.MailAdress = textBoxMailAddress.Text;
            NewPartic.NameSurname = textBoxNmSrName.Text;
            NewPartic.ParticipantID = textBoxTC.Text;
            NewPartic.PhoneNumber = textBoxPhoneNumber.Text;
            NewPartic.ReservationID =Convert.ToInt32(comboBoxReservationID.SelectedValue);
            Db.Participants.Add(NewPartic);
            Db.SaveChanges();
            MessageBox.Show("İşlem gerçekleştirildi.");
            FillDataGrid();
        }

        private void comboBoxReservationID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Participant Item = GetInfo();
            Db.Participants.Remove(Item);
            Db.SaveChanges();
            FillDataGrid();
        }

        private Participant GetInfo()
        {
            string ID = "";
            foreach (DataGridViewRow item in dataGridViewParticipant.SelectedRows)
            {
                ID = (string)item.Cells[0].Value;
            }
            Participant Item = Db.Participants.SingleOrDefault(x => x.ParticipantID == ID);
            return Item;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Participant Item = GetInfo();
            Update(Item);
            Db.SaveChanges();
            FillDataGrid();
        }

        private void Update(Participant item)
        {
            item.MailAdress = textBoxMailAddress.Text;
            item.NameSurname= textBoxNmSrName.Text;
            item.ParticipantID = textBoxTC.Text;
            item.PhoneNumber= textBoxPhoneNumber.Text;
            item.ReservationID = Convert.ToInt32(comboBoxReservationID.SelectedValue);       
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (Control Item in groupBoxPart.Controls)
            {
                if (Item is TextBox)
                    Item.Text = "";              
            }
        }

        private void dataGridViewParticipant_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dataGridViewParticipant.SelectedRows)
            {
                textBoxTC.Text = item.Cells[0].Value.ToString();
                textBoxMailAddress.Text = item.Cells[1].Value.ToString();
                textBoxPhoneNumber.Text = item.Cells[2].Value.ToString();
                textBoxNmSrName.Text = item.Cells[3].Value.ToString();
                comboBoxReservationID.SelectedItem = item.Cells[4].ToString();
            }
        }
    }
}
