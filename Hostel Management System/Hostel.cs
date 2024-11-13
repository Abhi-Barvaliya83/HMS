using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hostel_Management_System
{
    public partial class Hostel : Form
    {
        int HostelId;

        public Hostel()
        {
            InitializeComponent();
        }

        private void Hostel_Load(object sender, EventArgs e)
        {
            fillg();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            string delete = $"Delete from Hostel Where Hostel_id = '{HostelId}'";

            con.delete(delete).ExecuteNonQuery();

            MessageBox.Show("Data Deleted!");

            fillg();

            clear();
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

        DBconnect con = new DBconnect();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Hostel(NoOfRooms,NoOfStudents,AnnualExpense,Location) VALUES('{txtNoOfRoom.Text}','{txtNoOfStudents.Text}','{txtAnnualExpense.Text}','{txtLocation.Text}');";

            con.insert(query).ExecuteNonQuery();

            MessageBox.Show("Data inserted");

            fillg();

            clear();
        }

        void clear()
        {
            txtAnnualExpense.Clear();
            txtLocation.Clear();
            txtNoOfRoom.Clear();
            txtNoOfStudents.Clear();
        }

        void fillg()
        {
            string query = "select * from Hostel";

            SqlDataAdapter da = con.selectDA(query);

            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAnnualExpense.Text = (dataGridView1.Rows[e.RowIndex].Cells["AnnualExpense"].Value).ToString();
            txtLocation.Text = (dataGridView1.Rows[e.RowIndex].Cells["Location"].Value).ToString();
            txtNoOfRoom.Text = (dataGridView1.Rows[e.RowIndex].Cells["NoOfRooms"].Value).ToString();
            txtNoOfStudents.Text = (dataGridView1.Rows[e.RowIndex].Cells["Students"].Value).ToString();
            HostelId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Hostel_Id"].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $"Update Hostel SET NoOfRooms = '{txtNoOfRoom.Text}' , NoOfStudents = '{txtNoOfStudents.Text}' , AnnualExpense = '{txtAnnualExpense.Text}' , Location = '{txtLocation.Text}'";

            con.update(query).ExecuteNonQuery();

            MessageBox.Show("Data Updated");

            fillg();

            clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
