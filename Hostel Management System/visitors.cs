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
    public partial class visitors : Form
    {
        public visitors()
        {
            InitializeComponent();
        }

        int VisitorId;
        DBconnect con = new DBconnect();

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
            
        }

        private void btnHostel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Hostel().Show();
        }

        private void visitors_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Visitor (VisitorsName, StudentName, TimeIn, TimeOut, EntryDate) VALUES " +
                              $"('{txtVisitorsName.Text}', '{txtStudentName.Text}', '{txtTimeIN.Text}', " +
                              $"'{txtTimeOut.Text}', '{txtEntryDate.Value.ToString("yyyy-MM-dd")}')";

            con.insert(query).ExecuteNonQuery();

            MessageBox.Show("Visitor Record Inserted Successfully!");

            fillGrid(); // Refresh the DataGridView after insertion
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE Visitor SET VisitorsName = '{txtVisitorsName.Text}', " +
                              $"StudentName = '{txtStudentName.Text}', " +
                              $"TimeIn = '{txtTimeIN.Text}', " +
                              $"TimeOut = '{txtTimeOut.Text}', " +
                              $"EntryDate = '{txtEntryDate.Value.ToString("yyyy-MM-dd")}' " +
                              $"WHERE VisitorsID = {VisitorId}";

            con.update(query).ExecuteNonQuery();

            MessageBox.Show("Visitor Record Updated Successfully!");

            fillGrid(); // Refresh the DataGridView after updating
            clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE FROM Visitor WHERE VisitorsID = {VisitorId}";

            con.delete(delete).ExecuteNonQuery();

            MessageBox.Show("Visitor Record Deleted Successfully!");

            fillGrid(); // Refresh the DataGridView after deletion
            clear();
        }

        void fillGrid()
        {
                string query = "SELECT * FROM Visitor";
                SqlDataAdapter da = con.selectDA(query);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
        }

        void clear()
        {
            txtVisitorsName.Clear();
            txtStudentName.Clear();
            txtTimeIN.Clear();
            txtTimeOut.Clear();
            txtEntryDate.Value = DateTime.Now;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VisitorId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["VisitorsID"].Value);
            txtVisitorsName.Text = dataGridView1.Rows[e.RowIndex].Cells["VisitorsName"].Value.ToString();
            txtStudentName.Text = dataGridView1.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
            txtTimeIN.Text = dataGridView1.Rows[e.RowIndex].Cells["TimeIn"].Value.ToString();
            txtTimeOut.Text = dataGridView1.Rows[e.RowIndex].Cells["TimeOut"].Value.ToString();
            txtEntryDate.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["EntryDate"].Value);
        }
    }
}
