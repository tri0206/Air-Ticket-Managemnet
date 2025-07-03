namespace AirTicketOfficeManagement
{
    partial class fBill
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
            dtgvBill = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnSearchBill = new Button();
            txtSearchBill = new TextBox();
            txtDateBuy = new TextBox();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            txtIdTicket = new TextBox();
            txtPrice = new TextBox();
            txtIdTicket2 = new TextBox();
            txtPrice2 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            txtTotalPrice = new TextBox();
            txtNamePassenger = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtIdBill = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvBill);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 740);
            panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4 });
            dtgvBill.Location = new Point(6, 466);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.RowTemplate.Height = 29;
            dtgvBill.Size = new Size(583, 271);
            dtgvBill.TabIndex = 1;
            dtgvBill.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "Mã hóa đơn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "idTicket";
            Column2.HeaderText = "Mã vé";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "namePassenger";
            Column3.HeaderText = "Khách hàng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "dateBuy";
            Column5.HeaderText = "Ngày mua";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "price";
            Column4.HeaderText = "Giá tiền";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearchBill);
            panel2.Controls.Add(txtSearchBill);
            panel2.Controls.Add(txtDateBuy);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtTotalPrice);
            panel2.Controls.Add(txtNamePassenger);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtIdBill);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 457);
            panel2.TabIndex = 0;
            // 
            // btnSearchBill
            // 
            btnSearchBill.Location = new Point(269, 411);
            btnSearchBill.Name = "btnSearchBill";
            btnSearchBill.Size = new Size(94, 29);
            btnSearchBill.TabIndex = 15;
            btnSearchBill.Text = "Tìm kiếm";
            btnSearchBill.UseVisualStyleBackColor = true;
            btnSearchBill.Click += btnSearchBill_Click;
            // 
            // txtSearchBill
            // 
            txtSearchBill.Location = new Point(25, 412);
            txtSearchBill.Name = "txtSearchBill";
            txtSearchBill.Size = new Size(238, 27);
            txtSearchBill.TabIndex = 14;
            // 
            // txtDateBuy
            // 
            txtDateBuy.Location = new Point(111, 342);
            txtDateBuy.Name = "txtDateBuy";
            txtDateBuy.Size = new Size(252, 27);
            txtDateBuy.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 345);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 12;
            label7.Text = "Ngày mua:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(textBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 0);
            tableLayoutPanel1.Controls.Add(txtIdTicket, 0, 1);
            tableLayoutPanel1.Controls.Add(txtPrice, 1, 1);
            tableLayoutPanel1.Controls.Add(txtIdTicket2, 0, 2);
            tableLayoutPanel1.Controls.Add(txtPrice2, 1, 2);
            tableLayoutPanel1.Location = new Point(25, 229);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.Size = new Size(525, 98);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 27);
            textBox2.TabIndex = 0;
            textBox2.Text = "Mã vé";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(265, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(257, 27);
            textBox3.TabIndex = 1;
            textBox3.Text = "Tổng tiền";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtIdTicket
            // 
            txtIdTicket.Location = new Point(3, 36);
            txtIdTicket.Name = "txtIdTicket";
            txtIdTicket.Size = new Size(256, 27);
            txtIdTicket.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(265, 36);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(257, 27);
            txtPrice.TabIndex = 3;
            // 
            // txtIdTicket2
            // 
            txtIdTicket2.Location = new Point(3, 69);
            txtIdTicket2.Name = "txtIdTicket2";
            txtIdTicket2.Size = new Size(256, 27);
            txtIdTicket2.TabIndex = 4;
            // 
            // txtPrice2
            // 
            txtPrice2.Location = new Point(265, 69);
            txtPrice2.Name = "txtPrice2";
            txtPrice2.Size = new Size(257, 27);
            txtPrice2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(426, 393);
            button1.Name = "button1";
            button1.Size = new Size(159, 61);
            button1.TabIndex = 10;
            button1.Text = "Xuất hóa đơn";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 189);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 9;
            label6.Text = "VNĐ";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(106, 186);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(184, 27);
            txtTotalPrice.TabIndex = 8;
            // 
            // txtNamePassenger
            // 
            txtNamePassenger.Location = new Point(169, 148);
            txtNamePassenger.Name = "txtNamePassenger";
            txtNamePassenger.Size = new Size(273, 27);
            txtNamePassenger.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 189);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 5;
            label5.Text = "Tổng tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 151);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 4;
            label4.Text = "Tên khách hàng:";
            // 
            // txtIdBill
            // 
            txtIdBill.Location = new Point(477, 29);
            txtIdBill.Name = "txtIdBill";
            txtIdBill.Size = new Size(73, 27);
            txtIdBill.TabIndex = 3;
            txtIdBill.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(222, 87);
            label3.Name = "label3";
            label3.Size = new Size(141, 41);
            label3.TabIndex = 2;
            label3.Text = "Hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(380, 36);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã số hóa đơn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(257, 45);
            label1.TabIndex = 0;
            label1.Text = "Team 17 Airline";
            // 
            // fBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 764);
            Controls.Add(panel1);
            Name = "fBill";
            Text = "Hóa đơn";
            Load += fBill_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private TextBox txtIdBill;
        private DataGridView dtgvBill;
        private Label label6;
        private TextBox txtTotalPrice;
        private TextBox txtNamePassenger;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSearchBill;
        private TextBox txtSearchBill;
        private TextBox txtDateBuy;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtIdTicket;
        private TextBox txtPrice;
        private TextBox txtIdTicket2;
        private TextBox txtPrice2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
    }
}