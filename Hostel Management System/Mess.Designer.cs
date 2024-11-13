
namespace Hostel_Management_System
{
    partial class Mess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MessID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessExpense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtMessName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMessCapacity = new System.Windows.Forms.TextBox();
            this.txtMessExpense = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnVisiter = new System.Windows.Forms.Button();
            this.btnFee = new System.Windows.Forms.Button();
            this.btnmess = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnHostel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MessID1,
            this.MessName,
            this.MessCapacity,
            this.MessExpense,
            this.Location});
            this.dataGridView1.Location = new System.Drawing.Point(401, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(639, 332);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MessID1
            // 
            this.MessID1.DataPropertyName = "MessID";
            this.MessID1.HeaderText = "ID";
            this.MessID1.MinimumWidth = 6;
            this.MessID1.Name = "MessID1";
            this.MessID1.Width = 125;
            // 
            // MessName
            // 
            this.MessName.DataPropertyName = "MessName";
            this.MessName.HeaderText = "Name";
            this.MessName.MinimumWidth = 6;
            this.MessName.Name = "MessName";
            this.MessName.Width = 125;
            // 
            // MessCapacity
            // 
            this.MessCapacity.DataPropertyName = "MessCapacity";
            this.MessCapacity.HeaderText = "Capacity";
            this.MessCapacity.MinimumWidth = 6;
            this.MessCapacity.Name = "MessCapacity";
            this.MessCapacity.Width = 125;
            // 
            // MessExpense
            // 
            this.MessExpense.DataPropertyName = "MessExpense";
            this.MessExpense.HeaderText = "Expense";
            this.MessExpense.MinimumWidth = 6;
            this.MessExpense.Name = "MessExpense";
            this.MessExpense.Width = 125;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.Width = 125;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(239, 314);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 32);
            this.Delete.TabIndex = 37;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(139, 314);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 32);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(27, 314);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 32);
            this.btnInsert.TabIndex = 35;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(233, 259);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 34;
            // 
            // txtMessName
            // 
            this.txtMessName.Location = new System.Drawing.Point(233, 127);
            this.txtMessName.Name = "txtMessName";
            this.txtMessName.Size = new System.Drawing.Size(100, 22);
            this.txtMessName.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.txtLocation);
            this.panel1.Controls.Add(this.txtMessName);
            this.panel1.Controls.Add(this.txtMessCapacity);
            this.panel1.Controls.Add(this.txtMessExpense);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(232, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 474);
            this.panel1.TabIndex = 31;
            // 
            // txtMessCapacity
            // 
            this.txtMessCapacity.Location = new System.Drawing.Point(233, 172);
            this.txtMessCapacity.Name = "txtMessCapacity";
            this.txtMessCapacity.Size = new System.Drawing.Size(100, 22);
            this.txtMessCapacity.TabIndex = 32;
            // 
            // txtMessExpense
            // 
            this.txtMessExpense.Location = new System.Drawing.Point(233, 216);
            this.txtMessExpense.Name = "txtMessExpense";
            this.txtMessExpense.Size = new System.Drawing.Size(100, 22);
            this.txtMessExpense.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(21, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(16, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mess Expense";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(21, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mess Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(21, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mess Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(794, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 22);
            this.txtSearch.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(676, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mess Information";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(58, 471);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(143, 41);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnVisiter
            // 
            this.btnVisiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisiter.Location = new System.Drawing.Point(58, 402);
            this.btnVisiter.Name = "btnVisiter";
            this.btnVisiter.Size = new System.Drawing.Size(143, 41);
            this.btnVisiter.TabIndex = 29;
            this.btnVisiter.Text = "Visiter";
            this.btnVisiter.UseVisualStyleBackColor = true;
            this.btnVisiter.Click += new System.EventHandler(this.btnVisiter_Click);
            // 
            // btnFee
            // 
            this.btnFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFee.Location = new System.Drawing.Point(58, 332);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(143, 41);
            this.btnFee.TabIndex = 28;
            this.btnFee.Text = "Fee";
            this.btnFee.UseVisualStyleBackColor = true;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // btnmess
            // 
            this.btnmess.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmess.Location = new System.Drawing.Point(58, 267);
            this.btnmess.Name = "btnmess";
            this.btnmess.Size = new System.Drawing.Size(143, 41);
            this.btnmess.TabIndex = 27;
            this.btnmess.Text = "Mess";
            this.btnmess.UseVisualStyleBackColor = true;
            this.btnmess.Click += new System.EventHandler(this.btnmess_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(58, 198);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(143, 41);
            this.btnStudent.TabIndex = 26;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Location = new System.Drawing.Point(58, 132);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(143, 41);
            this.btnRoom.TabIndex = 25;
            this.btnRoom.Text = "Room";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnHostel
            // 
            this.btnHostel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHostel.Location = new System.Drawing.Point(58, 68);
            this.btnHostel.Name = "btnHostel";
            this.btnHostel.Size = new System.Drawing.Size(143, 41);
            this.btnHostel.TabIndex = 24;
            this.btnHostel.Text = "Hostel";
            this.btnHostel.UseVisualStyleBackColor = true;
            this.btnHostel.Click += new System.EventHandler(this.btnHostel_Click);
            // 
            // Mess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1353, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnVisiter);
            this.Controls.Add(this.btnFee);
            this.Controls.Add(this.btnmess);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.btnHostel);
            this.Name = "Mess";
            this.Text = "Mess";
            this.Load += new System.EventHandler(this.Mess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtMessName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMessCapacity;
        private System.Windows.Forms.TextBox txtMessExpense;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnVisiter;
        private System.Windows.Forms.Button btnFee;
        private System.Windows.Forms.Button btnmess;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnHostel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessExpense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
    }
}