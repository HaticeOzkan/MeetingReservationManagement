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
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }
        ReservationsEntities3 Db = new ReservationsEntities3();
        private void Reservations_Load(object sender, EventArgs e)
        {
            FillDataGrid();
            FillComboBox();

        }

        private void FillComboBox()
        {
            comboBoxRooms.DisplayMember = "MeetingRoomID";
            comboBoxRooms.ValueMember = "MeetingRoomID";
            comboBoxRooms.DataSource = Db.MeetingRooms.Select(x => x.MeetingRoomID).ToList();
        }

        private void btn_click(object sender, MouseEventArgs e)
        {
            if (((Button)sender).BackColor == Color.Green)
            {
                if (e.Button == MouseButtons.Left)
                    ((Button)sender).BackColor = Color.Blue;
            }
            else if (((Button)sender).BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                    MessageBox.Show("Toplantı odası seçilen saatte doludur.");
            }
            else if (((Button)sender).BackColor == Color.Blue)
            {
                if (e.Button == MouseButtons.Right)
                    ((Button)sender).BackColor = Color.Green;
            }
        }

        private void FillDataGrid()
        {
            
            DateTime date = dateTimePickerReserv.Value.Date;
            int RoomID = 0;           
                RoomID = Convert.ToInt32(comboBoxRooms.SelectedValue);
            dataGridViewReservation.DataSource = null;
            var List = Db.Reservations.Where(x => x.MeetingRoomID == RoomID && x.Date == date).Select(x => new { x.Date, x.StartTime, x.MeetingRoomID, x.ReservationID }).ToList();
            dataGridViewReservation.DataSource = List;
        }

        private void buttonCreateRes_Click(object sender, EventArgs e)
        {
            Reservation NewRes = new Reservation();
            NewRes.Date = dateTimePickerReserv.Value.Date;
            NewRes.MeetingRoomID = (int)comboBoxRooms.SelectedItem;
            StateClock(NewRes);
            Db.Reservations.Add(NewRes);
            Db.SaveChanges();
            FillDataGrid();
            FillFlowLayout();
        }

        private void StateClock(Reservation NewRes)
        {
            string Start = null;
            int i = 0;
            foreach (Button item in flowLayoutPanelReservation.Controls)
            {
                if (item.BackColor == Color.Blue)
                {
                    if (Start == null)
                        Start = item.Text;
                    i++;
                }
            }
            NewRes.StartTime = Start;
            NewRes.TimeInterval = i;
        }
        private void comboBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillFlowLayout();
            FillDataGrid();
        }
        private void FillFlowLayout()
        {
            if (dateTimePickerReserv.Value.Date < DateTime.Today.Date)
                MessageBox.Show("Geçmiş tarih için rezervasyon oluşturamazsınız.");

            else
            {
                
                flowLayoutPanelReservation.Controls.Clear();
                DateTime date = dateTimePickerReserv.Value.Date;
                int? RoomID = (int?)comboBoxRooms.SelectedItem;

                List<Reservation> List = Db.Reservations.Where(x => x.MeetingRoomID == RoomID && x.Date == date).ToList();
                int count = 0;
                for (int i = 8; i < 23; i++)
                {
                    Button b = new Button();
                    b.Text = i + ":00-" + i + ":30";
                    Control(List, b.Text, ref count);
                    b.BackColor = ColorState(ref count);
                    flowLayoutPanelReservation.Controls.Add(b);
                    b.MouseUp += new MouseEventHandler(btn_click);
                    Button b1 = new Button();
                    b1.Text = i + ":30-" + (i + 1) + ":00";
                    Control(List, b1.Text, ref count);
                    b1.BackColor = ColorState(ref count);
                    flowLayoutPanelReservation.Controls.Add(b1);
                    b1.MouseUp += new MouseEventHandler(btn_click);
                }
            }
        }

        private Color ColorState(ref int count)
        {
            if (count > 0)
            {
                count--;
                return Color.Red;
            }
            return Color.Green;
        }

        private void Control(List<Reservation> list, string text, ref int count)
        {
            foreach (var item in list)
            {
                if (item.StartTime == text)
                    count =(int)item.TimeInterval;
            }
            
        }

        private Color ColorState(List<Reservation> list, string text, ref int count)
        {
            foreach (var item in list)
            {
                if (item.StartTime == text)
                {
                    count = (int)item.TimeInterval;
                    return Color.Red;
                }

            }
            return Color.Green;
        }

        private void buttonDeleteRes_Click(object sender, EventArgs e)
        {
            int ID = 0;
            foreach (DataGridViewRow item in dataGridViewReservation.SelectedRows)
            {
                ID = Convert.ToInt32(item.Cells[3].Value);
            }
           var Item= Db.Reservations.SingleOrDefault(x => x.ReservationID == ID);
            Db.Reservations.Remove(Item);
            Db.SaveChanges();
            FillDataGrid();
            FillFlowLayout();
        }

        private void dateTimePickerReserv_ValueChanged(object sender, EventArgs e)
        {
            FillDataGrid();
            FillFlowLayout();
        }
    }
}
