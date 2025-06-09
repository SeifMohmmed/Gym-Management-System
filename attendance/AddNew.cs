using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace attendance
{
    public partial class AddNew : Form
    {
        internal static string argname1;
        internal static string argname2;
        //internal static string argname3;
        public AddNew()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            ComboBoxWCoach.Text = string.Empty;
            comboBoxSubsc.Text = string.Empty;
        }

        private void AddNew_Load(object sender, EventArgs e)
        {
            //Read coach file
            FileStream myFile;
            StreamReader sr;
            string fileName = @"E:\Uni\attendance\attendance\bin\Coach.txt";
            myFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(myFile);
            String Line = sr.ReadToEnd();
            string[] field = Line.Split(',');
            
            argname1 = field[1];
            argname2 = field[6];
           
            if (!string.IsNullOrEmpty(argname1))
                ComboBoxWCoach.Items.Add(argname1);
           
            if (!string.IsNullOrEmpty(argname2))
                ComboBoxWCoach.Items.Add(argname2);

            //if (!string.IsNullOrEmpty(argname3))
            //    ComboBoxWCoach.Items.Add(argname3);
            
           
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Write client file
            FileStream myFile;
            StreamReader sr;
            StreamWriter sw;
            string fileName = @"E:\Uni\attendance\attendance\bin\Client.txt";
            myFile = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(myFile);
            sw.WriteLine(textBoxID.Text + ", " + textBoxName.Text + ", " + textBoxAddress.Text + ", " + textBoxEmail.Text + ", " + textBoxPhone.Text + ", " + ComboBoxWCoach.Text+ ", " + comboBoxSubsc.Text);
            //To calculate end subs
            DateTime currentDate = DateTime.Now.Date;
            if (comboBoxSubsc.SelectedIndex == 0)
            {
                comboBoxSubsc.Text = currentDate.AddMonths(1).ToString("dd-MM-yyyy");
            }
            else if (comboBoxSubsc.SelectedIndex == 1)
            {
                comboBoxSubsc.Text = currentDate.AddMonths(3).ToString("dd-MM-yyyy");
            }
            else if (comboBoxSubsc.SelectedIndex == 2)
            {
                comboBoxSubsc.Text = currentDate.AddMonths(6).ToString("dd-MM-yyyy");
            }
            else if (comboBoxSubsc.SelectedIndex == 3)
            {
                comboBoxSubsc.Text = currentDate.AddMonths(12).ToString("dd-MM-yyyy");
            }

            //show info in cell
            admindashboard adminForm = Application.OpenForms.OfType<admindashboard>().FirstOrDefault();
            if (textBoxID.Text != string.Empty && textBoxName.Text != string.Empty && textBoxPhone.Text != string.Empty && textBoxEmail.Text != string.Empty && textBoxAddress.Text != string.Empty && dateTimePickerBirth.Text != string.Empty && comboBoxSubsc.Text != string.Empty && ComboBoxWCoach.Text != string.Empty)
            {
                adminForm.dataGridView.Rows.Add(textBoxID.Text, textBoxName.Text, textBoxPhone.Text, textBoxEmail.Text, textBoxAddress.Text, dateTimePickerBirth.Text, comboBoxSubsc.Text, ComboBoxWCoach.Text);

                textBoxID.Text = string.Empty;
                textBoxName.Text = string.Empty;
                textBoxAddress.Text = string.Empty;
                textBoxEmail.Text = string.Empty;
                textBoxPhone.Text = string.Empty;
                ComboBoxWCoach.Text = string.Empty;
                comboBoxSubsc.Text = string.Empty;
            }

            else
                MessageBox.Show("Please enter correct info", "Error information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            sw.Close();
            myFile.Close();

        }

        private void ComboBoxWCoach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
