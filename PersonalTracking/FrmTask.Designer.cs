namespace PersonalTracking
{
    partial class FrmTask
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            cmbxDepartment = new ComboBox();
            label5 = new Label();
            txtSurname = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            name = new Label();
            txtUserNo = new TextBox();
            label1 = new Label();
            cmbTaskState = new ComboBox();
            label9 = new Label();
            TxtTitle = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(600, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(200, 339);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cmbxDepartment);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 111);
            panel2.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 29);
            comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 56);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 19;
            label4.Text = "Position";
            // 
            // cmbxDepartment
            // 
            cmbxDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbxDepartment.FormattingEnabled = true;
            cmbxDepartment.Location = new Point(16, 24);
            cmbxDepartment.Name = "cmbxDepartment";
            cmbxDepartment.Size = new Size(148, 29);
            cmbxDepartment.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 18;
            label5.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.AllowDrop = true;
            txtSurname.Location = new Point(131, 97);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(157, 23);
            txtSurname.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 95);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 12;
            label2.Text = "Surname";
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 54);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(157, 23);
            txtName.TabIndex = 1;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(6, 52);
            name.Name = "name";
            name.Size = new Size(56, 21);
            name.TabIndex = 11;
            name.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(131, 12);
            txtUserNo.Multiline = true;
            txtUserNo.Name = "txtUserNo";
            txtUserNo.ReadOnly = true;
            txtUserNo.Size = new Size(157, 23);
            txtUserNo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 10);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 10;
            label1.Text = "UserNo.";
            // 
            // cmbTaskState
            // 
            cmbTaskState.CausesValidation = false;
            cmbTaskState.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbTaskState.FormattingEnabled = true;
            cmbTaskState.Location = new Point(131, 133);
            cmbTaskState.Name = "cmbTaskState";
            cmbTaskState.Size = new Size(157, 29);
            cmbTaskState.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(6, 133);
            label9.Name = "label9";
            label9.Size = new Size(86, 21);
            label9.TabIndex = 19;
            label9.Text = "Task State";
            // 
            // TxtTitle
            // 
            TxtTitle.BorderStyle = BorderStyle.None;
            TxtTitle.Location = new Point(130, 183);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(158, 16);
            TxtTitle.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 180);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 21;
            label3.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(130, 222);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 170);
            textBox1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 219);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 23;
            label6.Text = "Content";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(0, 0, 192);
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(324, 398);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 40);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(143, 398);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(TxtTitle);
            Controls.Add(label3);
            Controls.Add(cmbTaskState);
            Controls.Add(label9);
            Controls.Add(txtSurname);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(name);
            Controls.Add(txtUserNo);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Form";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox cmbxDepartment;
        private Label label5;
        private TextBox txtSurname;
        private Label label2;
        private TextBox txtName;
        private Label name;
        private TextBox txtUserNo;
        private Label label1;
        private ComboBox cmbTaskState;
        private Label label9;
        private TextBox TxtTitle;
        private Label label3;
        private TextBox textBox1;
        private Label label6;
        private Button btnClose;
        private Button btnSave;
    }
}