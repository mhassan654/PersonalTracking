namespace PersonalTracking
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnEmployee = new Button();
            btnTasks = new Button();
            btnSalary = new Button();
            btnPosition = new Button();
            btnDepartment = new Button();
            btnPermissions = new Button();
            btnLogout = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(255, 128, 0);
            btnEmployee.Image = Properties.Resources.management;
            btnEmployee.ImageAlign = ContentAlignment.TopCenter;
            btnEmployee.Location = new Point(12, 12);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(126, 112);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Employees";
            btnEmployee.TextAlign = ContentAlignment.BottomCenter;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnTasks
            // 
            btnTasks.BackColor = Color.Cyan;
            btnTasks.Image = Properties.Resources.workspace1;
            btnTasks.ImageAlign = ContentAlignment.TopCenter;
            btnTasks.Location = new Point(155, 12);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(126, 112);
            btnTasks.TabIndex = 1;
            btnTasks.Text = "Tasks";
            btnTasks.TextAlign = ContentAlignment.BottomCenter;
            btnTasks.UseVisualStyleBackColor = false;
            btnTasks.Click += btnTasks_Click;
            // 
            // btnSalary
            // 
            btnSalary.BackColor = Color.FromArgb(0, 192, 0);
            btnSalary.Image = (Image)resources.GetObject("btnSalary.Image");
            btnSalary.ImageAlign = ContentAlignment.TopCenter;
            btnSalary.Location = new Point(299, 12);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(126, 112);
            btnSalary.TabIndex = 2;
            btnSalary.Text = "Salary";
            btnSalary.TextAlign = ContentAlignment.BottomCenter;
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += btnSalary_Click;
            // 
            // btnPosition
            // 
            btnPosition.BackColor = Color.Silver;
            btnPosition.Image = Properties.Resources.medal;
            btnPosition.ImageAlign = ContentAlignment.TopCenter;
            btnPosition.Location = new Point(299, 130);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new Size(126, 112);
            btnPosition.TabIndex = 5;
            btnPosition.Text = "Position";
            btnPosition.TextAlign = ContentAlignment.BottomCenter;
            btnPosition.UseVisualStyleBackColor = false;
            btnPosition.Click += btnPosition_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.BackColor = Color.FromArgb(192, 64, 0);
            btnDepartment.Image = Properties.Resources.organisation;
            btnDepartment.ImageAlign = ContentAlignment.TopCenter;
            btnDepartment.Location = new Point(155, 130);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(126, 112);
            btnDepartment.TabIndex = 4;
            btnDepartment.Text = "Department";
            btnDepartment.TextAlign = ContentAlignment.BottomCenter;
            btnDepartment.UseVisualStyleBackColor = false;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // btnPermissions
            // 
            btnPermissions.BackColor = Color.Green;
            btnPermissions.Image = Properties.Resources.management;
            btnPermissions.ImageAlign = ContentAlignment.TopCenter;
            btnPermissions.Location = new Point(12, 130);
            btnPermissions.Name = "btnPermissions";
            btnPermissions.Size = new Size(126, 112);
            btnPermissions.TabIndex = 3;
            btnPermissions.Text = "Permissions";
            btnPermissions.TextAlign = ContentAlignment.BottomCenter;
            btnPermissions.UseVisualStyleBackColor = false;
            btnPermissions.Click += btnPermissions_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.ImageAlign = ContentAlignment.TopCenter;
            btnLogout.Location = new Point(81, 276);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 112);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "LogOut";
            btnLogout.TextAlign = ContentAlignment.BottomCenter;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Blue;
            btnExit.Image = Properties.Resources.exit;
            btnExit.Location = new Point(233, 276);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(126, 112);
            btnExit.TabIndex = 7;
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 422);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnPosition);
            Controls.Add(btnDepartment);
            Controls.Add(btnPermissions);
            Controls.Add(btnSalary);
            Controls.Add(btnTasks);
            Controls.Add(btnEmployee);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Tracking";
            FormClosed += FrmMain_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmployee;
        private Button btnTasks;
        private Button btnSalary;
        private Button btnPosition;
        private Button btnDepartment;
        private Button btnPermissions;
        private Button btnLogout;
        private Button btnExit;
    }
}