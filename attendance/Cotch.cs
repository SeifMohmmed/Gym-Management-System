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
    public partial class Cotch : Form
    {
        public Cotch()
        {
            InitializeComponent();
        }

        private void Cotch_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;

        }
    }
}
