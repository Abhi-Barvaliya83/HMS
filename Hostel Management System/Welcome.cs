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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        { 
            
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Student().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
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
