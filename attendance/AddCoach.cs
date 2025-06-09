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
    public partial class AddCoach : Form
    {
    string coachName;
        public AddCoach()
        {
            InitializeComponent();
        }
        private void AddCoach_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Write file
            FileStream myFile;
            StreamReader sr;
            StreamWriter sw;
            string fileName = @"E:\Uni\attendance\attendance\bin\Coach.txt";
            myFile = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(myFile);
            //////////////////////////////////////////
            if (string.IsNullOrEmpty(AddNew.argname1))
            {
                
                MessageBox.Show("Add Coach successful ");
                //Write file
                sw.WriteLine(textBoxID.Text + ", " + textBoxName.Text + ", " + textBoxPhone.Text + ", " + textBoxEmail.Text + ", " + textBoxAddress.Text + ", " + dateTimePickerBirth.Text);
                textBoxID.Text = string.Empty;
                textBoxName.Text = string.Empty;
                textBoxAddress.Text = string.Empty;
                textBoxEmail.Text = string.Empty;
                textBoxPhone.Text = string.Empty;
            }
            else if (!string.IsNullOrEmpty(AddNew.argname1) && string.IsNullOrEmpty(AddNew.argname2))
            {
                
                MessageBox.Show("Add Coach successful ");
                sw.WriteLine(textBoxID.Text + ", " + textBoxName.Text + ", " + textBoxPhone.Text + ", " + textBoxEmail.Text + ", " + textBoxAddress.Text + ", " + dateTimePickerBirth.Text);
                textBoxID.Text = string.Empty;
                textBoxName.Text = string.Empty;
                textBoxAddress.Text = string.Empty;
                textBoxEmail.Text = string.Empty;
                textBoxPhone.Text = string.Empty;
            }
            else if (!string.IsNullOrEmpty(AddNew.argname1) && !string.IsNullOrEmpty(AddNew.argname2))
            { 
                MessageBox.Show("Maximum capacity of coaches", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

            sw.Close();
            myFile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
        }
    }
}
