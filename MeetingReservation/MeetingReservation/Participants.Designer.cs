namespace MeetingReservation
{
    partial class Participants
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
            this.dataGridViewParticipant = new System.Windows.Forms.DataGridView();
            this.groupBoxPart = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxReservationID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNmSrName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxMailAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipant)).BeginInit();
            this.groupBoxPart.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewParticipant
            // 
            this.dataGridViewParticipant.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewParticipant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipant.Location = new System.Drawing.Point(351, 12);
            this.dataGridViewParticipant.Name = "dataGridViewParticipant";
            this.dataGridViewParticipant.RowTemplate.Height = 24;
            this.dataGridViewParticipant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParticipant.Size = new System.Drawing.Size(444, 371);
            this.dataGridViewParticipant.TabIndex = 10;
            this.dataGridViewParticipant.SelectionChanged += new System.EventHandler(this.dataGridViewParticipant_SelectionChanged);
            // 
            // groupBoxPart
            // 
            this.groupBoxPart.BackColor = System.Drawing.Color.Tan;
            this.groupBoxPart.Controls.Add(this.buttonClear);
            this.groupBoxPart.Controls.Add(this.buttonUpdate);
            this.groupBoxPart.Controls.Add(this.buttonDelete);
            this.groupBoxPart.Controls.Add(this.BtnCreate);
            this.groupBoxPart.Controls.Add(this.label5);
            this.groupBoxPart.Controls.Add(this.comboBoxReservationID);
            this.groupBoxPart.Controls.Add(this.label4);
            this.groupBoxPart.Controls.Add(this.textBoxNmSrName);
            this.groupBoxPart.Controls.Add(this.label3);
            this.groupBoxPart.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxPart.Controls.Add(this.textBoxMailAddress);
            this.groupBoxPart.Controls.Add(this.label2);
            this.groupBoxPart.Controls.Add(this.label1);
            this.groupBoxPart.Controls.Add(this.textBoxTC);
            this.groupBoxPart.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPart.Name = "groupBoxPart";
            this.groupBoxPart.Size = new System.Drawing.Size(333, 371);
            this.groupBoxPart.TabIndex = 11;
            this.groupBoxPart.TabStop = false;
            this.groupBoxPart.Text = "Create Participant";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(123, 309);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(85, 41);
            this.buttonClear.TabIndex = 24;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(226, 262);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 41);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(225, 309);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(85, 41);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(123, 262);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(84, 41);
            this.BtnCreate.TabIndex = 20;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Reservation ID:";
            // 
            // comboBoxReservationID
            // 
            this.comboBoxReservationID.FormattingEnabled = true;
            this.comboBoxReservationID.Location = new System.Drawing.Point(150, 200);
            this.comboBoxReservationID.Name = "comboBoxReservationID";
            this.comboBoxReservationID.Size = new System.Drawing.Size(160, 24);
            this.comboBoxReservationID.TabIndex = 18;
            this.comboBoxReservationID.Text = "Select ID";
            this.comboBoxReservationID.SelectedIndexChanged += new System.EventHandler(this.comboBoxReservationID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Name Surname:";
            // 
            // textBoxNmSrName
            // 
            this.textBoxNmSrName.Location = new System.Drawing.Point(150, 157);
            this.textBoxNmSrName.Name = "textBoxNmSrName";
            this.textBoxNmSrName.Size = new System.Drawing.Size(160, 22);
            this.textBoxNmSrName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phone Number:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(150, 114);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(160, 22);
            this.textBoxPhoneNumber.TabIndex = 14;
            // 
            // textBoxMailAddress
            // 
            this.textBoxMailAddress.Location = new System.Drawing.Point(150, 77);
            this.textBoxMailAddress.Name = "textBoxMailAddress";
            this.textBoxMailAddress.Size = new System.Drawing.Size(160, 22);
            this.textBoxMailAddress.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mail Adress:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "TC:";
            // 
            // textBoxTC
            // 
            this.textBoxTC.Location = new System.Drawing.Point(150, 38);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(160, 22);
            this.textBoxTC.TabIndex = 10;
            // 
            // Participants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(807, 395);
            this.Controls.Add(this.groupBoxPart);
            this.Controls.Add(this.dataGridViewParticipant);
            this.Name = "Participants";
            this.Text = "Participants";
            this.Load += new System.EventHandler(this.Participants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipant)).EndInit();
            this.groupBoxPart.ResumeLayout(false);
            this.groupBoxPart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewParticipant;
        private System.Windows.Forms.GroupBox groupBoxPart;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxReservationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNmSrName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxMailAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
    }
}