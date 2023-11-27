namespace PersonalTracking
{
    partial class FrmPermissionsList
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
            panel2 = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            TxtDayAmount = new TextBox();
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
            dataGridView1 = new DataGridView();
            btnApprove = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            BtnClose = new Button();
            BtnDisapprove = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlForAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlForAdmin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 193);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(TxtDayAmount);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(287, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(513, 193);
            panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(342, 156);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 31);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(342, 109);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtDayAmount
            // 
            TxtDayAmount.BorderStyle = BorderStyle.None;
            TxtDayAmount.Location = new Point(118, 136);
            TxtDayAmount.Name = "TxtDayAmount";
            TxtDayAmount.Size = new Size(170, 16);
            TxtDayAmount.TabIndex = 2;
            TxtDayAmount.KeyPress += TxtDayAmount_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(6, 133);
            label9.Name = "label9";
            label9.Size = new Size(106, 21);
            label9.TabIndex = 21;
            label9.Text = "Day Amount";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdDeliverDate);
            groupBox1.Controls.Add(rdStartDate);
            groupBox1.Location = new Point(299, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 12;
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
            dateTimePicker2.Location = new Point(118, 96);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(170, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(118, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 98);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 11;
            label7.Text = "End Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 52);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 10;
            label8.Text = "Start Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 12);
            label6.Name = "label6";
            label6.Size = new Size(141, 21);
            label6.TabIndex = 8;
            label6.Text = "Permissions Date";
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
            pnlForAdmin.Size = new Size(287, 193);
            pnlForAdmin.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(127, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 29);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 145);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 25;
            label4.Text = "Position";
            // 
            // cmbxDepartment
            // 
            cmbxDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbxDepartment.FormattingEnabled = true;
            cmbxDepartment.Location = new Point(127, 103);
            cmbxDepartment.Name = "cmbxDepartment";
            cmbxDepartment.Size = new Size(148, 29);
            cmbxDepartment.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 103);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 24;
            label5.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.None;
            txtSurname.Location = new Point(127, 71);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(148, 16);
            txtSurname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 66);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 23;
            label3.Text = "Surname";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(127, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 16);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 22;
            label2.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.BorderStyle = BorderStyle.None;
            txtUserNo.Location = new Point(127, 12);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(148, 16);
            txtUserNo.TabIndex = 0;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 19;
            label1.Text = "UserNo.";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 177);
            dataGridView1.TabIndex = 1;
            // 
            // btnApprove
            // 
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApprove.Location = new Point(155, 376);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(113, 31);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(488, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 31);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(381, 376);
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
            btnNew.Location = new Point(275, 376);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(87, 31);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // BtnClose
            // 
            BtnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnClose.Location = new Point(592, 376);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(113, 31);
            BtnClose.TabIndex = 4;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            BtnClose.KeyPress += BtnClose_KeyPress;
            // 
            // BtnDisapprove
            // 
            BtnDisapprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDisapprove.Location = new Point(162, 413);
            BtnDisapprove.Name = "BtnDisapprove";
            BtnDisapprove.Size = new Size(113, 31);
            BtnDisapprove.TabIndex = 5;
            BtnDisapprove.Text = "Disapprove";
            BtnDisapprove.UseVisualStyleBackColor = true;
            // 
            // FrmPermissionsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDisapprove);
            Controls.Add(BtnClose);
            Controls.Add(btnApprove);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FrmPermissionsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permissions List";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlForAdmin.ResumeLayout(false);
            pnlForAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel pnlForAdmin;
        private Button btnApprove;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button BtnClose;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox cmbxDepartment;
        private Label label5;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtUserNo;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rdDeliverDate;
        private RadioButton rdStartDate;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label8;
        private Label label6;
        private TextBox TxtDayAmount;
        private Label label9;
        private Button btnClear;
        private Button btnSearch;
        private Button BtnDisapprove;
        private Button btnNew;
    }
}