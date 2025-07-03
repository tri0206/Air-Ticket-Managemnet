namespace AirTicketOfficeManagement
{
    partial class FlightManage
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
            panel7 = new Panel();
            txtIdPlane = new TextBox();
            label2 = new Label();
            panel8 = new Panel();
            txtIdAirportGo = new TextBox();
            label3 = new Label();
            panel9 = new Panel();
            txtIdAirportArrival = new TextBox();
            label4 = new Label();
            panel10 = new Panel();
            dtpkDayFly = new DateTimePicker();
            label5 = new Label();
            panel6 = new Panel();
            txtIdFlight = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            dtgvFlight = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnSearchFlight = new Button();
            txtSearchFlight = new TextBox();
            panel2 = new Panel();
            btnViewFlight = new Button();
            btnDeleteFlight = new Button();
            btnUpdateFlight = new Button();
            btnAddFlight = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFlight).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(961, 637);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(565, 66);
            panel5.Name = "panel5";
            panel5.Size = new Size(393, 568);
            panel5.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtIdPlane);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(3, 152);
            panel7.Name = "panel7";
            panel7.Size = new Size(387, 75);
            panel7.TabIndex = 2;
            // 
            // txtIdPlane
            // 
            txtIdPlane.Location = new Point(102, 21);
            txtIdPlane.Name = "txtIdPlane";
            txtIdPlane.Size = new Size(275, 27);
            txtIdPlane.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 24);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã máy bay:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtIdAirportGo);
            panel8.Controls.Add(label3);
            panel8.Location = new Point(3, 246);
            panel8.Name = "panel8";
            panel8.Size = new Size(387, 75);
            panel8.TabIndex = 2;
            // 
            // txtIdAirportGo
            // 
            txtIdAirportGo.Location = new Point(113, 21);
            txtIdAirportGo.Name = "txtIdAirportGo";
            txtIdAirportGo.Size = new Size(264, 27);
            txtIdAirportGo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 24);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã sân bay đi:";
            // 
            // panel9
            // 
            panel9.Controls.Add(txtIdAirportArrival);
            panel9.Controls.Add(label4);
            panel9.Location = new Point(3, 327);
            panel9.Name = "panel9";
            panel9.Size = new Size(390, 75);
            panel9.TabIndex = 2;
            // 
            // txtIdAirportArrival
            // 
            txtIdAirportArrival.Location = new Point(125, 21);
            txtIdAirportArrival.Name = "txtIdAirportArrival";
            txtIdAirportArrival.Size = new Size(252, 27);
            txtIdAirportArrival.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 24);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 0;
            label4.Text = "Mã sân bay đến:";
            label4.Click += label4_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(dtpkDayFly);
            panel10.Controls.Add(label5);
            panel10.Location = new Point(3, 408);
            panel10.Name = "panel10";
            panel10.Size = new Size(387, 148);
            panel10.TabIndex = 2;
            // 
            // dtpkDayFly
            // 
            dtpkDayFly.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dtpkDayFly.Format = DateTimePickerFormat.Custom;
            dtpkDayFly.Location = new Point(84, 16);
            dtpkDayFly.Name = "dtpkDayFly";
            dtpkDayFly.ShowUpDown = true;
            dtpkDayFly.Size = new Size(293, 27);
            dtpkDayFly.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 21);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 0;
            label5.Text = "Ngày bay:";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtIdFlight);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(3, 49);
            panel6.Name = "panel6";
            panel6.Size = new Size(387, 75);
            panel6.TabIndex = 0;
            // 
            // txtIdFlight
            // 
            txtIdFlight.Location = new Point(120, 21);
            txtIdFlight.Name = "txtIdFlight";
            txtIdFlight.Size = new Size(257, 27);
            txtIdFlight.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã chuyến bay:";
            // 
            // panel4
            // 
            panel4.Controls.Add(dtgvFlight);
            panel4.Location = new Point(3, 66);
            panel4.Name = "panel4";
            panel4.Size = new Size(556, 568);
            panel4.TabIndex = 2;
            // 
            // dtgvFlight
            // 
            dtgvFlight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFlight.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFlight.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dtgvFlight.Location = new Point(3, 3);
            dtgvFlight.Name = "dtgvFlight";
            dtgvFlight.RowHeadersWidth = 51;
            dtgvFlight.RowTemplate.Height = 29;
            dtgvFlight.ScrollBars = ScrollBars.None;
            dtgvFlight.Size = new Size(550, 562);
            dtgvFlight.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "idFlight";
            Column1.HeaderText = "Mã chuyến bay";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "idPlane";
            Column2.HeaderText = "Mã máy bay";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "idAirportGo";
            Column3.HeaderText = "Mã sân bay đi";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "idAirportArrival";
            Column4.HeaderText = "Mã sân bay đến";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "dayFly";
            Column5.HeaderText = "Ngày bay";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSearchFlight);
            panel3.Controls.Add(txtSearchFlight);
            panel3.Location = new Point(459, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 57);
            panel3.TabIndex = 1;
            // 
            // btnSearchFlight
            // 
            btnSearchFlight.Location = new Point(392, 15);
            btnSearchFlight.Name = "btnSearchFlight";
            btnSearchFlight.Size = new Size(94, 29);
            btnSearchFlight.TabIndex = 1;
            btnSearchFlight.Text = "Tìm kiếm";
            btnSearchFlight.UseVisualStyleBackColor = true;
            btnSearchFlight.Click += btnSearchFlight_Click;
            // 
            // txtSearchFlight
            // 
            txtSearchFlight.Location = new Point(106, 15);
            txtSearchFlight.Name = "txtSearchFlight";
            txtSearchFlight.Size = new Size(280, 27);
            txtSearchFlight.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnViewFlight);
            panel2.Controls.Add(btnDeleteFlight);
            panel2.Controls.Add(btnUpdateFlight);
            panel2.Controls.Add(btnAddFlight);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 57);
            panel2.TabIndex = 0;
            // 
            // btnViewFlight
            // 
            btnViewFlight.Location = new Point(339, 3);
            btnViewFlight.Name = "btnViewFlight";
            btnViewFlight.Size = new Size(106, 51);
            btnViewFlight.TabIndex = 3;
            btnViewFlight.Text = "Xem";
            btnViewFlight.UseVisualStyleBackColor = true;
            btnViewFlight.Click += btnViewFlight_Click;
            // 
            // btnDeleteFlight
            // 
            btnDeleteFlight.Location = new Point(227, 3);
            btnDeleteFlight.Name = "btnDeleteFlight";
            btnDeleteFlight.Size = new Size(106, 51);
            btnDeleteFlight.TabIndex = 2;
            btnDeleteFlight.Text = "Xóa";
            btnDeleteFlight.UseVisualStyleBackColor = true;
            btnDeleteFlight.Click += btnDeleteFlight_Click;
            // 
            // btnUpdateFlight
            // 
            btnUpdateFlight.Location = new Point(115, 3);
            btnUpdateFlight.Name = "btnUpdateFlight";
            btnUpdateFlight.Size = new Size(106, 51);
            btnUpdateFlight.TabIndex = 1;
            btnUpdateFlight.Text = "Sửa";
            btnUpdateFlight.UseVisualStyleBackColor = true;
            btnUpdateFlight.Click += btnUpdateFlight_Click;
            // 
            // btnAddFlight
            // 
            btnAddFlight.Location = new Point(3, 3);
            btnAddFlight.Name = "btnAddFlight";
            btnAddFlight.Size = new Size(106, 51);
            btnAddFlight.TabIndex = 0;
            btnAddFlight.Text = "Thêm";
            btnAddFlight.UseVisualStyleBackColor = true;
            btnAddFlight.Click += btnAddFlight_Click;
            // 
            // FlightManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 661);
            Controls.Add(panel1);
            Name = "FlightManage";
            Text = "Quản lý chuyến bay";
            Load += FlightManage_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFlight).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Button btnViewFlight;
        private Button btnDeleteFlight;
        private Button btnUpdateFlight;
        private Button btnAddFlight;
        private Button btnSearchFlight;
        private TextBox txtSearchFlight;
        private DataGridView dtgvFlight;
        private Panel panel7;
        private TextBox txtIdPlane;
        private Label label2;
        private Panel panel8;
        private TextBox txtIdAirportGo;
        private Label label3;
        private Panel panel9;
        private TextBox txtIdAirportArrival;
        private Label label4;
        private Panel panel10;
        private Label label5;
        private Panel panel6;
        private TextBox txtIdFlight;
        private Label label1;
        private TextBox txtDayFly;
        private DateTimePicker dtpkDayFly;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}