namespace AirTicketOfficeManagement
{
    partial class fPersonal
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
            panel7 = new Panel();
            txtPersonalId = new TextBox();
            label4 = new Label();
            panel6 = new Panel();
            txtChangePassword = new TextBox();
            txtNewPassword = new Label();
            btnChangePassword = new Button();
            panel5 = new Panel();
            txtOldPass = new TextBox();
            txtOldPassword = new Label();
            panel3 = new Panel();
            txtPersonalDob = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            txtPersonalUsername = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            txtPersonalName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btnChangePassword);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 436);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtPersonalId);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(463, 56);
            panel7.TabIndex = 2;
            // 
            // txtPersonalId
            // 
            txtPersonalId.Location = new Point(67, 17);
            txtPersonalId.Name = "txtPersonalId";
            txtPersonalId.ReadOnly = true;
            txtPersonalId.Size = new Size(393, 27);
            txtPersonalId.TabIndex = 1;
            txtPersonalId.TextChanged += txtPersonalId_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 20);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 0;
            label4.Text = "ID:";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtChangePassword);
            panel6.Controls.Add(txtNewPassword);
            panel6.Location = new Point(3, 313);
            panel6.Name = "panel6";
            panel6.Size = new Size(463, 52);
            panel6.TabIndex = 4;
            // 
            // txtChangePassword
            // 
            txtChangePassword.Location = new Point(141, 17);
            txtChangePassword.Name = "txtChangePassword";
            txtChangePassword.Size = new Size(319, 27);
            txtChangePassword.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.AutoSize = true;
            txtNewPassword.Location = new Point(3, 17);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(103, 20);
            txtNewPassword.TabIndex = 0;
            txtNewPassword.Text = "Mật khẩu mới:";
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(349, 371);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(114, 62);
            btnChangePassword.TabIndex = 4;
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtOldPass);
            panel5.Controls.Add(txtOldPassword);
            panel5.Location = new Point(3, 255);
            panel5.Name = "panel5";
            panel5.Size = new Size(463, 52);
            panel5.TabIndex = 3;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(141, 17);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.ReadOnly = true;
            txtOldPass.Size = new Size(319, 27);
            txtOldPass.TabIndex = 1;
            // 
            // txtOldPassword
            // 
            txtOldPassword.AutoSize = true;
            txtOldPassword.Location = new Point(3, 20);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(92, 20);
            txtOldPassword.TabIndex = 0;
            txtOldPassword.Text = "Mật khẩu cũ:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPersonalDob);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 126);
            panel3.Name = "panel3";
            panel3.Size = new Size(463, 58);
            panel3.TabIndex = 2;
            // 
            // txtPersonalDob
            // 
            txtPersonalDob.Location = new Point(141, 17);
            txtPersonalDob.Name = "txtPersonalDob";
            txtPersonalDob.ReadOnly = true;
            txtPersonalDob.Size = new Size(319, 27);
            txtPersonalDob.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 20);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 0;
            label2.Text = "Ngày sinh:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtPersonalUsername);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 190);
            panel4.Name = "panel4";
            panel4.Size = new Size(463, 59);
            panel4.TabIndex = 2;
            // 
            // txtPersonalUsername
            // 
            txtPersonalUsername.Location = new Point(141, 17);
            txtPersonalUsername.Name = "txtPersonalUsername";
            txtPersonalUsername.ReadOnly = true;
            txtPersonalUsername.Size = new Size(319, 27);
            txtPersonalUsername.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 20);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 0;
            label3.Text = "Tài khoản:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPersonalName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 56);
            panel2.TabIndex = 0;
            // 
            // txtPersonalName
            // 
            txtPersonalName.Location = new Point(141, 17);
            txtPersonalName.Name = "txtPersonalName";
            txtPersonalName.ReadOnly = true;
            txtPersonalName.Size = new Size(319, 27);
            txtPersonalName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 20);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // fPersonal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 460);
            Controls.Add(panel1);
            Name = "fPersonal";
            Text = "fPersonal";
            Load += fPersonal_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txtPersonalDob;
        private Label label2;
        private Panel panel4;
        private TextBox txtPersonalUsername;
        private Label label3;
        private Panel panel2;
        private TextBox txtPersonalName;
        private Label label1;
        private Button btnChangePassword;
        private Panel panel5;
        private TextBox txtOldPass;
        private Label txtOldPassword;
        private Panel panel6;
        private TextBox txtChangePassword;
        private Label txtNewPassword;
        private Panel panel7;
        private TextBox txtPersonalId;
        private Label label4;
    }
}