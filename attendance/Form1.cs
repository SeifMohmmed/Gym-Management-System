using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace attendance
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void cotchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Cotch().Show();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string path = @"E:\Uni\attendance\attendance\bin\Client.txt";
            if (File.Exists(path))
            {
                FileStream myFile;
                StreamReader sr;
                string fileName = path;
                myFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(myFile);


                int ID = int.Parse(IDBox.Text);
                string line;
                string[] field;
                bool found = false;

                while ((line = sr.ReadLine()) != null)
                {
                    field = line.Split(',');
                    if (int.Parse(field[0]) == ID)
                    {

                        MessageBox.Show("Attendance has been recorded");
                        IDBox.Text = string.Empty;
                        found = true;
                        break;
                    }
                }
            sr.Close();
            myFile.Close();
                if (!found)
                    MessageBox.Show("ID not found");
            }
            else
                MessageBox.Show("System is Empty");

        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;

        }
    }
}
