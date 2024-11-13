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
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace Hostel_Management_System
{
    public partial class Fee : Form
    {
        public Fee()
        {
            InitializeComponent();
        }

        int FeeId;

        DBconnect con = new DBconnect();
        SqlDataAdapter da;
        DataSet ds;



        private CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

        static string Crypath = "";


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
            string query = $"INSERT INTO fee_tbl(Student_id,Student_name,Fees,Fee_Status,Hostel_id) VALUES('{txtStudentID.Text}' , '{txtStudentName.Text}' , '{txtFees.Text}' , '{txtFeesstatus.Text}' , '{txtHostelID.Text}')";

            con.insert(query).ExecuteNonQuery();

            MessageBox.Show("Data Inserted");
        }

        void clear()
        {
            txtFees.Clear();
            txtFeesstatus.Clear();
            txtHostelID.Clear();
            txtStudentID.Clear();
            txtStudentName.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE fee_tbl SET Fees = " + txtFees.Text + ", " + "Fee_Status = '" + txtFeesstatus.Text + "', " +"Student_id = " + txtStudentID.Text + ", " + "Student_name = '" + txtStudentName.Text +"', " + "Hostel_id = " + txtHostelID.Text + " " + "WHERE Fee_Id = " + FeeId;

            con.update(query).ExecuteNonQuery();

            MessageBox.Show("Data Updated");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             FeeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Fee_Id"].Value);

            txtFees.Text = (dataGridView1.Rows[e.RowIndex].Cells["Fees"].Value).ToString();
            txtFeesstatus.Text = (dataGridView1.Rows[e.RowIndex].Cells["FeesStatus"].Value).ToString();
            txtStudentID.Text = (dataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value).ToString();
            txtStudentName.Text = (dataGridView1.Rows[e.RowIndex].Cells["StudentName"].Value).ToString();
            txtHostelID.Text = (dataGridView1.Rows[e.RowIndex].Cells["HostelID"].Value).ToString();
        }

        void fillg()
        {
            string query = "select * from fee_tbl";

            SqlDataAdapter da = con.selectDA(query);

            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE FROM fee_tbl WHERE Fee_Id = '{FeeId}'";

            con.delete(delete).ExecuteNonQuery();

            MessageBox.Show("Data Deleted!");

            fillg();
            clear();

        }

        private void Fee_Load(object sender, EventArgs e)
        {
            fillg();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            string query = "select * from fee_tbl";
            da = con.selectDA(query);
            ds = new DataSet();
            da.Fill(ds);
            string xml = @"C:\Users\vansh\source\repos\HMS\Hostel Management System\fee.xml";
            ds.WriteXmlSchema(xml);

            Crypath = @"C:\Users\vansh\source\repos\HMS\Hostel Management System\FeeReport1.rpt";
            cr.Load(Crypath);
            cr.SetDataSource(ds);
            cr.Database.Tables[0].SetDataSource(ds);
            cr.Refresh();
            crystalReportViewer1.ReportSource = cr;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
