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
    public partial class Mess : Form
    {
        public Mess()
        {
            InitializeComponent();
        }

        int MessId;
        DBconnect con = new DBconnect();


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

        private void Mess_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Mess (MessName, MessCapacity, MessExpense, Location) VALUES " +
                               $"('{txtMessName.Text}', {txtMessCapacity.Text}, {txtMessExpense.Text}, '{txtLocation.Text}')";

            con.insert(query).ExecuteNonQuery();

            MessageBox.Show("Mess Record Inserted Successfully!");

            fillGrid(); // Refresh the DataGridView after insertion
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE Mess SET MessName = '{txtMessName.Text}', " +
                               $"MessCapacity = {txtMessCapacity.Text}, " +
                               $"MessExpense = {txtMessExpense.Text}, " +
                               $"Location = '{txtLocation.Text}' " +
                               $"WHERE MessID = {MessId}";

            con.update(query).ExecuteNonQuery();

            MessageBox.Show("Mess Record Updated Successfully!");

            fillGrid(); // Refresh the DataGridView after updating
            clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE FROM Mess WHERE MessID = {MessId}";

            con.delete(delete).ExecuteNonQuery();

            MessageBox.Show("Mess Record Deleted Successfully!");

            fillGrid(); // Refresh the DataGridView after deletion
            clear();

        }

        void fillGrid()
        {
            try
            {
                string query = "SELECT * FROM Mess";
                SqlDataAdapter da = con.selectDA(query);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void clear()
        {
            txtMessName.Clear();
            txtMessCapacity.Clear();
            txtMessExpense.Clear();
            txtLocation.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MessID"].Value);
            txtMessName.Text = dataGridView1.Rows[e.RowIndex].Cells["MessName"].Value.ToString();
            txtMessCapacity.Text = dataGridView1.Rows[e.RowIndex].Cells["MessCapacity"].Value.ToString();
            txtMessExpense.Text = dataGridView1.Rows[e.RowIndex].Cells["MessExpense"].Value.ToString();
            txtLocation.Text = dataGridView1.Rows[e.RowIndex].Cells["Location"].Value.ToString();

        }
    }
}

