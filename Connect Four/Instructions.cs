using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Four
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void Instructions_Load(object sender, EventArgs e)
        {
            lblHowTo.Text = "Do you need to learn how to play Connect Four?";
            btnNo.Visible = true;
            btnYes.Visible = true;
            lblRules1.Visible = false;
            lblRules2.Visible = false;
            lblRules3.Visible = false;
            lblRules4.Visible = false;
            lblRules5.Visible = false;
            btnPlayNow.Visible = false;

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            lblHowTo.Text = "How to play";
            btnYes.Visible = false;
            btnNo.Visible = false;
            lblRules1.Visible = true;
            lblRules2.Visible = true;
            lblRules3.Visible = true;
            lblRules4.Visible = true;
            lblRules5.Visible = true;
            btnPlayNow.Visible = true;

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Players game = new Players();
            this.Visible = false;
            game.ShowDialog();
            this.Close();
            
        }

        private void btnPlayNow_Click(object sender, EventArgs e)
        {
            Players game = new Players();
            this.Visible = false;
            game.ShowDialog();
            this.Close();
        }
    }
}
