
namespace BookShopManagementSystem
{
    partial class Login
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
            this.pnl_form = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cb_show_pass = new System.Windows.Forms.CheckBox();
            this.pnl_password = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.pnl_email = new System.Windows.Forms.Panel();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.cb_save_log = new System.Windows.Forms.CheckBox();
            this.pnl_form.SuspendLayout();
            this.pnl_password.SuspendLayout();
            this.pnl_email.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_form
            // 
            this.pnl_form.Controls.Add(this.cb_save_log);
            this.pnl_form.Controls.Add(this.lbl_status);
            this.pnl_form.Controls.Add(this.cb_show_pass);
            this.pnl_form.Controls.Add(this.pnl_password);
            this.pnl_form.Controls.Add(this.pnl_email);
            this.pnl_form.Controls.Add(this.btn_login);
            this.pnl_form.Controls.Add(this.lbl_email);
            this.pnl_form.Controls.Add(this.lbl_pass);
            this.pnl_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_form.Location = new System.Drawing.Point(0, 0);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(1163, 405);
            this.pnl_form.TabIndex = 0;
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(306, 252);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 28);
            this.lbl_status.TabIndex = 80;
            // 
            // cb_show_pass
            // 
            this.cb_show_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_show_pass.AutoSize = true;
            this.cb_show_pass.Location = new System.Drawing.Point(306, 216);
            this.cb_show_pass.Name = "cb_show_pass";
            this.cb_show_pass.Size = new System.Drawing.Size(128, 21);
            this.cb_show_pass.TabIndex = 79;
            this.cb_show_pass.Text = "Show password";
            this.cb_show_pass.UseVisualStyleBackColor = true;
            this.cb_show_pass.CheckedChanged += new System.EventHandler(this.cb_show_pass_CheckedChanged);
            // 
            // pnl_password
            // 
            this.pnl_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_password.Controls.Add(this.tb_password);
            this.pnl_password.Location = new System.Drawing.Point(304, 150);
            this.pnl_password.MaximumSize = new System.Drawing.Size(550, 45);
            this.pnl_password.Name = "pnl_password";
            this.pnl_password.Size = new System.Drawing.Size(550, 45);
            this.pnl_password.TabIndex = 78;
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_password.Location = new System.Drawing.Point(6, 11);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(538, 27);
            this.tb_password.TabIndex = 55;
            // 
            // pnl_email
            // 
            this.pnl_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_email.Controls.Add(this.tb_email);
            this.pnl_email.Location = new System.Drawing.Point(304, 63);
            this.pnl_email.MaximumSize = new System.Drawing.Size(550, 45);
            this.pnl_email.Name = "pnl_email";
            this.pnl_email.Size = new System.Drawing.Size(550, 45);
            this.pnl_email.TabIndex = 77;
            // 
            // tb_email
            // 
            this.tb_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_email.Location = new System.Drawing.Point(6, 12);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(538, 27);
            this.tb_email.TabIndex = 43;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(471, 293);
            this.btn_login.MaximumSize = new System.Drawing.Size(180, 40);
            this.btn_login.MinimumSize = new System.Drawing.Size(180, 40);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(180, 40);
            this.btn_login.TabIndex = 76;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_email.Location = new System.Drawing.Point(304, 35);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(62, 25);
            this.lbl_email.TabIndex = 74;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_pass.Location = new System.Drawing.Point(304, 120);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(95, 25);
            this.lbl_pass.TabIndex = 75;
            this.lbl_pass.Text = "Password:";
            // 
            // cb_save_log
            // 
            this.cb_save_log.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_save_log.AutoSize = true;
            this.cb_save_log.Location = new System.Drawing.Point(508, 216);
            this.cb_save_log.Name = "cb_save_log";
            this.cb_save_log.Size = new System.Drawing.Size(148, 21);
            this.cb_save_log.TabIndex = 81;
            this.cb_save_log.Text = "Keep me logged in";
            this.cb_save_log.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 405);
            this.Controls.Add(this.pnl_form);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnl_form.ResumeLayout(false);
            this.pnl_form.PerformLayout();
            this.pnl_password.ResumeLayout(false);
            this.pnl_password.PerformLayout();
            this.pnl_email.ResumeLayout(false);
            this.pnl_email.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.CheckBox cb_show_pass;
        private System.Windows.Forms.Panel pnl_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Panel pnl_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.CheckBox cb_save_log;
    }
}