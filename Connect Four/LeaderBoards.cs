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
    public partial class LeaderBoards : Form
    {
        ProPlayer p1;
        ProPlayer p2;
        List<Player> pList;
        public LeaderBoards()
        {
            InitializeComponent();
        }
        public LeaderBoards(ProPlayer player1, ProPlayer player2, List<Player> players)
        {
            InitializeComponent();
            p1 = player1;
            p2 = player2;
            pList = players;
        }

        

        private void LeaderBoards_Load(object sender, EventArgs e)
        {
            bool player1saved = false;
            bool player2saved = false;
            foreach (Player p in pList)
            {
                if (p.Name == p1.Name)
                {
                    p.GamesWon = p1.GamesWon;
                    player1saved = true;
                }
                if (p.Name == p2.Name)
                {
                    p.GamesWon = p2.GamesWon;
                    player2saved = true;
                }

                
            }

            if (player1saved == false)
            {
                Player player1 = new Player();
                player1.Name = p1.Name;
                player1.Color = p1.Color;
                player1.GamesWon = p1.GamesWon;
                pList.Add(player1);
                player1saved = true;
            }
            if (player2saved == false)
            {
                Player player2 = new Player();
                player2.Name = p2.Name;
                player2.Color = p2.Color;
                player2.GamesWon = p2.GamesWon;
                pList.Add(player2);
                player2saved = true;
            }
            if (player1saved && player2saved)
            {
                try
                {
                    StreamWriter outfile;
                    outfile = File.CreateText("Leaderboards.txt");

                    foreach (Player p in pList)
                    {
                        outfile.WriteLine(p.Name + "," + p.Color + "," + p.GamesWon);

                    }
                    outfile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }

            }

            lstLeaderboards.Items.Add("      Player Name        |       Wins");
            lstLeaderboards.Items.Add("-------------------------------------------------");
            foreach (Player p in pList)
            {
                lstLeaderboards.Items.Add(p.Name +"\t \t|  " + p.GamesWon);
                

            }
        }
    



   
    }
}
