namespace MeetingReservation
{
    partial class Reservations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDeleteRes = new System.Windows.Forms.Button();
            this.dataGridViewReservation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRooms = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelReservation = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePickerReserv = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateRes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteRes
            // 
            this.buttonDeleteRes.Location = new System.Drawing.Point(811, 40);
            this.buttonDeleteRes.Name = "buttonDeleteRes";
            this.buttonDeleteRes.Size = new System.Drawing.Size(82, 58);
            this.buttonDeleteRes.TabIndex = 29;
            this.buttonDeleteRes.Text = "Delete";
            this.buttonDeleteRes.UseVisualStyleBackColor = true;
            this.buttonDeleteRes.Click += new System.EventHandler(this.buttonDeleteRes_Click);
            // 
            // dataGridViewReservation
            // 
            this.dataGridViewReservation.BackgroundColor = System.Drawing.Color.Tomato;
            this.dataGridViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservation.Location = new System.Drawing.Point(474, 125);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.RowTemplate.Height = 24;
            this.dataGridViewReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReservation.Size = new System.Drawing.Size(419, 365);
            this.dataGridViewReservation.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Room:";
            // 
            // comboBoxRooms
            // 
            this.comboBoxRooms.FormattingEnabled = true;
            this.comboBoxRooms.Location = new System.Drawing.Point(122, 80);
            this.comboBoxRooms.Name = "comboBoxRooms";
            this.comboBoxRooms.Size = new System.Drawing.Size(200, 24);
            this.comboBoxRooms.TabIndex = 26;
            this.comboBoxRooms.SelectedIndexChanged += new System.EventHandler(this.comboBoxRooms_SelectedIndexChanged);
            // 
            // flowLayoutPanelReservation
            // 
            this.flowLayoutPanelReservation.Location = new System.Drawing.Point(57, 125);
            this.flowLayoutPanelReservation.Name = "flowLayoutPanelReservation";
            this.flowLayoutPanelReservation.Size = new System.Drawing.Size(411, 365);
            this.flowLayoutPanelReservation.TabIndex = 25;
            // 
            // dateTimePickerReserv
            // 
            this.dateTimePickerReserv.Location = new System.Drawing.Point(122, 39);
            this.dateTimePickerReserv.Name = "dateTimePickerReserv";
            this.dateTimePickerReserv.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerReserv.TabIndex = 24;
            this.dateTimePickerReserv.ValueChanged += new System.EventHandler(this.dateTimePickerReserv_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Date:";
            // 
            // buttonCreateRes
            // 
            this.buttonCreateRes.Location = new System.Drawing.Point(386, 46);
            this.buttonCreateRes.Name = "buttonCreateRes";
            this.buttonCreateRes.Size = new System.Drawing.Size(82, 58);
            this.buttonCreateRes.TabIndex = 30;
            this.buttonCreateRes.Text = "Create";
            this.buttonCreateRes.UseVisualStyleBackColor = true;
            this.buttonCreateRes.Click += new System.EventHandler(this.buttonCreateRes_Click);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(952, 528);
            this.Controls.Add(this.buttonCreateRes);
            this.Controls.Add(this.buttonDeleteRes);
            this.Controls.Add(this.dataGridViewReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRooms);
            this.Controls.Add(this.flowLayoutPanelReservation);
            this.Controls.Add(this.dateTimePickerReserv);
            this.Controls.Add(this.label2);
            this.Name = "Reservations";
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.Reservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteRes;
        private System.Windows.Forms.DataGridView dataGridViewReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRooms;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReservation;
        private System.Windows.Forms.DateTimePicker dateTimePickerReserv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreateRes;
    }
}