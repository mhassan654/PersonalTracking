namespace PersonalTracking
{
    partial class Position
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
            label1 = new Label();
            txtPostion = new TextBox();
            label2 = new Label();
            cmbxDepartment = new ComboBox();
            btnClose = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Postion";
            label1.Click += label1_Click;
            // 
            // txtPostion
            // 
            txtPostion.Location = new Point(132, 28);
            txtPostion.Name = "txtPostion";
            txtPostion.Size = new Size(161, 23);
            txtPostion.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 2;
            label2.Text = "Department";
            // 
            // cmbxDepartment
            // 
            cmbxDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbxDepartment.FormattingEnabled = true;
            cmbxDepartment.Location = new Point(132, 82);
            cmbxDepartment.Name = "cmbxDepartment";
            cmbxDepartment.Size = new Size(161, 29);
            cmbxDepartment.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(0, 0, 192);
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(193, 160);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(12, 160);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 40);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Position
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 215);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(cmbxDepartment);
            Controls.Add(label2);
            Controls.Add(txtPostion);
            Controls.Add(label1);
            Name = "Position";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Position";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPostion;
        private Label label2;
        private ComboBox cmbxDepartment;
        private Button btnClose;
        private Button btnSave;
    }
}