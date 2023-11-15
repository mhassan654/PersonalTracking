﻿namespace PersonalTracking
{
    partial class FrmTaskList
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
            panel1 = new Panel();
            panel3 = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            cmbTaskState = new ComboBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            rdDeliverDate = new RadioButton();
            rdStartDate = new RadioButton();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            pnlForAdmin = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            cmbxDepartment = new ComboBox();
            label5 = new Label();
            txtSurname = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtUserNo = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnApprove = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlForAdmin.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pnlForAdmin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 225);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(cmbTaskState);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(dateTimePicker2);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(303, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(511, 222);
            panel3.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(412, 179);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 31);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(305, 179);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbTaskState
            // 
            cmbTaskState.CausesValidation = false;
            cmbTaskState.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbTaskState.FormattingEnabled = true;
            cmbTaskState.Location = new Point(104, 148);
            cmbTaskState.Name = "cmbTaskState";
            cmbTaskState.Size = new Size(169, 29);
            cmbTaskState.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 145);
            label9.Name = "label9";
            label9.Size = new Size(86, 21);
            label9.TabIndex = 17;
            label9.Text = "Task State";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdDeliverDate);
            groupBox1.Controls.Add(rdStartDate);
            groupBox1.Location = new Point(308, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // rdDeliverDate
            // 
            rdDeliverDate.AutoSize = true;
            rdDeliverDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdDeliverDate.Location = new Point(6, 64);
            rdDeliverDate.Name = "rdDeliverDate";
            rdDeliverDate.Size = new Size(133, 25);
            rdDeliverDate.TabIndex = 1;
            rdDeliverDate.TabStop = true;
            rdDeliverDate.Text = "Delivery Date";
            rdDeliverDate.UseVisualStyleBackColor = true;
            // 
            // rdStartDate
            // 
            rdStartDate.AutoSize = true;
            rdStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdStartDate.Location = new Point(6, 17);
            rdStartDate.Name = "rdStartDate";
            rdStartDate.Size = new Size(104, 25);
            rdStartDate.TabIndex = 0;
            rdStartDate.TabStop = true;
            rdStartDate.Text = "Start Date";
            rdStartDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(103, 101);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(170, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(103, 55);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 103);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 3;
            label7.Text = "End Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 57);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 2;
            label8.Text = "Start Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 17);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 0;
            label6.Text = "Task Date";
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(comboBox1);
            pnlForAdmin.Controls.Add(label4);
            pnlForAdmin.Controls.Add(cmbxDepartment);
            pnlForAdmin.Controls.Add(label5);
            pnlForAdmin.Controls.Add(txtSurname);
            pnlForAdmin.Controls.Add(label3);
            pnlForAdmin.Controls.Add(txtName);
            pnlForAdmin.Controls.Add(label2);
            pnlForAdmin.Controls.Add(txtUserNo);
            pnlForAdmin.Controls.Add(label1);
            pnlForAdmin.Dock = DockStyle.Left;
            pnlForAdmin.Location = new Point(0, 0);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(303, 225);
            pnlForAdmin.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 29);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 145);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 15;
            label4.Text = "Position";
            // 
            // cmbxDepartment
            // 
            cmbxDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbxDepartment.FormattingEnabled = true;
            cmbxDepartment.Location = new Point(136, 103);
            cmbxDepartment.Name = "cmbxDepartment";
            cmbxDepartment.Size = new Size(148, 29);
            cmbxDepartment.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 103);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 14;
            label5.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.None;
            txtSurname.Location = new Point(136, 71);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(148, 16);
            txtSurname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 6;
            label3.Text = "Surname";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(136, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 16);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.BorderStyle = BorderStyle.None;
            txtUserNo.Location = new Point(136, 12);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(148, 16);
            txtUserNo.TabIndex = 0;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 2;
            label1.Text = "UserNo.";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnApprove);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 455);
            panel2.Name = "panel2";
            panel2.Size = new Size(814, 100);
            panel2.TabIndex = 1;
            // 
            // btnApprove
            // 
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApprove.Location = new Point(89, 35);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(87, 31);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(406, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 31);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(299, 35);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 31);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(193, 35);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(87, 31);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(811, 190);
            dataGridView1.TabIndex = 2;
            // 
            // FrmTaskList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 555);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmTaskList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task List";
            Load += FrmTaskList_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlForAdmin.ResumeLayout(false);
            pnlForAdmin.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnApprove;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Panel pnlForAdmin;
        private Panel panel3;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtUserNo;
        private Label label1;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox cmbxDepartment;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private RadioButton rdStartDate;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private RadioButton rdDeliverDate;
        private ComboBox cmbTaskState;
        private Label label9;
        private Button btnClear;
        private Button btnSearch;
        private Button btnClose;
        private Button btnNew;
    }
}