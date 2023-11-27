namespace PersonalTracking
{
    partial class FrmSalaryList
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
            panel4 = new Panel();
            button1 = new Button();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            rdEqual = new RadioButton();
            rdLess = new RadioButton();
            rbMore = new RadioButton();
            TxtYear = new TextBox();
            label7 = new Label();
            cmbMonth = new ComboBox();
            label6 = new Label();
            TxtSalary = new TextBox();
            label8 = new Label();
            panel3 = new Panel();
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
            panel2 = new Panel();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 198);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(TxtYear);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(cmbMonth);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(TxtSalary);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(332, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(468, 198);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(262, 147);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 4;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnClose_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(81, 147);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 40);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdEqual);
            groupBox1.Controls.Add(rdLess);
            groupBox1.Controls.Add(rbMore);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(233, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 53);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            // 
            // rdEqual
            // 
            rdEqual.AutoSize = true;
            rdEqual.Location = new Point(160, 13);
            rdEqual.Name = "rdEqual";
            rdEqual.Size = new Size(63, 23);
            rdEqual.TabIndex = 2;
            rdEqual.TabStop = true;
            rdEqual.Text = "Equal";
            rdEqual.UseVisualStyleBackColor = true;
            // 
            // rdLess
            // 
            rdLess.AutoSize = true;
            rdLess.Location = new Point(75, 13);
            rdLess.Name = "rdLess";
            rdLess.Size = new Size(54, 23);
            rdLess.TabIndex = 1;
            rdLess.TabStop = true;
            rdLess.Text = "Less";
            rdLess.UseVisualStyleBackColor = true;
            // 
            // rbMore
            // 
            rbMore.AutoSize = true;
            rbMore.Location = new Point(6, 13);
            rbMore.Name = "rbMore";
            rbMore.Size = new Size(63, 23);
            rbMore.TabIndex = 0;
            rbMore.TabStop = true;
            rbMore.Text = "More";
            rbMore.UseVisualStyleBackColor = true;
            // 
            // TxtYear
            // 
            TxtYear.Location = new Point(93, 50);
            TxtYear.Multiline = true;
            TxtYear.Name = "TxtYear";
            TxtYear.Size = new Size(134, 23);
            TxtYear.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 47);
            label7.Name = "label7";
            label7.Size = new Size(43, 21);
            label7.TabIndex = 30;
            label7.Text = "Year";
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(93, 86);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(134, 29);
            cmbMonth.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 85);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 28;
            label6.Text = "Month";
            // 
            // TxtSalary
            // 
            TxtSalary.Location = new Point(93, 14);
            TxtSalary.Multiline = true;
            TxtSalary.Name = "TxtSalary";
            TxtSalary.Size = new Size(134, 23);
            TxtSalary.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(17, 11);
            label8.Name = "label8";
            label8.Size = new Size(58, 21);
            label8.TabIndex = 27;
            label8.Text = "Salary";
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cmbxDepartment);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtSurname);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtUserNo);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 198);
            panel3.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(146, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 29);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 147);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 25;
            label4.Text = "Position";
            // 
            // cmbxDepartment
            // 
            cmbxDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbxDepartment.FormattingEnabled = true;
            cmbxDepartment.Location = new Point(146, 105);
            cmbxDepartment.Name = "cmbxDepartment";
            cmbxDepartment.Size = new Size(148, 29);
            cmbxDepartment.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 105);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 24;
            label5.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.None;
            txtSurname.Location = new Point(146, 73);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(148, 16);
            txtSurname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 68);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 23;
            label3.Text = "Surname";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(146, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 16);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 42);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 22;
            label2.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.BorderStyle = BorderStyle.None;
            txtUserNo.Location = new Point(146, 14);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(148, 16);
            txtUserNo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 11);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 19;
            label1.Text = "UserNo.";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 198);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 245);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 437);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 78);
            panel2.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(515, 22);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(87, 31);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(397, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(281, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 31);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(188, 22);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(87, 31);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // FrmSalaryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FrmSalaryList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary List";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
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
        private TextBox TxtYear;
        private Label label7;
        private ComboBox cmbMonth;
        private Label label6;
        private TextBox TxtSalary;
        private Label label8;
        private GroupBox groupBox1;
        private RadioButton rbMore;
        private RadioButton rdEqual;
        private RadioButton rdLess;
        private Button button1;
        private Button btnSearch;
        private Button btnNew;
    }
}