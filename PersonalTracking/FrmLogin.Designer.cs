namespace PersonalTracking
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUserNo = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnEnter = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 54);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 0;
            label1.Text = "UserNo.";
            // 
            // txtUserNo
            // 
            txtUserNo.BorderStyle = BorderStyle.None;
            txtUserNo.Location = new Point(167, 56);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(229, 16);
            txtUserNo.TabIndex = 1;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(167, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter User Password";
            txtPassword.Size = new Size(229, 16);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 114);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Teal;
            btnEnter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(86, 246);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(85, 35);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(279, 246);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 35);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 309);
            Controls.Add(btnExit);
            Controls.Add(btnEnter);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUserNo);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "Login";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserNo;
        private TextBox txtPassword;
        private Label label2;
        private Button btnEnter;
        private Button btnExit;
    }
}