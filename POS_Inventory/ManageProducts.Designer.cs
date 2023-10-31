namespace POS_Inventory
{
    partial class ManageProducts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.ProdNameTb = new System.Windows.Forms.TextBox();
            this.ProdIdTb = new System.Windows.Forms.TextBox();
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductGV = new System.Windows.Forms.DataGridView();
            this.DescriptionTb = new System.Windows.Forms.TextBox();
            this.Searchcombo = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(371, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 580);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 29);
            this.panel2.TabIndex = 17;
            // 
            // PriceTb
            // 
            this.PriceTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTb.Location = new System.Drawing.Point(203, 305);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(207, 32);
            this.PriceTb.TabIndex = 8;
            // 
            // QtyTb
            // 
            this.QtyTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTb.Location = new System.Drawing.Point(203, 236);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(207, 32);
            this.QtyTb.TabIndex = 7;
            // 
            // ProdNameTb
            // 
            this.ProdNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameTb.Location = new System.Drawing.Point(203, 182);
            this.ProdNameTb.Name = "ProdNameTb";
            this.ProdNameTb.Size = new System.Drawing.Size(207, 32);
            this.ProdNameTb.TabIndex = 6;
            // 
            // ProdIdTb
            // 
            this.ProdIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdIdTb.Location = new System.Drawing.Point(203, 123);
            this.ProdIdTb.Name = "ProdIdTb";
            this.ProdIdTb.Size = new System.Drawing.Size(207, 32);
            this.ProdIdTb.TabIndex = 5;
            // 
            // CatCombo
            // 
            this.CatCombo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(203, 419);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(207, 31);
            this.CatCombo.TabIndex = 18;
            this.CatCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(164, 524);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 50);
            this.button4.TabIndex = 22;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(298, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 50);
            this.button3.TabIndex = 21;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(164, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(39, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(447, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 47);
            this.label4.TabIndex = 23;
            this.label4.Text = "Products List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ProductGV
            // 
            this.ProductGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGV.Location = new System.Drawing.Point(455, 151);
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.RowHeadersWidth = 51;
            this.ProductGV.RowTemplate.Height = 24;
            this.ProductGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGV.Size = new System.Drawing.Size(667, 407);
            this.ProductGV.TabIndex = 24;
            this.ProductGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGV_CellContentClick);
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTb.Location = new System.Drawing.Point(203, 355);
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(207, 32);
            this.DescriptionTb.TabIndex = 25;
            // 
            // Searchcombo
            // 
            this.Searchcombo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Searchcombo.FormattingEnabled = true;
            this.Searchcombo.Location = new System.Drawing.Point(728, 113);
            this.Searchcombo.Name = "Searchcombo";
            this.Searchcombo.Size = new System.Drawing.Size(207, 31);
            this.Searchcombo.TabIndex = 26;
            this.Searchcombo.SelectedIndexChanged += new System.EventHandler(this.Searchcombo_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(941, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 31);
            this.button5.TabIndex = 27;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(1048, 113);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 31);
            this.button6.TabIndex = 28;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(43, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 27);
            this.label5.TabIndex = 29;
            this.label5.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(43, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 27);
            this.label6.TabIndex = 30;
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(43, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 27);
            this.label7.TabIndex = 32;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(43, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 27);
            this.label8.TabIndex = 31;
            this.label8.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(43, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 27);
            this.label9.TabIndex = 34;
            this.label9.Text = "Categories";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(43, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 27);
            this.label10.TabIndex = 33;
            this.label10.Text = "Description";
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 609);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Searchcombo);
            this.Controls.Add(this.DescriptionTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProdNameTb);
            this.Controls.Add(this.ProdIdTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.TextBox ProdNameTb;
        private System.Windows.Forms.TextBox ProdIdTb;
        private System.Windows.Forms.ComboBox CatCombo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ProductGV;
        private System.Windows.Forms.TextBox DescriptionTb;
        private System.Windows.Forms.ComboBox Searchcombo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}