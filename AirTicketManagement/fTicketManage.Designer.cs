namespace AirTicketOfficeManagement
{
    partial class fTicketManage
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
            panel4 = new Panel();
            btnSearchTicket = new Button();
            txtSearchTicket = new TextBox();
            panel3 = new Panel();
            dtgvTicket = new DataGridView();
            panel2 = new Panel();
            label9 = new Label();
            txtPriceTicket = new TextBox();
            label8 = new Label();
            TxtSeat = new TextBox();
            TxtIdFlight = new TextBox();
            txtPassport = new TextBox();
            txtNamePassenger = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtIdTicket = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTicket).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 723);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSearchTicket);
            panel4.Controls.Add(txtSearchTicket);
            panel4.Location = new Point(3, 354);
            panel4.Name = "panel4";
            panel4.Size = new Size(837, 48);
            panel4.TabIndex = 2;
            // 
            // btnSearchTicket
            // 
            btnSearchTicket.Location = new Point(469, 11);
            btnSearchTicket.Name = "btnSearchTicket";
            btnSearchTicket.Size = new Size(94, 27);
            btnSearchTicket.TabIndex = 1;
            btnSearchTicket.Text = "Tìm kiếm";
            btnSearchTicket.UseVisualStyleBackColor = true;
            btnSearchTicket.Click += btnSearchTicket_Click;
            // 
            // txtSearchTicket
            // 
            txtSearchTicket.Location = new Point(212, 11);
            txtSearchTicket.Name = "txtSearchTicket";
            txtSearchTicket.Size = new Size(251, 27);
            txtSearchTicket.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvTicket);
            panel3.Location = new Point(3, 408);
            panel3.Name = "panel3";
            panel3.Size = new Size(837, 312);
            panel3.TabIndex = 1;
            // 
            // dtgvTicket
            // 
            dtgvTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTicket.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dtgvTicket.Location = new Point(3, 3);
            dtgvTicket.Name = "dtgvTicket";
            dtgvTicket.RowHeadersWidth = 51;
            dtgvTicket.RowTemplate.Height = 29;
            dtgvTicket.Size = new Size(831, 306);
            dtgvTicket.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtPriceTicket);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(TxtSeat);
            panel2.Controls.Add(TxtIdFlight);
            panel2.Controls.Add(txtPassport);
            panel2.Controls.Add(txtNamePassenger);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtIdTicket);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(837, 345);
            panel2.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(569, 251);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 15;
            label9.Text = "VNĐ";
            // 
            // txtPriceTicket
            // 
            txtPriceTicket.Location = new Point(438, 248);
            txtPriceTicket.Name = "txtPriceTicket";
            txtPriceTicket.Size = new Size(125, 27);
            txtPriceTicket.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(370, 251);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 13;
            label8.Text = "Giá tiền:";
            // 
            // TxtSeat
            // 
            TxtSeat.Location = new Point(109, 248);
            TxtSeat.Name = "TxtSeat";
            TxtSeat.Size = new Size(147, 27);
            TxtSeat.TabIndex = 12;
            // 
            // TxtIdFlight
            // 
            TxtIdFlight.Location = new Point(162, 204);
            TxtIdFlight.Name = "TxtIdFlight";
            TxtIdFlight.Size = new Size(147, 27);
            TxtIdFlight.TabIndex = 11;
            // 
            // txtPassport
            // 
            txtPassport.Location = new Point(99, 152);
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(147, 27);
            txtPassport.TabIndex = 10;
            // 
            // txtNamePassenger
            // 
            txtNamePassenger.Location = new Point(146, 106);
            txtNamePassenger.Name = "txtNamePassenger";
            txtNamePassenger.Size = new Size(205, 27);
            txtNamePassenger.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 251);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 8;
            label7.Text = "Hạng ghế:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 207);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 7;
            label6.Text = "Mã số chuyến bay:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 155);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 6;
            label5.Text = "Passport:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 109);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 5;
            label4.Text = "Tên khách hàng:";
            // 
            // txtIdTicket
            // 
            txtIdTicket.Location = new Point(740, 18);
            txtIdTicket.Name = "txtIdTicket";
            txtIdTicket.Size = new Size(68, 27);
            txtIdTicket.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(660, 21);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 3;
            label3.Text = "Mã số vé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(317, 21);
            label2.Name = "label2";
            label2.Size = new Size(158, 37);
            label2.TabIndex = 2;
            label2.Text = "Vé máy bay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(236, 41);
            label1.TabIndex = 1;
            label1.Text = "Team 17 Airline";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(691, 271);
            button1.Name = "button1";
            button1.Size = new Size(143, 71);
            button1.TabIndex = 0;
            button1.Text = "Xuất vé";
            button1.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "idTicket";
            Column1.HeaderText = "Mã số vé";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "namePassenger";
            Column2.HeaderText = "Tên khách hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 160;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Passport";
            Column3.HeaderText = "Passport";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "idFlight";
            Column4.HeaderText = "Mã số chuyến bay";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "seat";
            Column5.HeaderText = "Hạng ghế";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "price";
            Column6.HeaderText = "Giá tiền";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // fTicketManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 747);
            Controls.Add(panel1);
            Name = "fTicketManage";
            Text = "fTicketManage";
            Load += fTicketManage_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTicket).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Button btnSearchTicket;
        private Button button1;
        private TextBox txtSearchTicket;
        private Panel panel3;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private TextBox TxtSeat;
        private TextBox TxtIdFlight;
        private TextBox txtPassport;
        private TextBox txtNamePassenger;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtIdTicket;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtgvTicket;
        private TextBox txtPriceTicket;
        private Label label8;
        private Label label9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}