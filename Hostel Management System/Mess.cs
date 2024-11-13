using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class Mess : Form
    {
        public Mess()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHostel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Hostel().Show();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Room().Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Student().Show();
        }

        private void btnmess_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Mess().Show();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Fee().Show();
        }

        private void btnVisiter_Click(object sender, EventArgs e)
        {
            this.Hide();
            new visitors().Show();
        }
    }
}
