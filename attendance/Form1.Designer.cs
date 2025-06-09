namespace attendance
{
    partial class Attendance
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::attendance.Properties.Resources.Gym_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(145, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your ID";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBox.Location = new System.Drawing.Point(153, 207);
            this.IDBox.Multiline = true;
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(652, 36);
            this.IDBox.TabIndex = 4;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addbtn.Location = new System.Drawing.Point(153, 272);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(652, 58);
            this.Addbtn.TabIndex = 5;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.White;
            this.adminBtn.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.adminBtn.Location = new System.Drawing.Point(153, 358);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(652, 58);
            this.adminBtn.TabIndex = 6;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(24, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "GymEmail@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(793, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "01987456120";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.InfoText;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(685, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 30);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 12, 20, 49, 11, 0);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(959, 588);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GymName";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

