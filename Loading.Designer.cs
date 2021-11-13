
namespace BookShopManagementSystem
{
    partial class Loading
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
            this.components = new System.ComponentModel.Container();
            this.tmr_loading = new System.Windows.Forms.Timer(this.components);
            this.bw_load_db = new System.ComponentModel.BackgroundWorker();
            this.pb_loading = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tmr_loading
            // 
            this.tmr_loading.Interval = 25;
            this.tmr_loading.Tick += new System.EventHandler(this.tmr_loading_Tick);
            // 
            // bw_load_db
            // 
            this.bw_load_db.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_load_db_DoWork);
            // 
            // pb_loading
            // 
            this.pb_loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_loading.ForeColor = System.Drawing.Color.Maroon;
            this.pb_loading.Location = new System.Drawing.Point(0, 0);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(398, 40);
            this.pb_loading.TabIndex = 0;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 40);
            this.ControlBox = false;
            this.Controls.Add(this.pb_loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmr_loading;
        private System.ComponentModel.BackgroundWorker bw_load_db;
        private System.Windows.Forms.ProgressBar pb_loading;
    }
}