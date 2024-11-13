using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        int StudentId;

        DBconnect con = new DBconnect();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRoomID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE StudentInfo SET StudentName = '{txtStudentName.Text}', FatherName = '{txtFatherName.Text}', " +
                           $"Department = '{txtDepartment.Text}', Address = '{txtAddress.Text}', ContactNo = '{txtContactNo.Text}', " +
                           $"Age = {txtAge.Text}, DOB = '{DOB.Value.ToString("yyyy-MM-dd")}' WHERE StudentID = {StudentId}";

            con.update(query).ExecuteNonQuery();
            MessageBox.Show("Student data updated!");
            fillg();
            clear();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO StudentInfo (StudentName, FatherName, Department, Address, ContactNo, Age, DOB) " +
                           $"VALUES ('{txtStudentName.Text}', '{txtFatherName.Text}', '{txtDepartment.Text}', '{txtAddress.Text}', '{txtContactNo.Text}', '{txtAge.Text}', '{DOB.Value.ToString("yyyy-MM-dd")}')";

            con.insert(query).ExecuteNonQuery();
            MessageBox.Show("Student data inserted!");
            fillg();
            clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE FROM StudentInfo WHERE StudentID = '{StudentId}'";
            con.delete(delete).ExecuteNonQuery();
            MessageBox.Show("Student data deleted!");
            fillg();
            clear();
        }

        void fillg()
        {
            // Method to load data into the DataGridView
            string query = "SELECT * FROM StudentInfo";
            SqlDataAdapter da = con.selectDA(query);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void clear()
        {
            // Clear all text boxes and reset controls
            txtStudentName.Clear();
            txtFatherName.Clear();
            txtDepartment.Clear();
            txtAddress.Clear();
            txtContactNo.Clear();
            txtAge.Clear();
            DOB.Value = DateTime.Now;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value);

            txtStudentName.Text = dataGridView1.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
            txtFatherName.Text = dataGridView1.Rows[e.RowIndex].Cells["FatherName"].Value.ToString();
            txtDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells["Department"].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            txtContactNo.Text = dataGridView1.Rows[e.RowIndex].Cells["ContactNO"].Value.ToString();
            txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells["Age"].Value.ToString();
            DOB.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["DOB1"].Value);
        }
    }
}
