
namespace BookShopManagementSystem
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.lbl_status = new System.Windows.Forms.Label();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_auth = new System.Windows.Forms.Panel();
            this.tb_auth = new System.Windows.Forms.TextBox();
            this.lbl_auth = new System.Windows.Forms.Label();
            this.pnl_category = new System.Windows.Forms.Panel();
            this.tb_category = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.pnl_lang = new System.Windows.Forms.Panel();
            this.tb_lang = new System.Windows.Forms.TextBox();
            this.lbl_lang = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_add_image = new System.Windows.Forms.Button();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.pnl_stock = new System.Windows.Forms.Panel();
            this.pnl_price = new System.Windows.Forms.Panel();
            this.dtp_published_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_publish_date = new System.Windows.Forms.Label();
            this.pnl_name.SuspendLayout();
            this.pnl_auth.SuspendLayout();
            this.pnl_category.SuspendLayout();
            this.pnl_lang.SuspendLayout();
            this.pnl_stock.SuspendLayout();
            this.pnl_price.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(15, 562);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 28);
            this.lbl_status.TabIndex = 88;
            // 
            // pnl_name
            // 
            this.pnl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_name.Controls.Add(this.tb_name);
            this.pnl_name.Location = new System.Drawing.Point(15, 37);
            this.pnl_name.MaximumSize = new System.Drawing.Size(550, 45);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(550, 45);
            this.pnl_name.TabIndex = 0;
            // 
            // tb_name
            // 
            this.tb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_name.Location = new System.Drawing.Point(6, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(538, 27);
            this.tb_name.TabIndex = 43;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(385, 594);
            this.btn_add.MaximumSize = new System.Drawing.Size(180, 40);
            this.btn_add.MinimumSize = new System.Drawing.Size(180, 40);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(180, 40);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_name.Location = new System.Drawing.Point(15, 9);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(62, 25);
            this.lbl_name.TabIndex = 82;
            this.lbl_name.Text = "Name:";
            // 
            // pnl_auth
            // 
            this.pnl_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_auth.Controls.Add(this.tb_auth);
            this.pnl_auth.Location = new System.Drawing.Point(15, 127);
            this.pnl_auth.MaximumSize = new System.Drawing.Size(550, 45);
            this.pnl_auth.Name = "pnl_auth";
            this.pnl_auth.Size = new System.Drawing.Size(550, 45);
            this.pnl_auth.TabIndex = 1;
            // 
            // tb_auth
            // 
            this.tb_auth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_auth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_auth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_auth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_auth.Location = new System.Drawing.Point(6, 12);
            this.tb_auth.Name = "tb_auth";
            this.tb_auth.Size = new System.Drawing.Size(538, 27);
            this.tb_auth.TabIndex = 43;
            // 
            // lbl_auth
            // 
            this.lbl_auth.BackColor = System.Drawing.Color.Transparent;
            this.lbl_auth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_auth.Location = new System.Drawing.Point(15, 99);
            this.lbl_auth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_auth.Name = "lbl_auth";
            this.lbl_auth.Size = new System.Drawing.Size(95, 25);
            this.lbl_auth.TabIndex = 90;
            this.lbl_auth.Text = "Author:";
            // 
            // pnl_category
            // 
            this.pnl_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_category.Controls.Add(this.tb_category);
            this.pnl_category.Location = new System.Drawing.Point(15, 220);
            this.pnl_category.MaximumSize = new System.Drawing.Size(550, 45);
            this.pnl_category.Name = "pnl_category";
            this.pnl_category.Size = new System.Drawing.Size(550, 45);
            this.pnl_category.TabIndex = 2;
            // 
            // tb_category
            // 
            this.tb_category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_category.Location = new System.Drawing.Point(6, 12);
            this.tb_category.Name = "tb_category";
            this.tb_category.Size = new System.Drawing.Size(538, 27);
            this.tb_category.TabIndex = 43;
            // 
            // lbl_category
            // 
            this.lbl_category.BackColor = System.Drawing.Color.Transparent;
            this.lbl_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_category.Location = new System.Drawing.Point(15, 192);
            this.lbl_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(119, 25);
            this.lbl_category.TabIndex = 92;
            this.lbl_category.Text = "Category:";
            // 
            // tb_desc
            // 
            this.tb_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_desc.Location = new System.Drawing.Point(15, 306);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(552, 76);
            this.tb_desc.TabIndex = 3;
            // 
            // lbl_desc
            // 
            this.lbl_desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_desc.Location = new System.Drawing.Point(15, 278);
            this.lbl_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(119, 25);
            this.lbl_desc.TabIndex = 94;
            this.lbl_desc.Text = "Description:";
            // 
            // pnl_lang
            // 
            this.pnl_lang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_lang.Controls.Add(this.tb_lang);
            this.pnl_lang.Location = new System.Drawing.Point(15, 422);
            this.pnl_lang.MaximumSize = new System.Drawing.Size(550, 45);
            this.pnl_lang.Name = "pnl_lang";
            this.pnl_lang.Size = new System.Drawing.Size(550, 45);
            this.pnl_lang.TabIndex = 4;
            // 
            // tb_lang
            // 
            this.tb_lang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_lang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_lang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_lang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_lang.Location = new System.Drawing.Point(6, 12);
            this.tb_lang.Name = "tb_lang";
            this.tb_lang.Size = new System.Drawing.Size(538, 27);
            this.tb_lang.TabIndex = 43;
            // 
            // lbl_lang
            // 
            this.lbl_lang.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_lang.Location = new System.Drawing.Point(15, 394);
            this.lbl_lang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lang.Name = "lbl_lang";
            this.lbl_lang.Size = new System.Drawing.Size(119, 25);
            this.lbl_lang.TabIndex = 96;
            this.lbl_lang.Text = "Language:";
            // 
            // lbl_stock
            // 
            this.lbl_stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_stock.Location = new System.Drawing.Point(15, 484);
            this.lbl_stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(92, 25);
            this.lbl_stock.TabIndex = 98;
            this.lbl_stock.Text = "Stock:";
            // 
            // lbl_price
            // 
            this.lbl_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_price.Location = new System.Drawing.Point(143, 484);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(119, 25);
            this.lbl_price.TabIndex = 100;
            this.lbl_price.Text = "Price:";
            // 
            // btn_add_image
            // 
            this.btn_add_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_add_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_image.FlatAppearance.BorderSize = 0;
            this.btn_add_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_image.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.btn_add_image.Location = new System.Drawing.Point(15, 594);
            this.btn_add_image.MaximumSize = new System.Drawing.Size(180, 40);
            this.btn_add_image.MinimumSize = new System.Drawing.Size(180, 40);
            this.btn_add_image.Name = "btn_add_image";
            this.btn_add_image.Size = new System.Drawing.Size(180, 40);
            this.btn_add_image.TabIndex = 8;
            this.btn_add_image.Text = "Choose image";
            this.btn_add_image.UseVisualStyleBackColor = false;
            this.btn_add_image.Click += new System.EventHandler(this.btn_add_image_Click);
            // 
            // tb_stock
            // 
            this.tb_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_stock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_stock.Location = new System.Drawing.Point(6, 10);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(87, 27);
            this.tb_stock.TabIndex = 103;
            this.tb_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_stock_KeyPress);
            // 
            // tb_price
            // 
            this.tb_price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_price.Location = new System.Drawing.Point(14, 10);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(87, 27);
            this.tb_price.TabIndex = 104;
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // pnl_stock
            // 
            this.pnl_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_stock.Controls.Add(this.tb_stock);
            this.pnl_stock.Location = new System.Drawing.Point(15, 513);
            this.pnl_stock.MaximumSize = new System.Drawing.Size(550, 45);
            this.pnl_stock.Name = "pnl_stock";
            this.pnl_stock.Size = new System.Drawing.Size(104, 45);
            this.pnl_stock.TabIndex = 5;
            // 
            // pnl_price
            // 
            this.pnl_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_price.Controls.Add(this.tb_price);
            this.pnl_price.Location = new System.Drawing.Point(148, 513);
            this.pnl_price.MaximumSize = new System.Drawing.Size(550, 45);
            this.pnl_price.Name = "pnl_price";
            this.pnl_price.Size = new System.Drawing.Size(104, 45);
            this.pnl_price.TabIndex = 6;
            // 
            // dtp_published_date
            // 
            this.dtp_published_date.Location = new System.Drawing.Point(275, 520);
            this.dtp_published_date.Name = "dtp_published_date";
            this.dtp_published_date.Size = new System.Drawing.Size(290, 31);
            this.dtp_published_date.TabIndex = 7;
            // 
            // lbl_publish_date
            // 
            this.lbl_publish_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_publish_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_publish_date.Location = new System.Drawing.Point(270, 485);
            this.lbl_publish_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_publish_date.Name = "lbl_publish_date";
            this.lbl_publish_date.Size = new System.Drawing.Size(168, 25);
            this.lbl_publish_date.TabIndex = 108;
            this.lbl_publish_date.Text = "Published date:";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 656);
            this.Controls.Add(this.dtp_published_date);
            this.Controls.Add(this.lbl_publish_date);
            this.Controls.Add(this.pnl_price);
            this.Controls.Add(this.pnl_stock);
            this.Controls.Add(this.btn_add_image);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.pnl_lang);
            this.Controls.Add(this.lbl_lang);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.pnl_category);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.pnl_auth);
            this.Controls.Add(this.lbl_auth);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pnl_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_name);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookForm_FormClosing);
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.pnl_auth.ResumeLayout(false);
            this.pnl_auth.PerformLayout();
            this.pnl_category.ResumeLayout(false);
            this.pnl_category.PerformLayout();
            this.pnl_lang.ResumeLayout(false);
            this.pnl_lang.PerformLayout();
            this.pnl_stock.ResumeLayout(false);
            this.pnl_stock.PerformLayout();
            this.pnl_price.ResumeLayout(false);
            this.pnl_price.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel pnl_auth;
        private System.Windows.Forms.TextBox tb_auth;
        private System.Windows.Forms.Label lbl_auth;
        private System.Windows.Forms.Panel pnl_category;
        private System.Windows.Forms.TextBox tb_category;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Panel pnl_lang;
        private System.Windows.Forms.TextBox tb_lang;
        private System.Windows.Forms.Label lbl_lang;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_add_image;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Panel pnl_stock;
        private System.Windows.Forms.Panel pnl_price;
        private System.Windows.Forms.DateTimePicker dtp_published_date;
        private System.Windows.Forms.Label lbl_publish_date;
    }
}