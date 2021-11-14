
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_auth = new System.Windows.Forms.Label();
            this.pnl_book_photo = new System.Windows.Forms.Panel();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_long_desc = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_lang = new System.Windows.Forms.Label();
            this.lbl_pd = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.pnl_book_item = new System.Windows.Forms.Panel();
            this.pnl_header.SuspendLayout();
            this.pnl_shop.SuspendLayout();
            this.pnl_book_item.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
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
            this.pnl_shop.Controls.Add(this.pnl_book_item);
            this.pnl_shop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_shop.Location = new System.Drawing.Point(0, 112);
            this.pnl_shop.Name = "pnl_shop";
            this.pnl_shop.Size = new System.Drawing.Size(1320, 633);
            this.pnl_shop.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(25, 19);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(108, 25);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title: Dune";
            // 
            // lbl_auth
            // 
            this.lbl_auth.AutoSize = true;
            this.lbl_auth.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auth.Location = new System.Drawing.Point(25, 57);
            this.lbl_auth.Name = "lbl_auth";
            this.lbl_auth.Size = new System.Drawing.Size(217, 25);
            this.lbl_auth.TabIndex = 1;
            this.lbl_auth.Text = "Author: Author Author";
            // 
            // pnl_book_photo
            // 
            this.pnl_book_photo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_book_photo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_book_photo.BackgroundImage")));
            this.pnl_book_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_book_photo.Location = new System.Drawing.Point(650, 0);
            this.pnl_book_photo.Name = "pnl_book_photo";
            this.pnl_book_photo.Size = new System.Drawing.Size(150, 150);
            this.pnl_book_photo.TabIndex = 2;
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_price.Location = new System.Drawing.Point(671, 153);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(115, 25);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.Text = "Price: 11.1$";
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.btn_buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buy.FlatAppearance.BorderSize = 0;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.ForeColor = System.Drawing.Color.White;
            this.btn_buy.Location = new System.Drawing.Point(650, 241);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(150, 39);
            this.btn_buy.TabIndex = 4;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(426, 19);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(28, 25);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.Location = new System.Drawing.Point(25, 96);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(112, 25);
            this.lbl_desc.TabIndex = 6;
            this.lbl_desc.Text = "Description:";
            // 
            // lbl_long_desc
            // 
            this.lbl_long_desc.AutoSize = true;
            this.lbl_long_desc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_long_desc.Location = new System.Drawing.Point(25, 136);
            this.lbl_long_desc.MaximumSize = new System.Drawing.Size(500, 100);
            this.lbl_long_desc.Name = "lbl_long_desc";
            this.lbl_long_desc.Size = new System.Drawing.Size(129, 25);
            this.lbl_long_desc.TabIndex = 7;
            this.lbl_long_desc.Text = "Description...";
            // 
            // lbl_stock
            // 
            this.lbl_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(553, 125);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(77, 25);
            this.lbl_stock.TabIndex = 8;
            this.lbl_stock.Text = "In Stock";
            // 
            // lbl_lang
            // 
            this.lbl_lang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lang.AutoSize = true;
            this.lbl_lang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lang.Location = new System.Drawing.Point(535, 61);
            this.lbl_lang.Name = "lbl_lang";
            this.lbl_lang.Size = new System.Drawing.Size(95, 25);
            this.lbl_lang.TabIndex = 9;
            this.lbl_lang.Text = "Language";
            // 
            // lbl_pd
            // 
            this.lbl_pd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pd.AutoSize = true;
            this.lbl_pd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pd.Location = new System.Drawing.Point(496, 95);
            this.lbl_pd.Name = "lbl_pd";
            this.lbl_pd.Size = new System.Drawing.Size(134, 25);
            this.lbl_pd.TabIndex = 10;
            this.lbl_pd.Text = "PublishedDate";
            // 
            // lbl_category
            // 
            this.lbl_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(542, 32);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(88, 25);
            this.lbl_category.TabIndex = 11;
            this.lbl_category.Text = "Category";
            // 
            // pnl_book_item
            // 
            this.pnl_book_item.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_book_item.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_book_item.Controls.Add(this.lbl_category);
            this.pnl_book_item.Controls.Add(this.lbl_pd);
            this.pnl_book_item.Controls.Add(this.lbl_lang);
            this.pnl_book_item.Controls.Add(this.lbl_stock);
            this.pnl_book_item.Controls.Add(this.lbl_long_desc);
            this.pnl_book_item.Controls.Add(this.lbl_desc);
            this.pnl_book_item.Controls.Add(this.lbl_id);
            this.pnl_book_item.Controls.Add(this.btn_buy);
            this.pnl_book_item.Controls.Add(this.lbl_price);
            this.pnl_book_item.Controls.Add(this.pnl_book_photo);
            this.pnl_book_item.Controls.Add(this.lbl_auth);
            this.pnl_book_item.Controls.Add(this.lbl_title);
            this.pnl_book_item.Location = new System.Drawing.Point(236, 52);
            this.pnl_book_item.Name = "pnl_book_item";
            this.pnl_book_item.Size = new System.Drawing.Size(800, 280);
            this.pnl_book_item.TabIndex = 0;
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
            this.Text = "ShopCenter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopCenter_FormClosing);
            this.Load += new System.EventHandler(this.ShopCenter_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_shop.ResumeLayout(false);
            this.pnl_book_item.ResumeLayout(false);
            this.pnl_book_item.PerformLayout();
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
        private System.Windows.Forms.Panel pnl_book_item;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_pd;
        private System.Windows.Forms.Label lbl_lang;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_long_desc;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Panel pnl_book_photo;
        private System.Windows.Forms.Label lbl_auth;
        private System.Windows.Forms.Label lbl_title;
    }
}