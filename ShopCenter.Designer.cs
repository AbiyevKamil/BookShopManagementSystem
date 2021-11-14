
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
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_budget = new System.Windows.Forms.Label();
            this.lbl_bought_books = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.pnl_shop = new System.Windows.Forms.Panel();
            this.btn_sell_book = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.pnl_header.Controls.Add(this.btn_login);
            this.pnl_header.Controls.Add(this.btn_sell_book);
            this.pnl_header.Controls.Add(this.lbl_header);
            this.pnl_header.Controls.Add(this.lbl_bought_books);
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
            // lbl_bought_books
            // 
            this.lbl_bought_books.AutoSize = true;
            this.lbl_bought_books.ForeColor = System.Drawing.Color.White;
            this.lbl_bought_books.Location = new System.Drawing.Point(600, 75);
            this.lbl_bought_books.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bought_books.Name = "lbl_bought_books";
            this.lbl_bought_books.Size = new System.Drawing.Size(228, 25);
            this.lbl_bought_books.TabIndex = 2;
            this.lbl_bought_books.Text = "Number of bought books:";
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
            // pnl_shop
            // 
            this.pnl_shop.AutoScroll = true;
            this.pnl_shop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_shop.Location = new System.Drawing.Point(0, 112);
            this.pnl_shop.Name = "pnl_shop";
            this.pnl_shop.Size = new System.Drawing.Size(1320, 633);
            this.pnl_shop.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_bought_books;
        private System.Windows.Forms.Label lbl_budget;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Panel pnl_shop;
        private System.Windows.Forms.Button btn_sell_book;
        private System.Windows.Forms.Button btn_login;
    }
}