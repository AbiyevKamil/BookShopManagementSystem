
namespace BookShopManagementSystem
{
    partial class ShopCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopCenter));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_admin_panel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_sell_book = new System.Windows.Forms.Button();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_budget = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pnl_shop = new System.Windows.Forms.Panel();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_filter = new System.Windows.Forms.Panel();
            this.pnl_stock_filter = new System.Windows.Forms.Panel();
            this.cmb_stock_filter = new System.Windows.Forms.ComboBox();
            this.pnl_cmb = new System.Windows.Forms.Panel();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.pnl_query = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_query = new System.Windows.Forms.TextBox();
            this.btn_delete_account = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            this.pnl_shop.SuspendLayout();
            this.pnl_filter.SuspendLayout();
            this.pnl_stock_filter.SuspendLayout();
            this.pnl_cmb.SuspendLayout();
            this.pnl_query.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.pnl_header.Controls.Add(this.btn_delete_account);
            this.pnl_header.Controls.Add(this.btn_admin_panel);
            this.pnl_header.Controls.Add(this.btn_login);
            this.pnl_header.Controls.Add(this.btn_sell_book);
            this.pnl_header.Controls.Add(this.lbl_header);
            this.pnl_header.Controls.Add(this.lbl_budget);
            this.pnl_header.Controls.Add(this.btn_logout);
            this.pnl_header.Controls.Add(this.lbl_user);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1320, 112);
            this.pnl_header.TabIndex = 0;
            // 
            // btn_admin_panel
            // 
            this.btn_admin_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_admin_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.btn_admin_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_panel.FlatAppearance.BorderSize = 0;
            this.btn_admin_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_panel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_panel.ForeColor = System.Drawing.Color.White;
            this.btn_admin_panel.Location = new System.Drawing.Point(1170, 0);
            this.btn_admin_panel.Name = "btn_admin_panel";
            this.btn_admin_panel.Size = new System.Drawing.Size(150, 40);
            this.btn_admin_panel.TabIndex = 4;
            this.btn_admin_panel.Text = "Admin Panel";
            this.btn_admin_panel.UseVisualStyleBackColor = false;
            this.btn_admin_panel.Click += new System.EventHandler(this.btn_admin_panel_Click);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(1170, 72);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(150, 40);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_sell_book
            // 
            this.btn_sell_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.btn_sell_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sell_book.FlatAppearance.BorderSize = 0;
            this.btn_sell_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sell_book.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sell_book.ForeColor = System.Drawing.Color.White;
            this.btn_sell_book.Location = new System.Drawing.Point(0, 0);
            this.btn_sell_book.Name = "btn_sell_book";
            this.btn_sell_book.Size = new System.Drawing.Size(128, 40);
            this.btn_sell_book.TabIndex = 2;
            this.btn_sell_book.Text = "Sell Book";
            this.btn_sell_book.UseVisualStyleBackColor = false;
            this.btn_sell_book.Click += new System.EventHandler(this.btn_sell_book_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(440, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(433, 32);
            this.lbl_header.TabIndex = 1;
            this.lbl_header.Text = "BOOK SHOP MANAGEMENT SYSTEM";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_budget
            // 
            this.lbl_budget.AutoSize = true;
            this.lbl_budget.ForeColor = System.Drawing.Color.White;
            this.lbl_budget.Location = new System.Drawing.Point(304, 75);
            this.lbl_budget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_budget.Name = "lbl_budget";
            this.lbl_budget.Size = new System.Drawing.Size(76, 25);
            this.lbl_budget.TabIndex = 1;
            this.lbl_budget.Text = "Budget:";
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.Maroon;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(1170, 72);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(150, 40);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Log out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(4, 75);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(124, 25);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "Signed in as ";
            // 
            // pnl_shop
            // 
            this.pnl_shop.AutoScroll = true;
            this.pnl_shop.Controls.Add(this.pnl_body);
            this.pnl_shop.Controls.Add(this.pnl_filter);
            this.pnl_shop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_shop.Location = new System.Drawing.Point(0, 112);
            this.pnl_shop.Name = "pnl_shop";
            this.pnl_shop.Size = new System.Drawing.Size(1320, 633);
            this.pnl_shop.TabIndex = 1;
            // 
            // pnl_body
            // 
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 63);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(1320, 570);
            this.pnl_body.TabIndex = 102;
            // 
            // pnl_filter
            // 
            this.pnl_filter.Controls.Add(this.btn_refresh);
            this.pnl_filter.Controls.Add(this.pnl_stock_filter);
            this.pnl_filter.Controls.Add(this.pnl_cmb);
            this.pnl_filter.Controls.Add(this.pnl_query);
            this.pnl_filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_filter.Location = new System.Drawing.Point(0, 0);
            this.pnl_filter.Name = "pnl_filter";
            this.pnl_filter.Size = new System.Drawing.Size(1320, 63);
            this.pnl_filter.TabIndex = 101;
            // 
            // pnl_stock_filter
            // 
            this.pnl_stock_filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_stock_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_stock_filter.Controls.Add(this.cmb_stock_filter);
            this.pnl_stock_filter.Location = new System.Drawing.Point(834, 7);
            this.pnl_stock_filter.MaximumSize = new System.Drawing.Size(560, 45);
            this.pnl_stock_filter.Name = "pnl_stock_filter";
            this.pnl_stock_filter.Size = new System.Drawing.Size(302, 45);
            this.pnl_stock_filter.TabIndex = 101;
            // 
            // cmb_stock_filter
            // 
            this.cmb_stock_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_stock_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cmb_stock_filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_stock_filter.FormattingEnabled = true;
            this.cmb_stock_filter.Items.AddRange(new object[] {
            "All",
            "In Stock",
            "Out of Stock"});
            this.cmb_stock_filter.Location = new System.Drawing.Point(3, 7);
            this.cmb_stock_filter.Name = "cmb_stock_filter";
            this.cmb_stock_filter.Size = new System.Drawing.Size(295, 33);
            this.cmb_stock_filter.TabIndex = 99;
            // 
            // pnl_cmb
            // 
            this.pnl_cmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_cmb.Controls.Add(this.cmb_type);
            this.pnl_cmb.Location = new System.Drawing.Point(578, 8);
            this.pnl_cmb.MaximumSize = new System.Drawing.Size(560, 45);
            this.pnl_cmb.Name = "pnl_cmb";
            this.pnl_cmb.Size = new System.Drawing.Size(250, 45);
            this.pnl_cmb.TabIndex = 100;
            // 
            // cmb_type
            // 
            this.cmb_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cmb_type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Name",
            "Author",
            "Category",
            "Language"});
            this.cmb_type.Location = new System.Drawing.Point(3, 7);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(244, 33);
            this.cmb_type.TabIndex = 99;
            // 
            // pnl_query
            // 
            this.pnl_query.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_query.Controls.Add(this.btn_search);
            this.pnl_query.Controls.Add(this.tb_query);
            this.pnl_query.Location = new System.Drawing.Point(11, 8);
            this.pnl_query.MaximumSize = new System.Drawing.Size(560, 45);
            this.pnl_query.Name = "pnl_query";
            this.pnl_query.Size = new System.Drawing.Size(560, 45);
            this.pnl_query.TabIndex = 98;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(465, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(95, 42);
            this.btn_search.TabIndex = 44;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_query
            // 
            this.tb_query.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_query.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_query.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_query.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_query.Location = new System.Drawing.Point(8, 10);
            this.tb_query.Name = "tb_query";
            this.tb_query.Size = new System.Drawing.Size(453, 27);
            this.tb_query.TabIndex = 43;
            // 
            // btn_delete_account
            // 
            this.btn_delete_account.BackColor = System.Drawing.Color.Maroon;
            this.btn_delete_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_account.FlatAppearance.BorderSize = 0;
            this.btn_delete_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_account.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_account.ForeColor = System.Drawing.Color.White;
            this.btn_delete_account.Location = new System.Drawing.Point(1133, -1);
            this.btn_delete_account.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete_account.Name = "btn_delete_account";
            this.btn_delete_account.Size = new System.Drawing.Size(187, 45);
            this.btn_delete_account.TabIndex = 5;
            this.btn_delete_account.Text = "Delete my account";
            this.btn_delete_account.UseVisualStyleBackColor = false;
            this.btn_delete_account.Click += new System.EventHandler(this.btn_delete_account_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.BackgroundImage")));
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(1142, 9);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(46, 42);
            this.btn_refresh.TabIndex = 102;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // ShopCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 745);
            this.Controls.Add(this.pnl_shop);
            this.Controls.Add(this.pnl_header);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShopCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopCenter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopCenter_FormClosing);
            this.Load += new System.EventHandler(this.ShopCenter_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_shop.ResumeLayout(false);
            this.pnl_filter.ResumeLayout(false);
            this.pnl_stock_filter.ResumeLayout(false);
            this.pnl_cmb.ResumeLayout(false);
            this.pnl_query.ResumeLayout(false);
            this.pnl_query.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_budget;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Panel pnl_shop;
        private System.Windows.Forms.Button btn_sell_book;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel pnl_query;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_query;
        private System.Windows.Forms.Panel pnl_cmb;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.Panel pnl_filter;
        private System.Windows.Forms.Panel pnl_stock_filter;
        private System.Windows.Forms.ComboBox cmb_stock_filter;
        private System.Windows.Forms.Button btn_admin_panel;
        private System.Windows.Forms.Button btn_delete_account;
        private System.Windows.Forms.Button btn_refresh;
    }
}