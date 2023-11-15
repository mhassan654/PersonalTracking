namespace PersonalTracking
{
    partial class FrmPermissions
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
            txtUserNo = new TextBox();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            txtDayAmount = new TextBox();
            label2 = new Label();
            txtExplanation = new TextBox();
            label3 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(147, 23);
            txtUserNo.Multiline = true;
            txtUserNo.Name = "txtUserNo";
            txtUserNo.ReadOnly = true;
            txtUserNo.Size = new Size(170, 23);
            txtUserNo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 12;
            label1.Text = "UserNo.";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(147, 116);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(170, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(147, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(5, 118);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 16;
            label7.Text = "End Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(5, 72);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 15;
            label8.Text = "Start Date";
            // 
            // txtDayAmount
            // 
            txtDayAmount.Location = new Point(147, 163);
            txtDayAmount.Multiline = true;
            txtDayAmount.Name = "txtDayAmount";
            txtDayAmount.ReadOnly = true;
            txtDayAmount.Size = new Size(170, 23);
            txtDayAmount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 161);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 18;
            label2.Text = "Day Amount";
            // 
            // txtExplanation
            // 
            txtExplanation.Location = new Point(147, 204);
            txtExplanation.Multiline = true;
            txtExplanation.Name = "txtExplanation";
            txtExplanation.Size = new Size(380, 188);
            txtExplanation.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 202);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 20;
            label3.Text = "Explanation";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(0, 0, 192);
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(389, 407);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 40);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(187, 407);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmPermissions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 459);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtExplanation);
            Controls.Add(label3);
            Controls.Add(txtDayAmount);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtUserNo);
            Controls.Add(label1);
            Name = "FrmPermissions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPermissions";
            Load += FrmPermissions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserNo;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label8;
        private TextBox txtDayAmount;
        private Label label2;
        private TextBox txtExplanation;
        private Label label3;
        private Button btnClose;
        private Button btnSave;
    }
}