using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if(userBox.Text=="admin" && passBox.Text=="admin")
            {
                this.Close();
                new admindashboard().Show();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect.\n Please check your credentials and try again.", "Incorrect username or password", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
