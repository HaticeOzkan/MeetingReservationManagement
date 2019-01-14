namespace MeetingReservation
{
    partial class MailProcedures
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
            this.comboBoxReservationID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewParticipants = new System.Windows.Forms.DataGridView();
            this.buttonSend = new System.Windows.Forms.Button();
            this.radioButtonSelectAll = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxReservationID
            // 
            this.comboBoxReservationID.FormattingEnabled = true;
            this.comboBoxReservationID.Location = new System.Drawing.Point(146, 48);
            this.comboBoxReservationID.Name = "comboBoxReservationID";
            this.comboBoxReservationID.Size = new System.Drawing.Size(156, 24);
            this.comboBoxReservationID.TabIndex = 0;
            this.comboBoxReservationID.SelectedIndexChanged += new System.EventHandler(this.comboBoxReservationID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservation ID:";
            // 
            // dataGridViewParticipants
            // 
            this.dataGridViewParticipants.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipants.Location = new System.Drawing.Point(12, 105);
            this.dataGridViewParticipants.Name = "dataGridViewParticipants";
            this.dataGridViewParticipants.RowTemplate.Height = 24;
            this.dataGridViewParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParticipants.Size = new System.Drawing.Size(554, 248);
            this.dataGridViewParticipants.TabIndex = 2;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(388, 30);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(177, 37);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // radioButtonSelectAll
            // 
            this.radioButtonSelectAll.AutoSize = true;
            this.radioButtonSelectAll.Location = new System.Drawing.Point(397, 78);
            this.radioButtonSelectAll.Name = "radioButtonSelectAll";
            this.radioButtonSelectAll.Size = new System.Drawing.Size(87, 21);
            this.radioButtonSelectAll.TabIndex = 5;
            this.radioButtonSelectAll.TabStop = true;
            this.radioButtonSelectAll.Text = "Select All";
            this.radioButtonSelectAll.UseVisualStyleBackColor = true;
            this.radioButtonSelectAll.CheckedChanged += new System.EventHandler(this.radioButtonSelectAll_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(507, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "back";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // MailProcedures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(578, 365);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButtonSelectAll);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.dataGridViewParticipants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxReservationID);
            this.Name = "MailProcedures";
            this.Text = "MailProcedures";
            this.Load += new System.EventHandler(this.MailProcedures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxReservationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewParticipants;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.RadioButton radioButtonSelectAll;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}