namespace MeetingReservation
{
    partial class Form1
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
            this.buttonParticipants = new System.Windows.Forms.Button();
            this.buttonMeetingRooms = new System.Windows.Forms.Button();
            this.buttonReservations = new System.Windows.Forms.Button();
            this.buttonMailprocedures = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonParticipants
            // 
            this.buttonParticipants.BackColor = System.Drawing.Color.LightCoral;
            this.buttonParticipants.Location = new System.Drawing.Point(175, 80);
            this.buttonParticipants.Name = "buttonParticipants";
            this.buttonParticipants.Size = new System.Drawing.Size(108, 95);
            this.buttonParticipants.TabIndex = 8;
            this.buttonParticipants.Text = "participants";
            this.buttonParticipants.UseVisualStyleBackColor = false;
            this.buttonParticipants.Click += new System.EventHandler(this.buttonParticipants_Click);
            // 
            // buttonMeetingRooms
            // 
            this.buttonMeetingRooms.BackColor = System.Drawing.Color.LightCoral;
            this.buttonMeetingRooms.Location = new System.Drawing.Point(289, 80);
            this.buttonMeetingRooms.Name = "buttonMeetingRooms";
            this.buttonMeetingRooms.Size = new System.Drawing.Size(114, 95);
            this.buttonMeetingRooms.TabIndex = 7;
            this.buttonMeetingRooms.Text = "Meeting Rooms";
            this.buttonMeetingRooms.UseVisualStyleBackColor = false;
            this.buttonMeetingRooms.Click += new System.EventHandler(this.buttonMeetingRooms_Click);
            // 
            // buttonReservations
            // 
            this.buttonReservations.BackColor = System.Drawing.Color.LightCoral;
            this.buttonReservations.Location = new System.Drawing.Point(56, 80);
            this.buttonReservations.Name = "buttonReservations";
            this.buttonReservations.Size = new System.Drawing.Size(113, 95);
            this.buttonReservations.TabIndex = 6;
            this.buttonReservations.Text = "Reservations";
            this.buttonReservations.UseVisualStyleBackColor = false;
            this.buttonReservations.Click += new System.EventHandler(this.buttonReservations_Click);
            // 
            // buttonMailprocedures
            // 
            this.buttonMailprocedures.BackColor = System.Drawing.Color.LightCoral;
            this.buttonMailprocedures.Location = new System.Drawing.Point(56, 39);
            this.buttonMailprocedures.Name = "buttonMailprocedures";
            this.buttonMailprocedures.Size = new System.Drawing.Size(346, 27);
            this.buttonMailprocedures.TabIndex = 9;
            this.buttonMailprocedures.Text = "Mail Procedures";
            this.buttonMailprocedures.UseVisualStyleBackColor = false;
            this.buttonMailprocedures.Click += new System.EventHandler(this.buttonMailprocedures_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(459, 255);
            this.Controls.Add(this.buttonMailprocedures);
            this.Controls.Add(this.buttonParticipants);
            this.Controls.Add(this.buttonMeetingRooms);
            this.Controls.Add(this.buttonReservations);
            this.Name = "Form1";
            this.Text = "Giris";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonParticipants;
        private System.Windows.Forms.Button buttonMeetingRooms;
        private System.Windows.Forms.Button buttonReservations;
        private System.Windows.Forms.Button buttonMailprocedures;
    }
}

