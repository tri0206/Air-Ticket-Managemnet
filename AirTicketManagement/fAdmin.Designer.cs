namespace AirTicketOfficeManagement
{
    partial class fAdmin
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
            tcAdmin = new TabControl();
            tpStaffManage = new TabPage();
            panel4 = new Panel();
            panel6 = new Panel();
            txtNameStaff = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            dtpkStaff = new DateTimePicker();
            label3 = new Label();
            panel8 = new Panel();
            txtUserNameStaff = new TextBox();
            label4 = new Label();
            panel9 = new Panel();
            txtPassWordStaff = new TextBox();
            label5 = new Label();
            panel5 = new Panel();
            txtIDStaff = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            txtFindStaff = new TextBox();
            btnSearchStaff = new Button();
            panel2 = new Panel();
            dtgvStaff = new DataGridView();
            idStaff = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnViewStaff = new Button();
            btnDeleteStaff = new Button();
            btnFixStaff = new Button();
            btnAddStaff = new Button();
            tpReport = new TabPage();
            panel11 = new Panel();
            dtgvReport = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            panel10 = new Panel();
            dtpkReport = new DateTimePicker();
            label10 = new Label();
            txtTotalPrice = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cbYears = new ComboBox();
            cbMonths = new ComboBox();
            cbDays = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            btnReport = new Button();
            tcAdmin.SuspendLayout();
            tpStaffManage.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStaff).BeginInit();
            panel1.SuspendLayout();
            tpReport.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvReport).BeginInit();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpStaffManage);
            tcAdmin.Controls.Add(tpReport);
            tcAdmin.Location = new Point(11, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(968, 664);
            tcAdmin.TabIndex = 1;
            tcAdmin.SelectedIndexChanged += tcAdmin_SelectedIndexChanged;
            // 
            // tpStaffManage
            // 
            tpStaffManage.Controls.Add(panel4);
            tpStaffManage.Controls.Add(panel3);
            tpStaffManage.Controls.Add(panel2);
            tpStaffManage.Controls.Add(panel1);
            tpStaffManage.Location = new Point(4, 29);
            tpStaffManage.Name = "tpStaffManage";
            tpStaffManage.Padding = new Padding(3);
            tpStaffManage.Size = new Size(960, 631);
            tpStaffManage.TabIndex = 0;
            tpStaffManage.Text = "Quản lý nhân viên";
            tpStaffManage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(554, 87);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(398, 533);
            panel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtNameStaff);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(13, 118);
            panel6.Name = "panel6";
            panel6.Size = new Size(373, 71);
            panel6.TabIndex = 2;
            // 
            // txtNameStaff
            // 
            txtNameStaff.Location = new Point(93, 21);
            txtNameStaff.Name = "txtNameStaff";
            txtNameStaff.Size = new Size(277, 27);
            txtNameStaff.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 24);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên:";
            // 
            // panel7
            // 
            panel7.Controls.Add(dtpkStaff);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(13, 195);
            panel7.Name = "panel7";
            panel7.Size = new Size(373, 71);
            panel7.TabIndex = 2;
            // 
            // dtpkStaff
            // 
            dtpkStaff.Location = new Point(96, 19);
            dtpkStaff.Name = "dtpkStaff";
            dtpkStaff.Size = new Size(274, 27);
            dtpkStaff.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 24);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 0;
            label3.Text = "Ngày sinh:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtUserNameStaff);
            panel8.Controls.Add(label4);
            panel8.Location = new Point(13, 272);
            panel8.Name = "panel8";
            panel8.Size = new Size(373, 71);
            panel8.TabIndex = 2;
            // 
            // txtUserNameStaff
            // 
            txtUserNameStaff.Location = new Point(93, 21);
            txtUserNameStaff.Name = "txtUserNameStaff";
            txtUserNameStaff.Size = new Size(277, 27);
            txtUserNameStaff.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 24);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 0;
            label4.Text = "Tài khoản:";
            // 
            // panel9
            // 
            panel9.Controls.Add(txtPassWordStaff);
            panel9.Controls.Add(label5);
            panel9.Location = new Point(13, 358);
            panel9.Name = "panel9";
            panel9.Size = new Size(373, 71);
            panel9.TabIndex = 2;
            // 
            // txtPassWordStaff
            // 
            txtPassWordStaff.Location = new Point(93, 21);
            txtPassWordStaff.Name = "txtPassWordStaff";
            txtPassWordStaff.Size = new Size(277, 27);
            txtPassWordStaff.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 24);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 0;
            label5.Text = "Mật khẩu";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtIDStaff);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(13, 41);
            panel5.Name = "panel5";
            panel5.Size = new Size(373, 71);
            panel5.TabIndex = 0;
            // 
            // txtIDStaff
            // 
            txtIDStaff.Location = new Point(93, 21);
            txtIDStaff.Name = "txtIDStaff";
            txtIDStaff.Size = new Size(277, 27);
            txtIDStaff.TabIndex = 1;
            txtIDStaff.Tag = "dtgvStaff";
            txtIDStaff.TextChanged += txtIDStaff_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 24);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtFindStaff);
            panel3.Controls.Add(btnSearchStaff);
            panel3.Location = new Point(554, 7);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(398, 72);
            panel3.TabIndex = 2;
            // 
            // txtFindStaff
            // 
            txtFindStaff.Location = new Point(13, 23);
            txtFindStaff.Margin = new Padding(3, 4, 3, 4);
            txtFindStaff.Name = "txtFindStaff";
            txtFindStaff.Size = new Size(255, 27);
            txtFindStaff.TabIndex = 5;
            // 
            // btnSearchStaff
            // 
            btnSearchStaff.Location = new Point(275, 23);
            btnSearchStaff.Margin = new Padding(3, 4, 3, 4);
            btnSearchStaff.Name = "btnSearchStaff";
            btnSearchStaff.Size = new Size(111, 31);
            btnSearchStaff.TabIndex = 4;
            btnSearchStaff.Text = "Tìm kiếm";
            btnSearchStaff.UseVisualStyleBackColor = true;
            btnSearchStaff.Click += btnSearchStaff_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvStaff);
            panel2.Location = new Point(7, 87);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(541, 533);
            panel2.TabIndex = 1;
            // 
            // dtgvStaff
            // 
            dtgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStaff.Columns.AddRange(new DataGridViewColumn[] { idStaff, Column2, Column3, Column4, Column5 });
            dtgvStaff.Location = new Point(3, 8);
            dtgvStaff.Margin = new Padding(3, 4, 3, 4);
            dtgvStaff.Name = "dtgvStaff";
            dtgvStaff.RowHeadersWidth = 51;
            dtgvStaff.RowTemplate.Height = 25;
            dtgvStaff.Size = new Size(534, 525);
            dtgvStaff.TabIndex = 0;
            dtgvStaff.CellContentClick += dtgvStaff_CellContentClick;
            // 
            // idStaff
            // 
            idStaff.DataPropertyName = "idStaff";
            idStaff.HeaderText = "ID";
            idStaff.MinimumWidth = 6;
            idStaff.Name = "idStaff";
            idStaff.Width = 96;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "nameStaff";
            Column2.HeaderText = "Tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 96;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "dobStaff";
            Column3.HeaderText = "Ngày sinh";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 97;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "UserName";
            Column4.HeaderText = "Tài khoản";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 96;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "passWord";
            Column5.HeaderText = "Mật khẩu";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 96;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewStaff);
            panel1.Controls.Add(btnDeleteStaff);
            panel1.Controls.Add(btnFixStaff);
            panel1.Controls.Add(btnAddStaff);
            panel1.Location = new Point(7, 7);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 72);
            panel1.TabIndex = 0;
            // 
            // btnViewStaff
            // 
            btnViewStaff.Location = new Point(423, 4);
            btnViewStaff.Margin = new Padding(3, 4, 3, 4);
            btnViewStaff.Name = "btnViewStaff";
            btnViewStaff.Size = new Size(111, 64);
            btnViewStaff.TabIndex = 3;
            btnViewStaff.Text = "Xem";
            btnViewStaff.UseVisualStyleBackColor = true;
            btnViewStaff.Click += btnViewStaff_Click;
            // 
            // btnDeleteStaff
            // 
            btnDeleteStaff.Location = new Point(290, 4);
            btnDeleteStaff.Margin = new Padding(3, 4, 3, 4);
            btnDeleteStaff.Name = "btnDeleteStaff";
            btnDeleteStaff.Size = new Size(104, 64);
            btnDeleteStaff.TabIndex = 2;
            btnDeleteStaff.Text = "Xóa";
            btnDeleteStaff.UseVisualStyleBackColor = true;
            btnDeleteStaff.Click += btnDeleteStaff_Click;
            // 
            // btnFixStaff
            // 
            btnFixStaff.Location = new Point(147, 4);
            btnFixStaff.Margin = new Padding(3, 4, 3, 4);
            btnFixStaff.Name = "btnFixStaff";
            btnFixStaff.Size = new Size(117, 64);
            btnFixStaff.TabIndex = 1;
            btnFixStaff.Text = "Sửa";
            btnFixStaff.UseVisualStyleBackColor = true;
            btnFixStaff.Click += btnFixStaff_Click;
            // 
            // btnAddStaff
            // 
            btnAddStaff.Location = new Point(3, 4);
            btnAddStaff.Margin = new Padding(3, 4, 3, 4);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(118, 64);
            btnAddStaff.TabIndex = 0;
            btnAddStaff.Text = "Thêm";
            btnAddStaff.UseVisualStyleBackColor = true;
            btnAddStaff.Click += btnAddStaff_Click;
            // 
            // tpReport
            // 
            tpReport.Controls.Add(panel11);
            tpReport.Controls.Add(panel10);
            tpReport.Location = new Point(4, 29);
            tpReport.Name = "tpReport";
            tpReport.Padding = new Padding(3);
            tpReport.Size = new Size(960, 631);
            tpReport.TabIndex = 1;
            tpReport.Text = "Báo cáo-Thống kê";
            tpReport.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(dtgvReport);
            panel11.Location = new Point(6, 234);
            panel11.Name = "panel11";
            panel11.Size = new Size(948, 391);
            panel11.TabIndex = 1;
            // 
            // dtgvReport
            // 
            dtgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvReport.Columns.AddRange(new DataGridViewColumn[] { Column1, Column6, Column7, Column8, Column9, Column10, Column11 });
            dtgvReport.Location = new Point(9, 3);
            dtgvReport.Name = "dtgvReport";
            dtgvReport.RowHeadersWidth = 51;
            dtgvReport.RowTemplate.Height = 29;
            dtgvReport.Size = new Size(942, 455);
            dtgvReport.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "idTicket";
            Column1.HeaderText = "Mã vé";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "idFlight";
            Column6.HeaderText = "Mã chuyến bay";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "namePassenger";
            Column7.HeaderText = "Tên khách hàng";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "Passport";
            Column8.HeaderText = "Passport";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "dayFly";
            Column9.HeaderText = "Ngày bay";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 175;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "dateBuy";
            Column10.HeaderText = "Ngày mua vé";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.DataPropertyName = "price";
            Column11.HeaderText = "Giá tiền";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // panel10
            // 
            panel10.Controls.Add(dtpkReport);
            panel10.Controls.Add(label10);
            panel10.Controls.Add(txtTotalPrice);
            panel10.Controls.Add(label9);
            panel10.Controls.Add(label8);
            panel10.Controls.Add(label7);
            panel10.Controls.Add(label6);
            panel10.Controls.Add(cbYears);
            panel10.Controls.Add(cbMonths);
            panel10.Controls.Add(cbDays);
            panel10.Controls.Add(monthCalendar1);
            panel10.Controls.Add(btnReport);
            panel10.Location = new Point(6, 6);
            panel10.Name = "panel10";
            panel10.Size = new Size(948, 222);
            panel10.TabIndex = 0;
            // 
            // dtpkReport
            // 
            dtpkReport.Location = new Point(351, 59);
            dtpkReport.Name = "dtpkReport";
            dtpkReport.Size = new Size(333, 27);
            dtpkReport.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(790, 165);
            label10.Name = "label10";
            label10.Size = new Size(68, 35);
            label10.TabIndex = 11;
            label10.Text = "VNĐ";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalPrice.Location = new Point(504, 162);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(280, 40);
            txtTotalPrice.TabIndex = 10;
            txtTotalPrice.TextChanged += txtTotalPrice_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(301, 165);
            label9.Name = "label9";
            label9.Size = new Size(204, 35);
            label9.TabIndex = 9;
            label9.Text = "Tổng doanh thu:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(557, 15);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 8;
            label8.Text = "Năm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 15);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 7;
            label7.Text = "Tháng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 14);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 6;
            label6.Text = "Ngày";
            // 
            // cbYears
            // 
            cbYears.FormattingEnabled = true;
            cbYears.Items.AddRange(new object[] { "2023", "2024", "2025" });
            cbYears.Location = new Point(604, 12);
            cbYears.Name = "cbYears";
            cbYears.Size = new Size(80, 28);
            cbYears.TabIndex = 5;
            // 
            // cbMonths
            // 
            cbMonths.FormattingEnabled = true;
            cbMonths.Items.AddRange(new object[] { "0", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cbMonths.Location = new Point(477, 12);
            cbMonths.Name = "cbMonths";
            cbMonths.Size = new Size(74, 28);
            cbMonths.TabIndex = 4;
            // 
            // cbDays
            // 
            cbDays.FormattingEnabled = true;
            cbDays.Items.AddRange(new object[] { "0", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cbDays.Location = new Point(351, 11);
            cbDays.Name = "cbDays";
            cbDays.Size = new Size(68, 28);
            cbDays.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(3, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(690, 12);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(94, 27);
            btnReport.TabIndex = 0;
            btnReport.Text = "Thống kê";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 705);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            Text = "fAdmin";
            Load += fAdmin_Load;
            tcAdmin.ResumeLayout(false);
            tpStaffManage.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvStaff).EndInit();
            panel1.ResumeLayout(false);
            tpReport.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvReport).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpStaffManage;
        private TabPage tpReport;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button btnViewStaff;
        private Button btnDeleteStaff;
        private Button btnFixStaff;
        private Button btnAddStaff;
        private TextBox txtFindStaff;
        private Button btnSearchStaff;
        private DataGridView dtgvStaff;
        private DataGridViewTextBoxColumn idStaff;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel6;
        private TextBox txtNameStaff;
        private Label label2;
        private Panel panel7;
        private Label label3;
        private Panel panel8;
        private TextBox txtUserNameStaff;
        private Label label4;
        private Panel panel9;
        private TextBox txtPassWordStaff;
        private Label label5;
        private Panel panel5;
        private TextBox txtIDStaff;
        private Label label1;
        private Panel panel11;
        private DataGridView dtgvReport;
        private Panel panel10;
        private Button btnReport;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cbYears;
        private ComboBox cbMonths;
        private ComboBox cbDays;
        private MonthCalendar monthCalendar1;
        private Label label9;
        private Label label10;
        private TextBox txtTotalPrice;
        private DateTimePicker dtpkReport;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DateTimePicker dtpkStaff;
    }
}