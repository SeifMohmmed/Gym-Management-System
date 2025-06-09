using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace attendance
{
    public partial class Edit : Form
    {
        private DataGridViewRow selectedRow;

        

        public void UpdateValues(DataGridViewRow row)
        {
            if (row != null)
            {
                textBoxID.Text = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxPhone.Text = row.Cells[2].Value.ToString();
                textBoxEmail.Text = row.Cells[3].Value.ToString();
                textBoxAddress.Text = row.Cells[4].Value.ToString();
                dateTimePickerBirth.Text = row.Cells[5].Value.ToString();
                comboBoxSubsc.Text = row.Cells[6].Value.ToString();
                textBoxWCoach.Text = row.Cells[7].Value.ToString();

                selectedRow = row;
            }
        }
        public Edit()
        {
            InitializeComponent();
        }
        public Edit(string ID, string Name1, string Phone, string Email, string Address, string Data, string Subsc, string WCoach) : this()
        {
            textBoxID.Text = ID;
            textBoxName.Text = Name1;
            textBoxPhone.Text = Phone;
            textBoxEmail.Text = Email;
            textBoxAddress.Text = Address;
            dateTimePickerBirth.Text = Data;
            comboBoxSubsc.Text = Subsc;
            textBoxWCoach.Text = WCoach;
        }

        private void Edit_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                selectedRow.Cells[0].Value = textBoxID.Text;
                selectedRow.Cells[1].Value = textBoxName.Text;
                selectedRow.Cells[2].Value = textBoxPhone.Text;
                selectedRow.Cells[3].Value = textBoxEmail.Text;
                selectedRow.Cells[4].Value = textBoxAddress.Text;
                selectedRow.Cells[5].Value = dateTimePickerBirth.Text;
                selectedRow.Cells[6].Value = comboBoxSubsc.Text;
                selectedRow.Cells[7].Value = textBoxWCoach.Text;
            }

            this.Close();

        }
    }
}
