
namespace BookShopManagementSystem
{
    partial class BookDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetail));
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_pd = new System.Windows.Forms.Label();
            this.lbl_lang = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_long_desc = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.lbl_price = new System.Windows.Forms.Label();
            this.pnl_book_photo = new System.Windows.Forms.Panel();
            this.lbl_auth = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_category
            // 
            this.lbl_category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(12, 80);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(88, 25);
            this.lbl_category.TabIndex = 24;
            this.lbl_category.Text = "Category";
            // 
            // lbl_pd
            // 
            this.lbl_pd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pd.AutoSize = true;
            this.lbl_pd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pd.Location = new System.Drawing.Point(742, 152);
            this.lbl_pd.Name = "lbl_pd";
            this.lbl_pd.Size = new System.Drawing.Size(134, 25);
            this.lbl_pd.TabIndex = 23;
            this.lbl_pd.Text = "PublishedDate";
            // 
            // lbl_lang
            // 
            this.lbl_lang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lang.AutoSize = true;
            this.lbl_lang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lang.Location = new System.Drawing.Point(12, 110);
            this.lbl_lang.Name = "lbl_lang";
            this.lbl_lang.Size = new System.Drawing.Size(95, 25);
            this.lbl_lang.TabIndex = 22;
            this.lbl_lang.Text = "Language";
            // 
            // lbl_stock
            // 
            this.lbl_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(771, 181);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(77, 25);
            this.lbl_stock.TabIndex = 21;
            this.lbl_stock.Text = "In Stock";
            // 
            // lbl_long_desc
            // 
            this.lbl_long_desc.AutoSize = true;
            this.lbl_long_desc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_long_desc.Location = new System.Drawing.Point(12, 172);
            this.lbl_long_desc.MaximumSize = new System.Drawing.Size(600, 100);
            this.lbl_long_desc.Name = "lbl_long_desc";
            this.lbl_long_desc.Size = new System.Drawing.Size(129, 25);
            this.lbl_long_desc.TabIndex = 20;
            this.lbl_long_desc.Text = "Description...";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.Location = new System.Drawing.Point(12, 140);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(112, 25);
            this.lbl_desc.TabIndex = 19;
            this.lbl_desc.Text = "Description:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(413, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 23);
            this.lbl_id.TabIndex = 17;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
            // 
            // btn_buy
            // 
            this.btn_buy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.btn_buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buy.FlatAppearance.BorderSize = 0;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.ForeColor = System.Drawing.Color.White;
            this.btn_buy.Location = new System.Drawing.Point(729, 242);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(150, 39);
            this.btn_buy.TabIndex = 16;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = false;
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_price.Location = new System.Drawing.Point(752, 212);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(115, 25);
            this.lbl_price.TabIndex = 15;
            this.lbl_price.Text = "Price: 11.1$";
            // 
            // pnl_book_photo
            // 
            this.pnl_book_photo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_book_photo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_book_photo.BackgroundImage")));
            this.pnl_book_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_book_photo.Location = new System.Drawing.Point(729, -1);
            this.pnl_book_photo.Name = "pnl_book_photo";
            this.pnl_book_photo.Size = new System.Drawing.Size(150, 150);
            this.pnl_book_photo.TabIndex = 14;
            // 
            // lbl_auth
            // 
            this.lbl_auth.AutoSize = true;
            this.lbl_auth.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auth.Location = new System.Drawing.Point(12, 47);
            this.lbl_auth.Name = "lbl_auth";
            this.lbl_auth.Size = new System.Drawing.Size(217, 25);
            this.lbl_auth.TabIndex = 13;
            this.lbl_auth.Text = "Author: Author Author";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(108, 25);
            this.lbl_title.TabIndex = 12;
            this.lbl_title.Text = "Title: Dune";
            // 
            // BookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 465);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_pd);
            this.Controls.Add(this.lbl_lang);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_long_desc);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.pnl_book_photo);
            this.Controls.Add(this.lbl_auth);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Detail";
            this.Load += new System.EventHandler(this.BookDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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