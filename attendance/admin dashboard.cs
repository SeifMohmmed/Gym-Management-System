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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace attendance
{
    public partial class admindashboard : Form
    {
        private DataGridViewRow SelectedCell;
        int index;
        public admindashboard()
        {
            InitializeComponent();
            dataGridView.CellClick += dataGridView_CellClick;
        }

        private void admindashboard_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //Read client file
            string path = @"E:\Uni\attendance\attendance\bin\Client.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                string[] values;


                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split(',');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    dataGridView.Rows.Add(row);
                }
               

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new Attendance().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddNew().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView.SelectedRows)
            {
                int rowIndex = item.Index;
                dataGridView.Rows.RemoveAt(rowIndex);

                // Remove line from the file
                string path = @"E:\Uni\attendance\attendance\bin\Client.txt";
                if (File.Exists(path))
                {
                    List<string> lines = File.ReadAllLines(path).ToList();
                    lines.RemoveAt(rowIndex);
                    File.WriteAllLines(path, lines);
                }
            }
        }


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            SelectedCell = dataGridView.Rows[index];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (SelectedCell != null)
            {
               
                string ID = SelectedCell.Cells[0].Value.ToString();
                string Name1 = SelectedCell.Cells[1].Value.ToString();
                string Phone = SelectedCell.Cells[2].Value.ToString();
                string Email = SelectedCell.Cells[3].Value.ToString();
                string Address = SelectedCell.Cells[4].Value.ToString();
                string Data = SelectedCell.Cells[5].Value.ToString();
                string Subsc = SelectedCell.Cells[6].Value.ToString();
                string WCoach = SelectedCell.Cells[7].Value.ToString();


                Edit editForm = new Edit(ID,Name1,Phone,Email,Address,Data,Subsc,WCoach);
                editForm.UpdateValues(SelectedCell);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a cell before clicking Edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AddCoach().Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
