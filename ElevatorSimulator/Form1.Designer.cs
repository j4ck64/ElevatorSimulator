namespace ElevatorSimulator
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
            this.components = new System.ComponentModel.Container();
            this.LiftPicturebox = new System.Windows.Forms.PictureBox();
            this.LiftDownBtn = new System.Windows.Forms.Button();
            this.CloseDoorBtn = new System.Windows.Forms.Button();
            this.level1leftDoor = new System.Windows.Forms.PictureBox();
            this.GroundFloorLeftDoor = new System.Windows.Forms.PictureBox();
            this.GroundFloorRightDoor = new System.Windows.Forms.PictureBox();
            this.CloseDoorTimer = new System.Windows.Forms.Timer(this.components);
            this.OpenDoorTimer = new System.Windows.Forms.Timer(this.components);
            this.OpenDoorBtn = new System.Windows.Forms.Button();
            this.MoveLiftDownTimer = new System.Windows.Forms.Timer(this.components);
            this.LiftUpBtn = new System.Windows.Forms.Button();
            this.MoveLiftUpTimer = new System.Windows.Forms.Timer(this.components);
            this.level1RightDoor = new System.Windows.Forms.PictureBox();
            this.logLst = new System.Windows.Forms.ListBox();
            this.GroundFloorbtn = new System.Windows.Forms.Button();
            this.Level1btn = new System.Windows.Forms.Button();
            this.DisplayLogbtn = new System.Windows.Forms.Button();
            this.ClearLogbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LiftPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1leftDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroundFloorLeftDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroundFloorRightDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1RightDoor)).BeginInit();
            this.SuspendLayout();
            // 
            // LiftPicturebox
            // 
            this.LiftPicturebox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LiftPicturebox.Location = new System.Drawing.Point(135, 64);
            this.LiftPicturebox.Margin = new System.Windows.Forms.Padding(4);
            this.LiftPicturebox.Name = "LiftPicturebox";
            this.LiftPicturebox.Size = new System.Drawing.Size(241, 148);
            this.LiftPicturebox.TabIndex = 0;
            this.LiftPicturebox.TabStop = false;
            // 
            // LiftDownBtn
            // 
            this.LiftDownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiftDownBtn.Location = new System.Drawing.Point(537, 420);
            this.LiftDownBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LiftDownBtn.Name = "LiftDownBtn";
            this.LiftDownBtn.Size = new System.Drawing.Size(87, 52);
            this.LiftDownBtn.TabIndex = 2;
            this.LiftDownBtn.Text = "⓪";
            this.LiftDownBtn.UseVisualStyleBackColor = true;
            this.LiftDownBtn.Click += new System.EventHandler(this.LiftDownBtn_Click);
            // 
            // CloseDoorBtn
            // 
            this.CloseDoorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseDoorBtn.Location = new System.Drawing.Point(537, 289);
            this.CloseDoorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CloseDoorBtn.Name = "CloseDoorBtn";
            this.CloseDoorBtn.Size = new System.Drawing.Size(87, 55);
            this.CloseDoorBtn.TabIndex = 3;
            this.CloseDoorBtn.Text = "»||«";
            this.CloseDoorBtn.UseVisualStyleBackColor = true;
            this.CloseDoorBtn.Click += new System.EventHandler(this.CloseDoorBtn_Click);
            // 
            // level1leftDoor
            // 
            this.level1leftDoor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.level1leftDoor.Location = new System.Drawing.Point(135, 64);
            this.level1leftDoor.Margin = new System.Windows.Forms.Padding(4);
            this.level1leftDoor.Name = "level1leftDoor";
            this.level1leftDoor.Size = new System.Drawing.Size(121, 148);
            this.level1leftDoor.TabIndex = 5;
            this.level1leftDoor.TabStop = false;
            // 
            // GroundFloorLeftDoor
            // 
            this.GroundFloorLeftDoor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GroundFloorLeftDoor.Location = new System.Drawing.Point(135, 291);
            this.GroundFloorLeftDoor.Margin = new System.Windows.Forms.Padding(4);
            this.GroundFloorLeftDoor.Name = "GroundFloorLeftDoor";
            this.GroundFloorLeftDoor.Size = new System.Drawing.Size(121, 148);
            this.GroundFloorLeftDoor.TabIndex = 6;
            this.GroundFloorLeftDoor.TabStop = false;
            // 
            // GroundFloorRightDoor
            // 
            this.GroundFloorRightDoor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GroundFloorRightDoor.Location = new System.Drawing.Point(256, 291);
            this.GroundFloorRightDoor.Margin = new System.Windows.Forms.Padding(4);
            this.GroundFloorRightDoor.Name = "GroundFloorRightDoor";
            this.GroundFloorRightDoor.Size = new System.Drawing.Size(121, 148);
            this.GroundFloorRightDoor.TabIndex = 7;
            this.GroundFloorRightDoor.TabStop = false;
            // 
            // CloseDoorTimer
            // 
            this.CloseDoorTimer.Interval = 1;
            this.CloseDoorTimer.Tick += new System.EventHandler(this.CloseDoorTimer_Tick);
            // 
            // OpenDoorTimer
            // 
            this.OpenDoorTimer.Interval = 1;
            this.OpenDoorTimer.Tick += new System.EventHandler(this.OpenDoorTimer_Tick);
            // 
            // OpenDoorBtn
            // 
            this.OpenDoorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenDoorBtn.Location = new System.Drawing.Point(537, 353);
            this.OpenDoorBtn.Name = "OpenDoorBtn";
            this.OpenDoorBtn.Size = new System.Drawing.Size(87, 55);
            this.OpenDoorBtn.TabIndex = 8;
            this.OpenDoorBtn.Text = "«||»";
            this.OpenDoorBtn.UseVisualStyleBackColor = true;
            this.OpenDoorBtn.Click += new System.EventHandler(this.OpenDoorBtn_Click);
            // 
            // MoveLiftDownTimer
            // 
            this.MoveLiftDownTimer.Interval = 1;
            this.MoveLiftDownTimer.Tick += new System.EventHandler(this.MoveLiftDownTimer_Tick);
            // 
            // LiftUpBtn
            // 
            this.LiftUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiftUpBtn.Location = new System.Drawing.Point(537, 219);
            this.LiftUpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LiftUpBtn.Name = "LiftUpBtn";
            this.LiftUpBtn.Size = new System.Drawing.Size(87, 52);
            this.LiftUpBtn.TabIndex = 9;
            this.LiftUpBtn.Text = "①";
            this.LiftUpBtn.UseVisualStyleBackColor = true;
            this.LiftUpBtn.Click += new System.EventHandler(this.LiftUpBtn_Click);
            // 
            // MoveLiftUpTimer
            // 
            this.MoveLiftUpTimer.Interval = 1;
            this.MoveLiftUpTimer.Tick += new System.EventHandler(this.MoveLiftUpTimer_Tick);
            // 
            // level1RightDoor
            // 
            this.level1RightDoor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.level1RightDoor.Location = new System.Drawing.Point(256, 64);
            this.level1RightDoor.Margin = new System.Windows.Forms.Padding(4);
            this.level1RightDoor.Name = "level1RightDoor";
            this.level1RightDoor.Size = new System.Drawing.Size(119, 148);
            this.level1RightDoor.TabIndex = 4;
            this.level1RightDoor.TabStop = false;
            // 
            // logLst
            // 
            this.logLst.FormattingEnabled = true;
            this.logLst.ItemHeight = 16;
            this.logLst.Location = new System.Drawing.Point(711, 64);
            this.logLst.Name = "logLst";
            this.logLst.Size = new System.Drawing.Size(405, 372);
            this.logLst.TabIndex = 10;
            // 
            // GroundFloorbtn
            // 
            this.GroundFloorbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroundFloorbtn.Location = new System.Drawing.Point(432, 371);
            this.GroundFloorbtn.Name = "GroundFloorbtn";
            this.GroundFloorbtn.Size = new System.Drawing.Size(56, 52);
            this.GroundFloorbtn.TabIndex = 11;
            this.GroundFloorbtn.Text = "▲";
            this.GroundFloorbtn.UseVisualStyleBackColor = true;
            this.GroundFloorbtn.Click += new System.EventHandler(this.GroundFloorbtn_Click);
            // 
            // Level1btn
            // 
            this.Level1btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level1btn.Location = new System.Drawing.Point(432, 129);
            this.Level1btn.Name = "Level1btn";
            this.Level1btn.Size = new System.Drawing.Size(56, 52);
            this.Level1btn.TabIndex = 12;
            this.Level1btn.Text = "▼";
            this.Level1btn.UseVisualStyleBackColor = true;
            this.Level1btn.Click += new System.EventHandler(this.Level1btn_Click);
            // 
            // DisplayLogbtn
            // 
            this.DisplayLogbtn.Location = new System.Drawing.Point(629, 76);
            this.DisplayLogbtn.Name = "DisplayLogbtn";
            this.DisplayLogbtn.Size = new System.Drawing.Size(75, 50);
            this.DisplayLogbtn.TabIndex = 13;
            this.DisplayLogbtn.Text = "Display Log";
            this.DisplayLogbtn.UseVisualStyleBackColor = true;
            this.DisplayLogbtn.Click += new System.EventHandler(this.DisplayLogbtn_Click);
            // 
            // ClearLogbtn
            // 
            this.ClearLogbtn.Location = new System.Drawing.Point(629, 146);
            this.ClearLogbtn.Name = "ClearLogbtn";
            this.ClearLogbtn.Size = new System.Drawing.Size(75, 47);
            this.ClearLogbtn.TabIndex = 14;
            this.ClearLogbtn.Text = "Clear Log";
            this.ClearLogbtn.UseVisualStyleBackColor = true;
            this.ClearLogbtn.Click += new System.EventHandler(this.ClearLogbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 586);
            this.Controls.Add(this.ClearLogbtn);
            this.Controls.Add(this.DisplayLogbtn);
            this.Controls.Add(this.Level1btn);
            this.Controls.Add(this.GroundFloorbtn);
            this.Controls.Add(this.logLst);
            this.Controls.Add(this.LiftUpBtn);
            this.Controls.Add(this.OpenDoorBtn);
            this.Controls.Add(this.GroundFloorRightDoor);
            this.Controls.Add(this.GroundFloorLeftDoor);
            this.Controls.Add(this.level1leftDoor);
            this.Controls.Add(this.level1RightDoor);
            this.Controls.Add(this.CloseDoorBtn);
            this.Controls.Add(this.LiftDownBtn);
            this.Controls.Add(this.LiftPicturebox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ElevatorSimulator";
            ((System.ComponentModel.ISupportInitialize)(this.LiftPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1leftDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroundFloorLeftDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroundFloorRightDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1RightDoor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LiftPicturebox;
        private System.Windows.Forms.Button LiftDownBtn;
        private System.Windows.Forms.Button CloseDoorBtn;
        private System.Windows.Forms.PictureBox level1leftDoor;
        private System.Windows.Forms.PictureBox GroundFloorLeftDoor;
        private System.Windows.Forms.PictureBox GroundFloorRightDoor;
        private System.Windows.Forms.Timer CloseDoorTimer;
        private System.Windows.Forms.Timer OpenDoorTimer;
        private System.Windows.Forms.Button OpenDoorBtn;
        private System.Windows.Forms.Timer MoveLiftDownTimer;
        private System.Windows.Forms.Button LiftUpBtn;
        private System.Windows.Forms.Timer MoveLiftUpTimer;
        private System.Windows.Forms.PictureBox level1RightDoor;
        private System.Windows.Forms.ListBox logLst;
        private System.Windows.Forms.Button GroundFloorbtn;
        private System.Windows.Forms.Button Level1btn;
        private System.Windows.Forms.Button DisplayLogbtn;
        private System.Windows.Forms.Button ClearLogbtn;
    }
}

