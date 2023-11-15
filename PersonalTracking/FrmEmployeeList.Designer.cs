namespace PersonalTracking
{
    partial class FrmEmployeeList
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtUserNo = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            name = new Label();
            txtSurname = new TextBox();
            label2 = new Label();
            cmbxDepartment = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            btnSearch = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 235);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 413);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 68);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(521, 25);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(87, 31);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(403, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(287, 25);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 31);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(194, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 31);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtUserNo
            // 
            txtUserNo.BorderStyle = BorderStyle.None;
            txtUserNo.Location = new Point(145, 27);
            txtUserNo.Multiline = true;
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(148, 23);
            txtUserNo.TabIndex = 0;
            txtUserNo.TextChanged += txtUserNo_TextChanged;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 2;
            label1.Text = "UserNo.";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(145, 69);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(20, 67);
            name.Name = "name";
            name.Size = new Size(56, 21);
            name.TabIndex = 4;
            name.Text = "Name";
            name.Click += label2_Click;
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.None;
            txtSurname.Location = new Point(145, 112);
            txtSurname.Multiline = true;
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(148, 23);
            txtSurname.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 110);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 6;
            label2.Text = "Surname";
            // 
            // cmbxDepartment
            // 
            cmbxDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbxDepartment.FormattingEnabled = true;
            cmbxDepartment.Location = new Point(447, 27);
            cmbxDepartment.Name = "cmbxDepartment";
            cmbxDepartment.Size = new Size(161, 29);
            cmbxDepartment.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(327, 27);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 9;
            label3.Text = "Department";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(447, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 29);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(327, 69);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 11;
            label4.Text = "Position";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(673, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 31);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(673, 102);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 31);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // FrmEmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(cmbxDepartment);
            Controls.Add(label3);
            Controls.Add(txtSurname);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(name);
            Controls.Add(txtUserNo);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "FrmEmployeeList";
            Text = "FrmEmployeeList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtUserNo;
        private Label label1;
        private TextBox txtName;
        private Label name;
        private TextBox txtSurname;
        private Label label2;
        private ComboBox cmbxDepartment;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Button btnSearch;
        private Button btnClear;
    }
}