namespace POS_Inventory
{
    partial class ManageOrders
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
            this.CustomersGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderIdTb = new System.Windows.Forms.TextBox();
            this.CustId = new System.Windows.Forms.TextBox();
            this.orderdate = new System.Windows.Forms.DateTimePicker();
            this.ProductGV = new System.Windows.Forms.DataGridView();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderGv = new System.Windows.Forms.DataGridView();
            this.CustName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TotAmount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGV
            // 
            this.CustomersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGV.Location = new System.Drawing.Point(12, 167);
            this.CustomersGV.Name = "CustomersGV";
            this.CustomersGV.RowHeadersWidth = 51;
            this.CustomersGV.RowTemplate.Height = 24;
            this.CustomersGV.Size = new System.Drawing.Size(494, 158);
            this.CustomersGV.TabIndex = 25;
            this.CustomersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 100);
            this.panel1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1106, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(386, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Orders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(166, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 47);
            this.label4.TabIndex = 27;
            this.label4.Text = "Products List";
            // 
            // OrderIdTb
            // 
            this.OrderIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdTb.Location = new System.Drawing.Point(770, 378);
            this.OrderIdTb.Name = "OrderIdTb";
            this.OrderIdTb.Size = new System.Drawing.Size(207, 32);
            this.OrderIdTb.TabIndex = 28;
            this.OrderIdTb.TextChanged += new System.EventHandler(this.OrderIdTb_TextChanged);
            // 
            // CustId
            // 
            this.CustId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustId.Location = new System.Drawing.Point(770, 434);
            this.CustId.Name = "CustId";
            this.CustId.Size = new System.Drawing.Size(207, 32);
            this.CustId.TabIndex = 29;
            this.CustId.TextChanged += new System.EventHandler(this.CustId_TextChanged);
            // 
            // orderdate
            // 
            this.orderdate.Location = new System.Drawing.Point(718, 542);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(245, 22);
            this.orderdate.TabIndex = 30;
            // 
            // ProductGV
            // 
            this.ProductGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGV.Location = new System.Drawing.Point(529, 167);
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.RowHeadersWidth = 51;
            this.ProductGV.RowTemplate.Height = 24;
            this.ProductGV.Size = new System.Drawing.Size(578, 158);
            this.ProductGV.TabIndex = 31;
            this.ProductGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGV_CellContentClick);
            // 
            // QtyTb
            // 
            this.QtyTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTb.Location = new System.Drawing.Point(818, 133);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(207, 32);
            this.QtyTb.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(814, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Quantity";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1030, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 33);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderGv
            // 
            this.OrderGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGv.Location = new System.Drawing.Point(12, 350);
            this.OrderGv.Name = "OrderGv";
            this.OrderGv.RowHeadersWidth = 51;
            this.OrderGv.RowTemplate.Height = 24;
            this.OrderGv.Size = new System.Drawing.Size(634, 219);
            this.OrderGv.TabIndex = 35;
            this.OrderGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CustName
            // 
            this.CustName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.Location = new System.Drawing.Point(770, 490);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(207, 32);
            this.CustName.TabIndex = 36;
            this.CustName.TextChanged += new System.EventHandler(this.CustName_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(12, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 50);
            this.button4.TabIndex = 38;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(983, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 33);
            this.button2.TabIndex = 39;
            this.button2.Text = "Insert Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(983, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 33);
            this.button3.TabIndex = 40;
            this.button3.Text = "View Order";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(983, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 27);
            this.label6.TabIndex = 41;
            this.label6.Text = "Total Amount";
            // 
            // TotAmount
            // 
            this.TotAmount.AutoSize = true;
            this.TotAmount.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotAmount.ForeColor = System.Drawing.Color.Red;
            this.TotAmount.Location = new System.Drawing.Point(1022, 417);
            this.TotAmount.Name = "TotAmount";
            this.TotAmount.Size = new System.Drawing.Size(42, 47);
            this.TotAmount.TabIndex = 42;
            this.TotAmount.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 599);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 10);
            this.panel2.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(652, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 44;
            this.label7.Text = "Cust Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(666, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 22);
            this.label8.TabIndex = 45;
            this.label8.Text = "Cust Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(664, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 46;
            this.label9.Text = "Prod Id";
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 609);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TotAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.OrderGv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.ProductGV);
            this.Controls.Add(this.orderdate);
            this.Controls.Add(this.CustId);
            this.Controls.Add(this.OrderIdTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomersGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView CustomersGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrderIdTb;
        private System.Windows.Forms.TextBox CustId;
        private System.Windows.Forms.DateTimePicker orderdate;
        private System.Windows.Forms.DataGridView ProductGV;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView OrderGv;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}