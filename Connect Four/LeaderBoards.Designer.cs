namespace Connect_Four
{
    partial class LeaderBoards
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
            this.lstLeaderboards = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstLeaderboards
            // 
            this.lstLeaderboards.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLeaderboards.FormattingEnabled = true;
            this.lstLeaderboards.ItemHeight = 29;
            this.lstLeaderboards.Location = new System.Drawing.Point(191, 12);
            this.lstLeaderboards.Name = "lstLeaderboards";
            this.lstLeaderboards.Size = new System.Drawing.Size(416, 497);
            this.lstLeaderboards.TabIndex = 0;
            // 
            // LeaderBoards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(817, 524);
            this.Controls.Add(this.lstLeaderboards);
            this.Name = "LeaderBoards";
            this.Text = "LeaderBoards";
            this.Load += new System.EventHandler(this.LeaderBoards_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLeaderboards;
    }
}