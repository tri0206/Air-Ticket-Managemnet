namespace AirTicketOfficeManagement
{
    partial class fPlaneManage
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
            panel5 = new Panel();
            txtSearchPlane = new TextBox();
            btnSearchPlane = new Button();
            panel4 = new Panel();
            btnViewPlane = new Button();
            btnDeletePlane = new Button();
            btnUpdatePlane = new Button();
            btnAddPlane = new Button();
            panel3 = new Panel();
            panel7 = new Panel();
            txtType = new TextBox();
            label2 = new Label();
            panel8 = new Panel();
            txtAirline = new TextBox();
            label3 = new Label();
            panel9 = new Panel();
            txtSeat = new TextBox();
            label4 = new Label();
            panel6 = new Panel();
            txtIdPlane = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dtgvPlane = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPlane).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 485);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtSearchPlane);
            panel5.Controls.Add(btnSearchPlane);
            panel5.Location = new Point(421, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(352, 59);
            panel5.TabIndex = 3;
            // 
            // txtSearchPlane
            // 
            txtSearchPlane.Location = new Point(20, 16);
            txtSearchPlane.Name = "txtSearchPlane";
            txtSearchPlane.Size = new Size(229, 27);
            txtSearchPlane.TabIndex = 1;
            // 
            // btnSearchPlane
            // 
            btnSearchPlane.Location = new Point(255, 15);
            btnSearchPlane.Name = "btnSearchPlane";
            btnSearchPlane.Size = new Size(94, 29);
            btnSearchPlane.TabIndex = 0;
            btnSearchPlane.Text = "Tìm kiếm";
            btnSearchPlane.UseVisualStyleBackColor = true;
            btnSearchPlane.Click += btnSearchPlane_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnViewPlane);
            panel4.Controls.Add(btnDeletePlane);
            panel4.Controls.Add(btnUpdatePlane);
            panel4.Controls.Add(btnAddPlane);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(412, 59);
            panel4.TabIndex = 2;
            // 
            // btnViewPlane
            // 
            btnViewPlane.Location = new Point(300, 5);
            btnViewPlane.Name = "btnViewPlane";
            btnViewPlane.Size = new Size(93, 48);
            btnViewPlane.TabIndex = 3;
            btnViewPlane.Text = "Xem";
            btnViewPlane.UseVisualStyleBackColor = true;
            btnViewPlane.Click += btnViewPlane_Click;
            // 
            // btnDeletePlane
            // 
            btnDeletePlane.Location = new Point(201, 5);
            btnDeletePlane.Name = "btnDeletePlane";
            btnDeletePlane.Size = new Size(93, 48);
            btnDeletePlane.TabIndex = 2;
            btnDeletePlane.Text = "Xóa";
            btnDeletePlane.UseVisualStyleBackColor = true;
            btnDeletePlane.Click += btnDeletePlane_Click;
            // 
            // btnUpdatePlane
            // 
            btnUpdatePlane.Location = new Point(102, 5);
            btnUpdatePlane.Name = "btnUpdatePlane";
            btnUpdatePlane.RightToLeft = RightToLeft.No;
            btnUpdatePlane.Size = new Size(93, 48);
            btnUpdatePlane.TabIndex = 1;
            btnUpdatePlane.Text = "Sửa";
            btnUpdatePlane.UseVisualStyleBackColor = true;
            btnUpdatePlane.Click += btnUpdatePlane_Click;
            // 
            // btnAddPlane
            // 
            btnAddPlane.Location = new Point(3, 5);
            btnAddPlane.Name = "btnAddPlane";
            btnAddPlane.Size = new Size(93, 48);
            btnAddPlane.TabIndex = 0;
            btnAddPlane.Text = "Thêm";
            btnAddPlane.UseVisualStyleBackColor = true;
            btnAddPlane.Click += btnAddPlane_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(441, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 414);
            panel3.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtType);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(3, 97);
            panel7.Name = "panel7";
            panel7.Size = new Size(346, 76);
            panel7.TabIndex = 1;
            // 
            // txtType
            // 
            txtType.Location = new Point(109, 26);
            txtType.Name = "txtType";
            txtType.Size = new Size(217, 27);
            txtType.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 0;
            label2.Text = "Loại máy bay:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtAirline);
            panel8.Controls.Add(label3);
            panel8.Location = new Point(3, 179);
            panel8.Name = "panel8";
            panel8.Size = new Size(346, 76);
            panel8.TabIndex = 1;
            // 
            // txtAirline
            // 
            txtAirline.Location = new Point(139, 22);
            txtAirline.Name = "txtAirline";
            txtAirline.Size = new Size(187, 27);
            txtAirline.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 25);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 0;
            label3.Text = "Hãng hàng không:";
            // 
            // panel9
            // 
            panel9.Controls.Add(txtSeat);
            panel9.Controls.Add(label4);
            panel9.Location = new Point(3, 261);
            panel9.Name = "panel9";
            panel9.Size = new Size(346, 76);
            panel9.TabIndex = 1;
            // 
            // txtSeat
            // 
            txtSeat.Location = new Point(86, 25);
            txtSeat.Name = "txtSeat";
            txtSeat.Size = new Size(240, 27);
            txtSeat.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 28);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 0;
            label4.Text = "Hạng ghế:";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtIdPlane);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(3, 15);
            panel6.Name = "panel6";
            panel6.Size = new Size(346, 76);
            panel6.TabIndex = 0;
            // 
            // txtIdPlane
            // 
            txtIdPlane.Location = new Point(102, 29);
            txtIdPlane.Name = "txtIdPlane";
            txtIdPlane.Size = new Size(224, 27);
            txtIdPlane.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã máy bay:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvPlane);
            panel2.Location = new Point(3, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 414);
            panel2.TabIndex = 0;
            // 
            // dtgvPlane
            // 
            dtgvPlane.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPlane.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dtgvPlane.Location = new Point(-3, 3);
            dtgvPlane.Name = "dtgvPlane";
            dtgvPlane.RowHeadersWidth = 51;
            dtgvPlane.RowTemplate.Height = 29;
            dtgvPlane.Size = new Size(432, 408);
            dtgvPlane.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "idPlane";
            Column1.HeaderText = "Mã máy bay";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "type";
            Column2.HeaderText = "Loại";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 80;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "airline";
            Column3.HeaderText = "Hãng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 90;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "seat";
            Column4.HeaderText = "Hạng ghế";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 130;
            // 
            // fPlaneManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 509);
            Controls.Add(panel1);
            Name = "fPlaneManage";
            Text = "Quản lý máy bay";
            Load += fPlaneManage_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvPlane).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Button btnViewPlane;
        private Button btnDeletePlane;
        private Button btnUpdatePlane;
        private Button btnAddPlane;
        private Panel panel3;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel6;
        private Panel panel2;
        private TextBox txtSearchPlane;
        private Button btnSearchPlane;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox txtType;
        private TextBox txtAirline;
        private TextBox txtSeat;
        private TextBox txtIdPlane;
        private DataGridView dtgvPlane;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}