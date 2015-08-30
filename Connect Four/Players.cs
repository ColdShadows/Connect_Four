using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Connect_Four
{
    public partial class Players : Form
    {
        Player p1 = new Player();
        Player p2 = new Player();
        List<Player> pList = new List<Player>();
        public Players()
        {
            InitializeComponent();
        }

        private void Players_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
           
            bool ready = false;
            do
            {
                if (txtPlayer1.Text == "")
                {
                    MessageBox.Show("Player 1 must enter a name!");
                    txtPlayer1.Focus();
                }
                else
                    p1.Name = txtPlayer1.Text;
                if (txtPlayer2.Text == "")
                {
                    MessageBox.Show("Player 2 must enter a name!");
                    txtPlayer2.Focus();
                }
                p2.Name = txtPlayer2.Text;

                if (radAqua1.Checked)
                    p1.Color = radAqua1.BackColor;
                else if (radBlack1.Checked)
                    p1.Color = radBlack1.BackColor;
                else if (radBlue1.Checked)
                    p1.Color = radBlue1.BackColor;
                else if (radGray1.Checked)
                    p1.Color = radGray1.BackColor;
                else if (radGreen1.Checked)
                    p1.Color = radGreen1.BackColor;
                else if (radOrange1.Checked)
                    p1.Color = radOrange1.BackColor;
                else if (radPink1.Checked)
                    p1.Color = radPink1.BackColor;
                else if (radPurple1.Checked)
                    p1.Color = radPurple1.BackColor;
                else if (radRed1.Checked)
                    p1.Color = radRed1.BackColor;
                else if (radYellow1.Checked)
                    p1.Color = radYellow1.BackColor;
                
                if (radAqua2.Checked)
                    p2.Color = radAqua2.BackColor;
                else if (radBlack2.Checked)
                    p2.Color = radBlack2.BackColor;
                else if (radBlue2.Checked)
                    p2.Color = radBlue2.BackColor;
                else if (radGray2.Checked)
                    p2.Color = radGray2.BackColor;
                else if (radGreen2.Checked)
                    p2.Color = radGreen2.BackColor;
                else if (radOrange2.Checked)
                    p2.Color = radOrange2.BackColor;
                else if (radPink2.Checked)
                    p2.Color = radPink2.BackColor;
                else if (radPurple2.Checked)
                    p2.Color = radPurple2.BackColor;
                else if (radRed2.Checked)
                    p2.Color = radRed2.BackColor;
                else if (radYellow2.Checked)
                    p2.Color = radYellow2.BackColor;
                

                if (p2.Color == p1.Color)
                {
                    MessageBox.Show("Players must choose a different color than eachother, sorry.");
                    break;
                }
                else if (p1.Name == p2.Name)
                {
                    MessageBox.Show("Players must each enter a different name");
                    break;
                }
                else
                    ready = true;

                p1.GamesWon = Convert.ToInt32(lblWins1.Text);

                p2.GamesWon = Convert.ToInt32(lblWins2.Text);

            } while (ready == false);

            if (ready)
            {
                ConnectFour game = new ConnectFour(p1, p2, pList);
                this.Visible = false;
                game.ShowDialog();
                this.Close();

            }
        }

        private void btnLoad1_Click(object sender, EventArgs e)
        {
            try
            {

                lstPlayer1.Items.Clear();
                pList.Clear();
                string fulltext;
                string[] split;
                StreamReader infile;


                infile = File.OpenText("Leaderboards.txt");

                while (!infile.EndOfStream)
                {
                    fulltext = infile.ReadLine();
                    split = fulltext.Split(',');

                    Player player = new Player();
                    player.Name = split[0];
                    player.Color = System.Drawing.Color.FromName(split[1]);
                    player.GamesWon = Convert.ToInt16(split[2]);
                    pList.Add(player);
                }
                infile.Close();
                foreach (Player p in pList)
                {

                    lstPlayer1.Items.Add(p.Name + " " + p.Color + " " + p.GamesWon);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            
        }

        private void lstPlayer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstPlayer1.SelectedIndex;
            txtPlayer1.Text = pList[index].Name;
            lblWins1.Text = pList[index].GamesWon.ToString();

            if (pList[index].Color.ToString() == "Color [Green]")
                radGreen1.Checked = true;
            if (pList[index].Color.ToString() == "Color [Yellow]")
                radYellow1.Checked = true;
            if (pList[index].Color.ToString() == "Color [Red]")
                radRed1.Checked = true;
            if (pList[index].Color.ToString() == "Color [Gray]")
                radGray1.Checked = true;
            if (pList[index].Color.ToString() == "Color [Purple]")
                radPurple1.Checked = true;
            if (pList[index].Color.ToString() == "Color [Pink]")
                radPink1.Checked = true;
            if (pList[index].Color.ToString() == "Color [Aqua]")
                radAqua1.Checked = true;
            if (pList[index].Color.ToString() == "Color [Blue]")
                radBlue1.Checked = true;
            if (pList[index].Color.ToString() == "Color [Black]")
                radBlack1.Checked = true;
            if (pList[index].Color.ToString() == "Color [Orange]")
                radOrange1.Checked = true;

        }

        private void btnLoad2_Click(object sender, EventArgs e)
        {
            try
            {

                lstPlayer2.Items.Clear();
                pList.Clear();
                string fulltext;
                string[] split;
                StreamReader infile;


                infile = File.OpenText("Leaderboards.txt");

                while (!infile.EndOfStream)
                {
                    fulltext = infile.ReadLine();
                    split = fulltext.Split(',');

                    Player player = new Player();
                    player.Name = split[0];
                    player.Color = System.Drawing.Color.FromName(split[1]);
                    player.GamesWon = Convert.ToInt16(split[2]);
                    pList.Add(player);
                }
                infile.Close();
                foreach (Player p in pList)
                {

                    lstPlayer2.Items.Add(p.Name + " " + p.Color + " " + p.GamesWon);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstPlayer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstPlayer2.SelectedIndex;
            txtPlayer2.Text = pList[index].Name;
            lblWins2.Text = pList[index].GamesWon.ToString();

            if (pList[index].Color.ToString() == "Color [Green]")
                radGreen2.Checked = true;
            if (pList[index].Color.ToString() == "Color [Yellow]")
                radYellow2.Checked = true;
            if (pList[index].Color.ToString() == "Color [Red]")
                radRed2.Checked = true;
            if (pList[index].Color.ToString() == "Color [Gray]")
                radGray2.Checked = true;
            if (pList[index].Color.ToString() == "Color [Purple]")
                radPurple2.Checked = true;
            if (pList[index].Color.ToString() == "Color [Pink]")
                radPink2.Checked = true;
            if (pList[index].Color.ToString() == "Color [Aqua]")
                radAqua2.Checked = true;
            if (pList[index].Color.ToString() == "Color [Blue]")
                radBlue2.Checked = true;
            if (pList[index].Color.ToString() == "Color [Black]")
                radBlack2.Checked = true;
            if (pList[index].Color.ToString() == "Color [Orange]")
                radOrange2.Checked = true;
        }
    }
}
