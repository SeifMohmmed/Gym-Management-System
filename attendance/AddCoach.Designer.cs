namespace attendance
{
    partial class AddCoach
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
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.resetbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::attendance.Properties.Resources.Gym_logo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerBirth.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBirth.Location = new System.Drawing.Point(671, 228);
            this.dateTimePickerBirth.MaxDate = new System.DateTime(2023, 12, 12, 0, 0, 0, 0);
            this.dateTimePickerBirth.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(282, 34);
            this.dateTimePickerBirth.TabIndex = 45;
            this.dateTimePickerBirth.Value = new System.DateTime(2023, 12, 12, 0, 0, 0, 0);
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.resetbtn.FlatAppearance.BorderSize = 0;
            this.resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetbtn.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.resetbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetbtn.Location = new System.Drawing.Point(517, 435);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(265, 69);
            this.resetbtn.TabIndex = 43;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.savebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savebtn.Location = new System.Drawing.Point(225, 435);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(265, 69);
            this.savebtn.TabIndex = 42;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(671, 149);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(282, 34);
            this.textBoxPhone.TabIndex = 39;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(671, 305);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(282, 34);
            this.textBoxAddress.TabIndex = 38;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(160, 307);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(282, 34);
            this.textBoxEmail.TabIndex = 41;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(160, 228);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(282, 34);
            this.textBoxName.TabIndex = 37;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(160, 149);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(282, 34);
            this.textBoxID.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 16.2F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(491, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 38);
            this.label7.TabIndex = 32;
            this.label7.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 16.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(491, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 38);
            this.label6.TabIndex = 31;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 16.2F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(36, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 38);
            this.label5.TabIndex = 30;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 16.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(491, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 38);
            this.label4.TabIndex = 29;
            this.label4.Text = "Phone no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(36, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 38);
            this.label3.TabIndex = 28;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(36, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 38);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(345, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 50);
            this.label1.TabIndex = 27;
            this.label1.Text = "Add new coach";
            // 
            // AddCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(999, 557);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCoach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Coach";
            this.Load += new System.EventHandler(this.AddCoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.TextBox textBoxPhone;
        public System.Windows.Forms.TextBox textBoxAddress;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}