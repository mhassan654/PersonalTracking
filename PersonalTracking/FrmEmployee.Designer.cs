namespace PersonalTracking
{
    partial class FrmEmployee
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
            chkAdmin = new CheckBox();
            txtPassword = new TextBox();
            btnCheck = new Button();
            label2 = new Label();
            txtUserNo = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            txtSurname = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnBrowse = new Button();
            txtSalary = new TextBox();
            label6 = new Label();
            cmbDepartment = new ComboBox();
            label7 = new Label();
            cmbPosition = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtAddress = new TextBox();
            label10 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chkAdmin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnCheck);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUserNo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 70);
            panel1.TabIndex = 0;
            // 
            // chkAdmin
            // 
            chkAdmin.AutoSize = true;
            chkAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chkAdmin.Location = new Point(654, 20);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(103, 25);
            chkAdmin.TabIndex = 6;
            chkAdmin.Text = "is Admin?";
            chkAdmin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(453, 26);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter User Password";
            txtPassword.Size = new Size(179, 16);
            txtPassword.TabIndex = 2;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(262, 19);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(365, 21);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtUserNo
            // 
            txtUserNo.BorderStyle = BorderStyle.None;
            txtUserNo.Location = new Point(89, 23);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(167, 16);
            txtUserNo.TabIndex = 0;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 2;
            label1.Text = "UserNo.";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(137, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(167, 16);
            txtName.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(137, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 16);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 181);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 7;
            label4.Text = "Image Path";
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.None;
            txtSurname.Location = new Point(137, 140);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(167, 16);
            txtSurname.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 138);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 9;
            label5.Text = "Surname";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(487, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 148);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(322, 182);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtSalary
            // 
            txtSalary.BorderStyle = BorderStyle.None;
            txtSalary.Location = new Point(137, 227);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(167, 16);
            txtSalary.TabIndex = 4;
            txtSalary.KeyPress += txtSalary_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 225);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 13;
            label6.Text = "Salary";
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(137, 262);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(167, 29);
            cmbDepartment.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 262);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 16;
            label7.Text = "Department";
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(137, 308);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(167, 29);
            cmbPosition.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 311);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 18;
            label8.Text = "Position";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 351);
            label9.Name = "label9";
            label9.Size = new Size(77, 21);
            label9.TabIndex = 19;
            label9.Text = "BirthDay";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(137, 351);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(167, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Location = new Point(137, 392);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(495, 139);
            txtAddress.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 390);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 21;
            label10.Text = "Address";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(0, 0, 192);
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(476, 567);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 40);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(295, 567);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 40);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 664);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(cmbPosition);
            Controls.Add(label8);
            Controls.Add(cmbDepartment);
            Controls.Add(label7);
            Controls.Add(txtSalary);
            Controls.Add(label6);
            Controls.Add(btnBrowse);
            Controls.Add(pictureBox1);
            Controls.Add(txtSurname);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "FrmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCheck;
        private TextBox txtUserNo;
        private Label label1;
        private CheckBox chkAdmin;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox txtSurname;
        private Label label5;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btnBrowse;
        private TextBox txtSalary;
        private Label label6;
        private ComboBox cmbDepartment;
        private Label label7;
        private ComboBox cmbPosition;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private TextBox txtAddress;
        private Label label10;
        private Button btnClose;
        private Button btnSave;
    }
}