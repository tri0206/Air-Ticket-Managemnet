namespace AirTicketOfficeManagement
{
    partial class fMainPage
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
            components = new System.ComponentModel.Container();
            PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainPage));
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            tc1 = new TabControl();
            tpFlight = new TabPage();
            btnViewFlight = new Button();
            btnTicket = new Button();
            dtgvFlight = new DataGridView();
            btnSearch = new Button();
            txtKeyword = new TextBox();
            tpAirport = new TabPage();
            panel3 = new Panel();
            panel7 = new Panel();
            txtNameAirport = new TextBox();
            label3 = new Label();
            panel8 = new Panel();
            cbNation = new ComboBox();
            label4 = new Label();
            panel6 = new Panel();
            txtIDAirport = new TextBox();
            label2 = new Label();
            btnViewAirport = new Button();
            btnDeleteAirport = new Button();
            btnFixAirport = new Button();
            btnAddAirport = new Button();
            btnSearchAirport = new Button();
            txtAirport = new TextBox();
            dtgvAirport = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            tpBuyTicket = new TabPage();
            dtpDateBuyTicket = new DateTimePicker();
            label11 = new Label();
            txtStaffBuyTicket = new TextBox();
            dtgvBuyTicket = new DataGridView();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            panel9 = new Panel();
            btnDeleteTicket = new Button();
            btnUpdateTicket = new Button();
            btnBuyTicket = new Button();
            dtgvPlace = new DataGridView();
            nameAirport = new DataGridViewTextBoxColumn();
            nameAirport1 = new DataGridViewTextBoxColumn();
            btnCheckFlight = new Button();
            txtPrice = new TextBox();
            txtPassport = new TextBox();
            txtNamePassenger = new TextBox();
            txtIdTicket = new TextBox();
            txtCheckFlight = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            btnFlightManage = new Button();
            label1 = new Label();
            btnExitt = new Button();
            btnLogout = new Button();
            btnBill = new Button();
            btnTicketManage = new Button();
            btnPlaneManage = new Button();
            btnMyself = new Button();
            btnAdmin = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            tc1.SuspendLayout();
            tpFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFlight).BeginInit();
            tpAirport.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAirport).BeginInit();
            tpBuyTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBuyTicket).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPlace).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1232, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(11, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 749);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(6, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(1238, 269);
            panel2.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(tc1);
            panel5.Location = new Point(235, 283);
            panel5.Name = "panel5";
            panel5.Size = new Size(1009, 459);
            panel5.TabIndex = 3;
            // 
            // tc1
            // 
            tc1.Controls.Add(tpFlight);
            tc1.Controls.Add(tpAirport);
            tc1.Controls.Add(tpBuyTicket);
            tc1.Location = new Point(12, 4);
            tc1.Name = "tc1";
            tc1.SelectedIndex = 0;
            tc1.Size = new Size(994, 452);
            tc1.TabIndex = 0;
            // 
            // tpFlight
            // 
            tpFlight.Controls.Add(btnViewFlight);
            tpFlight.Controls.Add(btnTicket);
            tpFlight.Controls.Add(dtgvFlight);
            tpFlight.Controls.Add(btnSearch);
            tpFlight.Controls.Add(txtKeyword);
            tpFlight.Location = new Point(4, 29);
            tpFlight.Name = "tpFlight";
            tpFlight.Padding = new Padding(3);
            tpFlight.Size = new Size(986, 419);
            tpFlight.TabIndex = 0;
            tpFlight.Text = "Lịch bay";
            tpFlight.UseVisualStyleBackColor = true;
            tpFlight.Click += tabPage1_Click;
            // 
            // btnViewFlight
            // 
            btnViewFlight.Location = new Point(690, 3);
            btnViewFlight.Name = "btnViewFlight";
            btnViewFlight.Size = new Size(141, 67);
            btnViewFlight.TabIndex = 5;
            btnViewFlight.Text = "Xem";
            btnViewFlight.UseVisualStyleBackColor = true;
            btnViewFlight.Click += btnViewFlight_Click;
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(837, 3);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(142, 67);
            btnTicket.TabIndex = 4;
            btnTicket.Text = "Đặt vé";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // dtgvFlight
            // 
            dtgvFlight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFlight.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFlight.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dtgvFlight.Location = new Point(5, 80);
            dtgvFlight.Name = "dtgvFlight";
            dtgvFlight.RowHeadersWidth = 51;
            dtgvFlight.RowTemplate.Height = 29;
            dtgvFlight.Size = new Size(974, 333);
            dtgvFlight.TabIndex = 3;
            dtgvFlight.CellContentClick += dataGridView1_CellContentClick;
            dtgvFlight.SelectionChanged += dtgvFlight_SelectionChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(590, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(188, 25);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(396, 27);
            txtKeyword.TabIndex = 1;
            txtKeyword.TextChanged += txtKeyword_TextChanged;
            // 
            // tpAirport
            // 
            tpAirport.AutoScroll = true;
            tpAirport.Controls.Add(panel3);
            tpAirport.Controls.Add(btnViewAirport);
            tpAirport.Controls.Add(btnDeleteAirport);
            tpAirport.Controls.Add(btnFixAirport);
            tpAirport.Controls.Add(btnAddAirport);
            tpAirport.Controls.Add(btnSearchAirport);
            tpAirport.Controls.Add(txtAirport);
            tpAirport.Controls.Add(dtgvAirport);
            tpAirport.Location = new Point(4, 29);
            tpAirport.Name = "tpAirport";
            tpAirport.Padding = new Padding(3);
            tpAirport.Size = new Size(986, 419);
            tpAirport.TabIndex = 1;
            tpAirport.Text = "Sân bay";
            tpAirport.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(530, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 352);
            panel3.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtNameAirport);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(3, 138);
            panel7.Name = "panel7";
            panel7.Size = new Size(444, 70);
            panel7.TabIndex = 1;
            // 
            // txtNameAirport
            // 
            txtNameAirport.Location = new Point(133, 21);
            txtNameAirport.Name = "txtNameAirport";
            txtNameAirport.Size = new Size(290, 27);
            txtNameAirport.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 25);
            label3.Name = "label3";
            label3.Size = new Size(112, 19);
            label3.TabIndex = 0;
            label3.Text = "Tên Sân bay:";
            // 
            // panel8
            // 
            panel8.Controls.Add(cbNation);
            panel8.Controls.Add(label4);
            panel8.Location = new Point(3, 230);
            panel8.Name = "panel8";
            panel8.Size = new Size(444, 70);
            panel8.TabIndex = 1;
            // 
            // cbNation
            // 
            cbNation.FormattingEnabled = true;
            cbNation.Items.AddRange(new object[] { "Việt Nam", "Hàn Quốc", "Nhật Bản", "Trung Quốc", "Hoa Kỳ", "Pháp", "Đức" });
            cbNation.Location = new Point(107, 19);
            cbNation.Name = "cbNation";
            cbNation.Size = new Size(316, 28);
            cbNation.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 23);
            label4.Name = "label4";
            label4.Size = new Size(85, 19);
            label4.TabIndex = 0;
            label4.Text = "Quốc gia:";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtIDAirport);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(3, 48);
            panel6.Name = "panel6";
            panel6.Size = new Size(444, 70);
            panel6.TabIndex = 0;
            // 
            // txtIDAirport
            // 
            txtIDAirport.Location = new Point(96, 25);
            txtIDAirport.Name = "txtIDAirport";
            txtIDAirport.Size = new Size(327, 27);
            txtIDAirport.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 24);
            label2.Name = "label2";
            label2.Size = new Size(31, 19);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // btnViewAirport
            // 
            btnViewAirport.Location = new Point(399, 3);
            btnViewAirport.Name = "btnViewAirport";
            btnViewAirport.Size = new Size(125, 54);
            btnViewAirport.TabIndex = 6;
            btnViewAirport.Text = "Xem";
            btnViewAirport.UseVisualStyleBackColor = true;
            btnViewAirport.Click += btnViewAirport_Click;
            // 
            // btnDeleteAirport
            // 
            btnDeleteAirport.Location = new Point(268, 3);
            btnDeleteAirport.Name = "btnDeleteAirport";
            btnDeleteAirport.Size = new Size(125, 54);
            btnDeleteAirport.TabIndex = 5;
            btnDeleteAirport.Text = "Xóa";
            btnDeleteAirport.UseVisualStyleBackColor = true;
            btnDeleteAirport.Click += btnDeleteAirport_Click;
            // 
            // btnFixAirport
            // 
            btnFixAirport.Location = new Point(137, 3);
            btnFixAirport.Name = "btnFixAirport";
            btnFixAirport.Size = new Size(125, 54);
            btnFixAirport.TabIndex = 4;
            btnFixAirport.Text = "Sửa";
            btnFixAirport.UseVisualStyleBackColor = true;
            btnFixAirport.Click += btnFixAirport_Click;
            // 
            // btnAddAirport
            // 
            btnAddAirport.Location = new Point(6, 3);
            btnAddAirport.Name = "btnAddAirport";
            btnAddAirport.Size = new Size(125, 54);
            btnAddAirport.TabIndex = 3;
            btnAddAirport.Text = "Thêm";
            btnAddAirport.UseVisualStyleBackColor = true;
            btnAddAirport.Click += btnAddAirport_Click;
            // 
            // btnSearchAirport
            // 
            btnSearchAirport.Location = new Point(860, 16);
            btnSearchAirport.Name = "btnSearchAirport";
            btnSearchAirport.Size = new Size(120, 29);
            btnSearchAirport.TabIndex = 2;
            btnSearchAirport.Text = "Tìm kiếm";
            btnSearchAirport.UseVisualStyleBackColor = true;
            btnSearchAirport.Click += btnSearchAirport_Click;
            // 
            // txtAirport
            // 
            txtAirport.Location = new Point(530, 17);
            txtAirport.Name = "txtAirport";
            txtAirport.Size = new Size(324, 27);
            txtAirport.TabIndex = 1;
            // 
            // dtgvAirport
            // 
            dtgvAirport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAirport.Columns.AddRange(new DataGridViewColumn[] { Column8, Column9, Column10 });
            dtgvAirport.Location = new Point(6, 60);
            dtgvAirport.Name = "dtgvAirport";
            dtgvAirport.RowHeadersWidth = 51;
            dtgvAirport.RowTemplate.Height = 29;
            dtgvAirport.Size = new Size(518, 352);
            dtgvAirport.TabIndex = 0;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "idAirport";
            Column8.HeaderText = "ID";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 130;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "nameAirport";
            Column9.HeaderText = "Tên sân bay";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 170;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "nation";
            Column10.HeaderText = "Quốc gia";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 170;
            // 
            // tpBuyTicket
            // 
            tpBuyTicket.AutoScroll = true;
            tpBuyTicket.Controls.Add(dtpDateBuyTicket);
            tpBuyTicket.Controls.Add(label11);
            tpBuyTicket.Controls.Add(txtStaffBuyTicket);
            tpBuyTicket.Controls.Add(dtgvBuyTicket);
            tpBuyTicket.Controls.Add(panel9);
            tpBuyTicket.Controls.Add(dtgvPlace);
            tpBuyTicket.Controls.Add(btnCheckFlight);
            tpBuyTicket.Controls.Add(txtPrice);
            tpBuyTicket.Controls.Add(txtPassport);
            tpBuyTicket.Controls.Add(txtNamePassenger);
            tpBuyTicket.Controls.Add(txtIdTicket);
            tpBuyTicket.Controls.Add(txtCheckFlight);
            tpBuyTicket.Controls.Add(label10);
            tpBuyTicket.Controls.Add(label9);
            tpBuyTicket.Controls.Add(label8);
            tpBuyTicket.Controls.Add(label7);
            tpBuyTicket.Controls.Add(label6);
            tpBuyTicket.Controls.Add(label5);
            tpBuyTicket.Location = new Point(4, 29);
            tpBuyTicket.Name = "tpBuyTicket";
            tpBuyTicket.Padding = new Padding(3);
            tpBuyTicket.Size = new Size(986, 419);
            tpBuyTicket.TabIndex = 2;
            tpBuyTicket.Text = "Đặt vé";
            tpBuyTicket.UseVisualStyleBackColor = true;
            // 
            // dtpDateBuyTicket
            // 
            dtpDateBuyTicket.Location = new Point(368, 171);
            dtpDateBuyTicket.Name = "dtpDateBuyTicket";
            dtpDateBuyTicket.Size = new Size(367, 27);
            dtpDateBuyTicket.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(368, 131);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 16;
            label11.Text = "Nhân viên";
            // 
            // txtStaffBuyTicket
            // 
            txtStaffBuyTicket.Location = new Point(449, 128);
            txtStaffBuyTicket.Name = "txtStaffBuyTicket";
            txtStaffBuyTicket.ReadOnly = true;
            txtStaffBuyTicket.Size = new Size(67, 27);
            txtStaffBuyTicket.TabIndex = 15;
            txtStaffBuyTicket.TextChanged += txtStaffBuyTicket_TextChanged;
            // 
            // dtgvBuyTicket
            // 
            dtgvBuyTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBuyTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBuyTicket.Columns.AddRange(new DataGridViewColumn[] { Column11, Column12, Column13, Column14, Column15, Column16, Column17 });
            dtgvBuyTicket.Location = new Point(12, 219);
            dtgvBuyTicket.Name = "dtgvBuyTicket";
            dtgvBuyTicket.RowHeadersWidth = 51;
            dtgvBuyTicket.RowTemplate.Height = 29;
            dtgvBuyTicket.Size = new Size(974, 188);
            dtgvBuyTicket.TabIndex = 14;
            dtgvBuyTicket.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column11
            // 
            Column11.DataPropertyName = "idTicket";
            Column11.HeaderText = "Mã vé";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.DataPropertyName = "idFlight";
            Column12.HeaderText = "Chuyến bay";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            // 
            // Column13
            // 
            Column13.DataPropertyName = "namePassenger";
            Column13.HeaderText = "Tên hành khách";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            // 
            // Column14
            // 
            Column14.DataPropertyName = "Passport";
            Column14.HeaderText = "Passport";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            // 
            // Column15
            // 
            Column15.DataPropertyName = "price";
            Column15.HeaderText = "Giá";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            // 
            // Column16
            // 
            Column16.DataPropertyName = "nameStaff";
            Column16.HeaderText = "Nhân viên bán vé";
            Column16.MinimumWidth = 6;
            Column16.Name = "Column16";
            // 
            // Column17
            // 
            Column17.DataPropertyName = "dateBuy";
            Column17.HeaderText = "Ngày bán";
            Column17.MinimumWidth = 6;
            Column17.Name = "Column17";
            // 
            // panel9
            // 
            panel9.Controls.Add(btnDeleteTicket);
            panel9.Controls.Add(btnUpdateTicket);
            panel9.Controls.Add(btnBuyTicket);
            panel9.Location = new Point(741, 8);
            panel9.Name = "panel9";
            panel9.Size = new Size(240, 208);
            panel9.TabIndex = 13;
            // 
            // btnDeleteTicket
            // 
            btnDeleteTicket.Location = new Point(71, 142);
            btnDeleteTicket.Name = "btnDeleteTicket";
            btnDeleteTicket.Size = new Size(115, 63);
            btnDeleteTicket.TabIndex = 2;
            btnDeleteTicket.Text = "Hủy vé";
            btnDeleteTicket.UseVisualStyleBackColor = true;
            btnDeleteTicket.Click += btnDeleteTicket_Click;
            // 
            // btnUpdateTicket
            // 
            btnUpdateTicket.Location = new Point(71, 73);
            btnUpdateTicket.Name = "btnUpdateTicket";
            btnUpdateTicket.Size = new Size(115, 63);
            btnUpdateTicket.TabIndex = 1;
            btnUpdateTicket.Text = "Sửa đổi";
            btnUpdateTicket.UseVisualStyleBackColor = true;
            btnUpdateTicket.Click += btnUpdateTicket_Click;
            // 
            // btnBuyTicket
            // 
            btnBuyTicket.Location = new Point(71, 4);
            btnBuyTicket.Name = "btnBuyTicket";
            btnBuyTicket.Size = new Size(115, 63);
            btnBuyTicket.TabIndex = 0;
            btnBuyTicket.Text = "Mua";
            btnBuyTicket.UseVisualStyleBackColor = true;
            btnBuyTicket.Click += btnBuyTicket_Click;
            // 
            // dtgvPlace
            // 
            dtgvPlace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPlace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPlace.Columns.AddRange(new DataGridViewColumn[] { nameAirport, nameAirport1 });
            dtgvPlace.Location = new Point(368, 10);
            dtgvPlace.Name = "dtgvPlace";
            dtgvPlace.RowHeadersWidth = 51;
            dtgvPlace.RowTemplate.Height = 29;
            dtgvPlace.Size = new Size(367, 65);
            dtgvPlace.TabIndex = 12;
            dtgvPlace.AutoSizeColumnsModeChanged += fill;
            // 
            // nameAirport
            // 
            nameAirport.DataPropertyName = "nameAirport";
            nameAirport.HeaderText = "Chuyến bay đi";
            nameAirport.MinimumWidth = 6;
            nameAirport.Name = "nameAirport";
            // 
            // nameAirport1
            // 
            nameAirport1.DataPropertyName = "nameAirport1";
            nameAirport1.HeaderText = "Chuyến bay đến";
            nameAirport1.MinimumWidth = 6;
            nameAirport1.Name = "nameAirport1";
            // 
            // btnCheckFlight
            // 
            btnCheckFlight.Location = new Point(268, 11);
            btnCheckFlight.Name = "btnCheckFlight";
            btnCheckFlight.Size = new Size(94, 29);
            btnCheckFlight.TabIndex = 11;
            btnCheckFlight.Text = "Check";
            btnCheckFlight.UseVisualStyleBackColor = true;
            btnCheckFlight.Click += btnCheckFlight_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(85, 168);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(177, 27);
            txtPrice.TabIndex = 10;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtPassport
            // 
            txtPassport.Location = new Point(116, 128);
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(208, 27);
            txtPassport.TabIndex = 9;
            txtPassport.TextChanged += txtPassport_TextChanged;
            // 
            // txtNamePassenger
            // 
            txtNamePassenger.Location = new Point(162, 89);
            txtNamePassenger.Name = "txtNamePassenger";
            txtNamePassenger.Size = new Size(189, 27);
            txtNamePassenger.TabIndex = 8;
            txtNamePassenger.TextChanged += textBox3_TextChanged;
            // 
            // txtIdTicket
            // 
            txtIdTicket.Location = new Point(101, 48);
            txtIdTicket.Name = "txtIdTicket";
            txtIdTicket.Size = new Size(125, 27);
            txtIdTicket.TabIndex = 7;
            // 
            // txtCheckFlight
            // 
            txtCheckFlight.Location = new Point(137, 12);
            txtCheckFlight.Name = "txtCheckFlight";
            txtCheckFlight.Size = new Size(125, 27);
            txtCheckFlight.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(268, 171);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 5;
            label10.Text = "VNĐ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 171);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 4;
            label9.Text = "Giá:";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 131);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 3;
            label8.Text = "Passport:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 92);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 2;
            label7.Text = "Tên hành khách:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 55);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 1;
            label6.Text = "Mã vé:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 15);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 0;
            label5.Text = "Chuyến bay:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnFlightManage);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(btnExitt);
            panel4.Controls.Add(btnLogout);
            panel4.Controls.Add(btnBill);
            panel4.Controls.Add(btnTicketManage);
            panel4.Controls.Add(btnPlaneManage);
            panel4.Controls.Add(btnMyself);
            panel4.Controls.Add(btnAdmin);
            panel4.Location = new Point(6, 283);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 459);
            panel4.TabIndex = 2;
            // 
            // btnFlightManage
            // 
            btnFlightManage.Location = new Point(21, 193);
            btnFlightManage.Name = "btnFlightManage";
            btnFlightManage.Size = new Size(178, 45);
            btnFlightManage.TabIndex = 8;
            btnFlightManage.Text = "Quản lý chuyến bay";
            btnFlightManage.UseVisualStyleBackColor = true;
            btnFlightManage.Click += btnFlightManage_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 13);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 7;
            label1.Text = "Chức năng";
            // 
            // btnExitt
            // 
            btnExitt.Location = new Point(21, 397);
            btnExitt.Name = "btnExitt";
            btnExitt.Size = new Size(178, 45);
            btnExitt.TabIndex = 6;
            btnExitt.Text = "Thoát";
            btnExitt.UseVisualStyleBackColor = true;
            btnExitt.Click += btnExitt_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(21, 346);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(178, 45);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBill
            // 
            btnBill.Location = new Point(21, 295);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(178, 45);
            btnBill.TabIndex = 4;
            btnBill.Text = "Hóa đơn";
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += button5_Click;
            // 
            // btnTicketManage
            // 
            btnTicketManage.Location = new Point(21, 244);
            btnTicketManage.Name = "btnTicketManage";
            btnTicketManage.Size = new Size(178, 45);
            btnTicketManage.TabIndex = 3;
            btnTicketManage.Text = "Vé";
            btnTicketManage.UseVisualStyleBackColor = true;
            btnTicketManage.Click += btnTicketManage_Click;
            // 
            // btnPlaneManage
            // 
            btnPlaneManage.Location = new Point(21, 142);
            btnPlaneManage.Name = "btnPlaneManage";
            btnPlaneManage.Size = new Size(178, 45);
            btnPlaneManage.TabIndex = 2;
            btnPlaneManage.Text = "Quản lý máy bay";
            btnPlaneManage.UseVisualStyleBackColor = true;
            btnPlaneManage.Click += btnFlightManage_Click;
            // 
            // btnMyself
            // 
            btnMyself.Location = new Point(21, 91);
            btnMyself.Name = "btnMyself";
            btnMyself.Size = new Size(178, 45);
            btnMyself.TabIndex = 1;
            btnMyself.Text = "Cá nhân";
            btnMyself.UseVisualStyleBackColor = true;
            btnMyself.Click += btnMyself_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(21, 40);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(178, 45);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Column1
            // 
            Column1.DataPropertyName = "idFlight";
            Column1.HeaderText = "Chuyến bay";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "dayFly";
            Column2.HeaderText = "Thời gian";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "idPlane";
            Column3.HeaderText = "Máy bay";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "type";
            Column4.HeaderText = "Loại";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "airline";
            Column5.HeaderText = "Hãng";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "nameAirport";
            Column6.HeaderText = "Sân bay đi";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.DataPropertyName = "nameAirport1";
            Column7.HeaderText = "Sân bay tới";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // fMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 764);
            Controls.Add(panel1);
            Name = "fMainPage";
            Text = "Quản lý phòng vé máy bay";
            Load += fMainPage_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tc1.ResumeLayout(false);
            tpFlight.ResumeLayout(false);
            tpFlight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFlight).EndInit();
            tpAirport.ResumeLayout(false);
            tpAirport.PerformLayout();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAirport).EndInit();
            tpBuyTicket.ResumeLayout(false);
            tpBuyTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBuyTicket).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvPlace).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label label1;
        private Button btnExitt;
        private Button btnLogout;
        private Button btnBill;
        private Button btnTicketManage;
        private Button btnPlaneManage;
        private Button btnMyself;
        private Button btnAdmin;
        private Panel panel5;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private TabControl tc1;
        private TabPage tpFlight;
        private TabPage tpAirport;
        private TabPage tpBuyTicket;
        private DataGridView dtgvFlight;
        private Button btnSearch;
        private TextBox txtKeyword;
        private Button btnTicket;
        private Button btnViewFlight;
        private Button btnSearchAirport;
        private TextBox txtAirport;
        private DataGridView dtgvAirport;
        private Panel panel3;
        private Button btnViewAirport;
        private Button btnDeleteAirport;
        private Button btnFixAirport;
        private Button btnAddAirport;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Panel panel6;
        private Panel panel7;
        private TextBox txtNameAirport;
        private Label label3;
        private Panel panel8;
        private Label label4;
        private TextBox txtIDAirport;
        private Label label2;
        private ComboBox cbNation;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtPrice;
        private TextBox txtPassport;
        private TextBox txtNamePassenger;
        private TextBox txtIdTicket;
        private TextBox txtCheckFlight;
        private Label label10;
        private Label label9;
        private Button btnCheckFlight;
        private DataGridView dtgvPlace;
        private DataGridView dtgvBuyTicket;
        private Panel panel9;
        private Button btnDeleteTicket;
        private Button btnUpdateTicket;
        private Button btnBuyTicket;
        private DataGridViewTextBoxColumn nameAirport;
        private DataGridViewTextBoxColumn nameAirport1;
        private DateTimePicker dtpDateBuyTicket;
        private Label label11;
        private TextBox txtStaffBuyTicket;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private Button btnFlightManage;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}