namespace Connect_Four
{
    partial class Instructions
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
            this.lblHowTo = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblRules1 = new System.Windows.Forms.Label();
            this.lblRules2 = new System.Windows.Forms.Label();
            this.lblRules3 = new System.Windows.Forms.Label();
            this.lblRules4 = new System.Windows.Forms.Label();
            this.lblRules5 = new System.Windows.Forms.Label();
            this.btnPlayNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHowTo
            // 
            this.lblHowTo.AutoSize = true;
            this.lblHowTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowTo.Location = new System.Drawing.Point(21, 67);
            this.lblHowTo.Name = "lblHowTo";
            this.lblHowTo.Size = new System.Drawing.Size(751, 37);
            this.lblHowTo.TabIndex = 0;
            this.lblHowTo.Text = "Do you need to learn how to play Connect Four?";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.White;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(242, 269);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(107, 60);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.White;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(456, 269);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(103, 60);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblRules1
            // 
            this.lblRules1.AutoSize = true;
            this.lblRules1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules1.Location = new System.Drawing.Point(24, 127);
            this.lblRules1.Name = "lblRules1";
            this.lblRules1.Size = new System.Drawing.Size(544, 24);
            this.lblRules1.TabIndex = 3;
            this.lblRules1.Text = "Players will select their color, and enter a name into the text box.";
            // 
            // lblRules2
            // 
            this.lblRules2.AutoSize = true;
            this.lblRules2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules2.Location = new System.Drawing.Point(24, 151);
            this.lblRules2.Name = "lblRules2";
            this.lblRules2.Size = new System.Drawing.Size(587, 24);
            this.lblRules2.TabIndex = 4;
            this.lblRules2.Text = "Players will then take turns choosing a columb to drop their color into.";
            // 
            // lblRules3
            // 
            this.lblRules3.AutoSize = true;
            this.lblRules3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules3.Location = new System.Drawing.Point(24, 176);
            this.lblRules3.Name = "lblRules3";
            this.lblRules3.Size = new System.Drawing.Size(738, 24);
            this.lblRules3.TabIndex = 5;
            this.lblRules3.Text = "To win, a player must connect 4 of their color either horizontally, diagonally, o" +
    "r vertically.";
            // 
            // lblRules4
            // 
            this.lblRules4.AutoSize = true;
            this.lblRules4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules4.Location = new System.Drawing.Point(24, 198);
            this.lblRules4.Name = "lblRules4";
            this.lblRules4.Size = new System.Drawing.Size(590, 24);
            this.lblRules4.TabIndex = 6;
            this.lblRules4.Text = "If neither player connects 4 of their pieces, the game will result in a tie.";
            // 
            // lblRules5
            // 
            this.lblRules5.AutoSize = true;
            this.lblRules5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules5.Location = new System.Drawing.Point(24, 224);
            this.lblRules5.Name = "lblRules5";
            this.lblRules5.Size = new System.Drawing.Size(718, 24);
            this.lblRules5.TabIndex = 7;
            this.lblRules5.Text = "if a player decides to surrender, they can hit the \"Surrender\" button, and admit " +
    "defeat.";
            // 
            // btnPlayNow
            // 
            this.btnPlayNow.BackColor = System.Drawing.Color.White;
            this.btnPlayNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayNow.Location = new System.Drawing.Point(332, 382);
            this.btnPlayNow.Name = "btnPlayNow";
            this.btnPlayNow.Size = new System.Drawing.Size(126, 60);
            this.btnPlayNow.TabIndex = 8;
            this.btnPlayNow.Text = "Play now";
            this.btnPlayNow.UseVisualStyleBackColor = false;
            this.btnPlayNow.Click += new System.EventHandler(this.btnPlayNow_Click);
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(817, 524);
            this.Controls.Add(this.btnPlayNow);
            this.Controls.Add(this.lblRules5);
            this.Controls.Add(this.lblRules4);
            this.Controls.Add(this.lblRules3);
            this.Controls.Add(this.lblRules2);
            this.Controls.Add(this.lblRules1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblHowTo);
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.Load += new System.EventHandler(this.Instructions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHowTo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblRules1;
        private System.Windows.Forms.Label lblRules2;
        private System.Windows.Forms.Label lblRules3;
        private System.Windows.Forms.Label lblRules4;
        private System.Windows.Forms.Label lblRules5;
        private System.Windows.Forms.Button btnPlayNow;
    }
}