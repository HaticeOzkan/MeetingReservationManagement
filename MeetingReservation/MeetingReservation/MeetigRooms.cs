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
    public partial class MeetigRooms : Form
    {
        public MeetigRooms()
        {
            InitializeComponent();
        }
        ReservationsEntities3 Db = new ReservationsEntities3();
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            MeetingRoom NewRoom = new MeetingRoom();
            NewRoom.RoomCapacity = Convert.ToInt32(textBoxCapacity.Text);
            Db.MeetingRooms.Add(NewRoom);
            Db.SaveChanges();
            MessageBox.Show("Eklendi");
            FillDataGrid();
        }

        private void MeetigRooms_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            dataGridViewRoom.DataSource = null;
            dataGridViewRoom.DataSource = Db.MeetingRooms.Select(x => new { x.MeetingRoomID, x.RoomCapacity }).ToList();
        }

        private void dataGridViewRoom_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridViewRoom.SelectedRows)
            {
                textBoxCapacity.Text= item.Cells[1].Value.ToString();
                
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           MeetingRoom Item= GetInfo();
            Item.RoomCapacity = Convert.ToInt32(textBoxCapacity.Text);
            Db.SaveChanges();
            FillDataGrid();
        }

        private MeetingRoom GetInfo()
        {

            int ID = 0;
            foreach (DataGridViewRow item in dataGridViewRoom.SelectedRows)
            {
                ID = (int)item.Cells[0].Value;
            }
            MeetingRoom Item = Db.MeetingRooms.SingleOrDefault(x => x.MeetingRoomID == ID);
            return Item;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MeetingRoom Item = GetInfo();
                Db.MeetingRooms.Remove(Item);
                Db.SaveChanges();
                FillDataGrid();

            }
            catch
            {
                MessageBox.Show("Seçilen odanın reservasyonu olduğu için oda silinememektedir.");
            }
          
        }
    }
}
