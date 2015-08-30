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
    
    public partial class ConnectFour : Form
    {
        int Turn = 1;
        Player p1;
        Player p2;
        ProPlayer p1p = new ProPlayer();
        ProPlayer p2p = new ProPlayer();
        List<Player> pList;
        List<System.Windows.Forms.Label> Col1 = new List<Label>();
        List<System.Windows.Forms.Label> Col2 = new List<Label>();
        List<System.Windows.Forms.Label> Col3 = new List<Label>();
        List<System.Windows.Forms.Label> Col4 = new List<Label>();
        List<System.Windows.Forms.Label> Col5 = new List<Label>();
        List<System.Windows.Forms.Label> Col6 = new List<Label>();
        List<System.Windows.Forms.Label> Col7 = new List<Label>();

        List<List<Label>> Board = new List<List<Label>>();

        public ConnectFour()
        {
            InitializeComponent();
        }
        public ConnectFour(Player player1, Player player2, List<Player> players)
        {
            InitializeComponent();
            p1 = player1;
            p2 = player2;
            pList = players;

            
        }
        private void ConnectFour_Load(object sender, EventArgs e)
        {
             
            //ProPlayer p1p = new ProPlayer();
            //ProPlayer p2p = new ProPlayer();
            p1p.Name = p1.Name;
            p1p.Color = p1.Color;
            p1p.GamesWon = p1.GamesWon;
            p2p.Name = p2.Name;
            p2p.Color = p2.Color;
            p2p.GamesWon = p2.GamesWon;

            if (p1p.GamesWon < 25)
                p1p.Border = System.Drawing.Color.White;
            else if (p1p.GamesWon < 50)
                p1p.Border = System.Drawing.Color.Gainsboro;
            else
                p1p.Border = System.Drawing.Color.Gold;

            if (p2p.GamesWon < 25)
                p2p.Border = System.Drawing.Color.White;
            else if (p2p.GamesWon < 50)
                p2p.Border = System.Drawing.Color.Gainsboro;
            else
                p2p.Border = System.Drawing.Color.Gold;

            int nameLength = p1p.Name.Length;
            if(p1p.Name[nameLength-1].ToString().ToLower() == "s")
                lblTurn.Text = "It's " + p1p.Name + "' Turn!";
            else
            lblTurn.Text ="It's " + p1p.Name + "'s Turn!";
                       
            lblTurn.ForeColor = p1p.Color;
            
            lblWins1.Text = p1p.Name + " won " + p1p.GamesWon + " times total.";
            lblWins1.ForeColor = p1p.Color;
            lblWins1.BackColor = p1p.Border;

            lblWins2.Text = p2p.Name + " won " + p2p.GamesWon + " times total.";
            lblWins2.ForeColor = p2p.Color;
            lblWins2.BackColor = p2p.Border;

            Col1.Add(lbl1_1);
            Col1.Add(lbl1_2);
            Col1.Add(lbl1_3);
            Col1.Add(lbl1_4);
            Col1.Add(lbl1_5);
            Col1.Add(lbl1_6);

            Col2.Add(lbl2_1);
            Col2.Add(lbl2_2);
            Col2.Add(lbl2_3);
            Col2.Add(lbl2_4);
            Col2.Add(lbl2_5);
            Col2.Add(lbl2_6);

            Col3.Add(lbl3_1);
            Col3.Add(lbl3_2);
            Col3.Add(lbl3_3);
            Col3.Add(lbl3_4);
            Col3.Add(lbl3_5);
            Col3.Add(lbl3_6);

            Col4.Add(lbl4_1);
            Col4.Add(lbl4_2);
            Col4.Add(lbl4_3);
            Col4.Add(lbl4_4);
            Col4.Add(lbl4_5);
            Col4.Add(lbl4_6);

            Col5.Add(lbl5_1);
            Col5.Add(lbl5_2);
            Col5.Add(lbl5_3);
            Col5.Add(lbl5_4);
            Col5.Add(lbl5_5);
            Col5.Add(lbl5_6);

            Col6.Add(lbl6_1);
            Col6.Add(lbl6_2);
            Col6.Add(lbl6_3);
            Col6.Add(lbl6_4);
            Col6.Add(lbl6_5);
            Col6.Add(lbl6_6);

            Col7.Add(lbl7_1);
            Col7.Add(lbl7_2);
            Col7.Add(lbl7_3);
            Col7.Add(lbl7_4);
            Col7.Add(lbl7_5);
            Col7.Add(lbl7_6);

            Board.Add(Col1);
            Board.Add(Col2);
            Board.Add(Col3);
            Board.Add(Col4);
            Board.Add(Col5);
            Board.Add(Col6);
            Board.Add(Col7);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
       /* private void lblBorderColor(object sender PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, label1.DisplayRectangle, Color.Blue, ButtonBorderStyle.Solid);

        }*/
        private void TurnCheck()
        {
            if ((Turn % 2) == 1)
            {
                int nameLength = p1p.Name.Length;
                if (p1p.Name[nameLength - 1].ToString().ToLower() == "s")
                    lblTurn.Text = "It's " + p1p.Name + "' Turn!";
                else
                    lblTurn.Text = "It's " + p1p.Name + "'s Turn!";

                lblTurn.ForeColor = p1p.Color;
            }
            else
            {
                int nameLength = p2p.Name.Length;
                if (p2p.Name[nameLength - 1].ToString().ToLower() == "s")
                    lblTurn.Text = "It's " + p2p.Name + "' Turn!";
                else
                    lblTurn.Text = "It's " + p2p.Name + "'s Turn!";

                lblTurn.ForeColor = p2p.Color;


            }


        }
        private void clearBoard()
        {
            DialogResult playAgain = MessageBox.Show("Would you like to play again?", "Play Again", MessageBoxButtons.YesNo);
            if (playAgain == DialogResult.Yes)
            {
                for (int x = 0; x < 7; x++)
                    for (int y = 0; y < 6; y++)
                        Board[x][y].BackColor = lblTurn.BackColor;
            }
            else
            {
                LeaderBoards scores = new LeaderBoards(p1p, p2p, pList);
                this.Visible = false;
                scores.ShowDialog();
                this.Close();


            }

        }
        private void CheckWin()
        {
            int x, y;
            System.Drawing.Color winningColor = lblTurn.BackColor;
            System.Drawing.Color blank = lblTurn.BackColor;
            bool win = false;
            //Horizontal checking
            for(y = 0; y < 6; y++)
            {
                for (x = 0; x < 4; x++)
                {
                    if (Board[x][y].BackColor == Board[x + 1][y].BackColor && Board[x + 1][y].BackColor == Board[x + 2][y].BackColor && Board[x + 2][y].BackColor == Board[x + 3][y].BackColor && Board[x][y].BackColor != blank && Board[x+1][y].BackColor != blank && Board[x+2][y].BackColor != blank && Board[x+3][y].BackColor != blank )
                    {
                        winningColor = Board[x][y].BackColor;
                        win = true;
                        break;
                    }
                }
                    if (win)
                    {
                        if (p1p.Color.ToString() == winningColor.ToString())
                        {
                            p1p.GamesWon += 1;
                            lblWins1.Text = p1p.Name + " won " + p1p.GamesWon + " times total."; 
                            MessageBox.Show(p1p.Name + " wins!");
                            clearBoard();
                            win = false;

                        }
                        else if (p2p.Color.ToString() == winningColor.ToString())
                        {
                            p2p.GamesWon += 1;
                            lblWins2.Text = p2p.Name + " won " + p2p.GamesWon + " times total.";
                            MessageBox.Show(p2p.Name + " wins!");
                            win = false;
                            clearBoard();
                        }
                        else
                            win = false;

                        break;
                    }
            }

            //Vertical Checking
            if (win == false)
            {
                for (x = 0; x < 7; x++)
                {
                    for (y = 0; y < 3; y++)
                    {
                        if (Board[x][y].BackColor == Board[x][y + 1].BackColor && Board[x][y + 1].BackColor == Board[x][y + 2].BackColor && Board[x][y + 2].BackColor == Board[x][y + 3].BackColor && Board[x][y].BackColor != blank && Board[x][y + 1].BackColor != blank && Board[x][y + 2].BackColor != blank && Board[x][y + 3].BackColor != blank)
                        {
                            winningColor = Board[x][y].BackColor;
                            win = true;
                            break;
                        }

                    }
                    if (win)
                    {
                        if (p1p.Color.ToString() == winningColor.ToString())
                        {
                            p1p.GamesWon += 1;
                            lblWins1.Text = p1p.Name + " won " + p1p.GamesWon + " times total."; 
                            MessageBox.Show(p1p.Name + " wins!");
                            win = false;
                            clearBoard();

                        }
                        else if (p2p.Color.ToString() == winningColor.ToString())
                        {
                            p2p.GamesWon += 1;
                            lblWins2.Text = p2p.Name + " won " + p2p.GamesWon + " times total.";
                            MessageBox.Show(p2p.Name + " wins!");
                            win = false;
                            clearBoard();
                        }
                        else
                            win = false;

                        break;
                    }

                }
            }

            //Downward Diagonal Checking
            if (win == false)
            {
                for (x = 0; x < 4; x++)
                {
                    for (y = 0; y < 3; y++)
                    {
                        if (Board[x][y].BackColor == Board[x + 1][y + 1].BackColor && Board[x + 1][y + 1].BackColor == Board[x + 2][y + 2].BackColor && Board[x + 2][y + 2].BackColor == Board[x + 3][y + 3].BackColor && Board[x][y].BackColor != blank && Board[x + 1][y + 1].BackColor != blank && Board[x + 2][y + 2].BackColor != blank && Board[x + 3][y + 3].BackColor != blank)
                        {
                            winningColor = Board[x][y].BackColor;
                            win = true;
                            break;
                        }

                    }
                    if (win)
                    {
                        if (p1p.Color.ToString() == winningColor.ToString())
                        {
                            p1p.GamesWon += 1;
                            lblWins1.Text = p1p.Name + " won " + p1p.GamesWon + " times total.";                            
                            MessageBox.Show(p1p.Name + " wins!");
                            win = false;
                            clearBoard();

                        }
                        else if (p2p.Color.ToString() == winningColor.ToString())
                        {
                            p2p.GamesWon += 1;
                            lblWins2.Text = p2p.Name + " won " + p2p.GamesWon + " times total.";
                            MessageBox.Show(p2p.Name + " wins!");
                            win = false;
                            clearBoard();
                        }
                        else
                            win = false;

                        break;
                    }

                }
            }

            //Upward Diagonal Checking
            if (win == false)
            {
                for (y = 3; y < 6; y++)
                {
                    for (x = 0; x < 4; x++)
                    {
                        if (Board[x][y].BackColor == Board[x + 1][y - 1].BackColor && Board[x + 1][y - 1].BackColor == Board[x + 2][y - 2].BackColor && Board[x + 2][y - 2].BackColor == Board[x + 3][y - 3].BackColor && Board[x][y].BackColor != blank && Board[x + 1][y - 1].BackColor != blank && Board[x + 2][y - 2].BackColor != blank && Board[x + 3][y - 3].BackColor != blank)
                        {
                            winningColor = Board[x][y].BackColor;
                            win = true;
                            break;
                        }
                    }

                    if (win)
                    {
                        if (p1p.Color.ToString() == winningColor.ToString())
                        {
                            p1p.GamesWon += 1;
                            lblWins1.Text = p1p.Name + " won " + p1p.GamesWon + " times total.";
                            MessageBox.Show(p1p.Name + " wins!");
                            win = false;                            
                            clearBoard();

                        }
                        else if (p2p.Color.ToString() == winningColor.ToString())
                        {
                            p2p.GamesWon += 1;
                            lblWins2.Text = p2p.Name + " won " + p2p.GamesWon + " times total.";
                            MessageBox.Show(p2p.Name + " wins!");
                            win = false;                            
                            clearBoard();
                        }
                        else
                            win = false;

                        break;
                    }
                }

            }

        }
        private void btnCol1_Click(object sender, EventArgs e)
        {
            if ((Turn % 2) == 1)
            {
                


                if (lbl1_6.BackColor.ToString() == "Color [White]")
                {
                    lbl1_6.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl1_5.BackColor.ToString() == "Color [White]")
                {
                    lbl1_5.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl1_4.BackColor.ToString() == "Color [White]")
                {
                    lbl1_4.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl1_3.BackColor.ToString() == "Color [White]")
                {
                    lbl1_3.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl1_2.BackColor.ToString() == "Color [White]")
                {
                    lbl1_2.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl1_1.BackColor.ToString() == "Color [White]")
                {
                    lbl1_1.BackColor = p1p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();

            }
            else
            {
                


                if (lbl1_6.BackColor.ToString() == "Color [White]")
                {
                    lbl1_6.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl1_5.BackColor.ToString() == "Color [White]")
                {
                    lbl1_5.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl1_4.BackColor.ToString() == "Color [White]")
                {
                    lbl1_4.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl1_3.BackColor.ToString() == "Color [White]")
                {
                    lbl1_3.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl1_2.BackColor.ToString() == "Color [White]")
                {
                    lbl1_2.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl1_1.BackColor.ToString() == "Color [White]")
                {
                    lbl1_1.BackColor = p2p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();

            }
        }

        private void btnCol2_Click(object sender, EventArgs e)
        {

            if ((Turn % 2) == 1)
            {



                if (lbl2_6.BackColor.ToString() == "Color [White]")
                {
                    lbl2_6.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl2_5.BackColor.ToString() == "Color [White]")
                {
                    lbl2_5.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl2_4.BackColor.ToString() == "Color [White]")
                {
                    lbl2_4.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl2_3.BackColor.ToString() == "Color [White]")
                {
                    lbl2_3.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl2_2.BackColor.ToString() == "Color [White]")
                {
                    lbl2_2.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl2_1.BackColor.ToString() == "Color [White]")
                {
                    lbl2_1.BackColor = p1p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();
            }
            else
            {



                if (lbl2_6.BackColor.ToString() == "Color [White]")
                {
                    lbl2_6.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl2_5.BackColor.ToString() == "Color [White]")
                {
                    lbl2_5.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl2_4.BackColor.ToString() == "Color [White]")
                {
                    lbl2_4.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl2_3.BackColor.ToString() == "Color [White]")
                {
                    lbl2_3.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl2_2.BackColor.ToString() == "Color [White]")
                {
                    lbl2_2.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl2_1.BackColor.ToString() == "Color [White]")
                {
                    lbl2_1.BackColor = p2p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();

            }

        }

        private void btnCol3_Click(object sender, EventArgs e)
        {

            if ((Turn % 2) == 1)
            {



                if (lbl3_6.BackColor.ToString() == "Color [White]")
                {
                    lbl3_6.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl3_5.BackColor.ToString() == "Color [White]")
                {
                    lbl3_5.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl3_4.BackColor.ToString() == "Color [White]")
                {
                    lbl3_4.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl3_3.BackColor.ToString() == "Color [White]")
                {
                    lbl3_3.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl3_2.BackColor.ToString() == "Color [White]")
                {
                    lbl3_2.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl3_1.BackColor.ToString() == "Color [White]")
                {
                    lbl3_1.BackColor = p1p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();
            }
            else
            {



                if (lbl3_6.BackColor.ToString() == "Color [White]")
                {
                    lbl3_6.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl3_5.BackColor.ToString() == "Color [White]")
                {
                    lbl3_5.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl3_4.BackColor.ToString() == "Color [White]")
                {
                    lbl3_4.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl3_3.BackColor.ToString() == "Color [White]")
                {
                    lbl3_3.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl3_2.BackColor.ToString() == "Color [White]")
                {
                    lbl3_2.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl3_1.BackColor.ToString() == "Color [White]")
                {
                    lbl3_1.BackColor = p2p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();
            }

        }

        private void btnCol4_Click(object sender, EventArgs e)
        {


            if ((Turn % 2) == 1)
            {



                if (lbl4_6.BackColor.ToString() == "Color [White]")
                {
                    lbl4_6.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl4_5.BackColor.ToString() == "Color [White]")
                {
                    lbl4_5.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl4_4.BackColor.ToString() == "Color [White]")
                {
                    lbl4_4.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl4_3.BackColor.ToString() == "Color [White]")
                {
                    lbl4_3.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl4_2.BackColor.ToString() == "Color [White]")
                {
                    lbl4_2.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl4_1.BackColor.ToString() == "Color [White]")
                {
                    lbl4_1.BackColor = p1p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();

            }
            else
            {



                if (lbl4_6.BackColor.ToString() == "Color [White]")
                {
                    lbl4_6.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl4_5.BackColor.ToString() == "Color [White]")
                {
                    lbl4_5.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl4_4.BackColor.ToString() == "Color [White]")
                {
                    lbl4_4.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl4_3.BackColor.ToString() == "Color [White]")
                {
                    lbl4_3.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl4_2.BackColor.ToString() == "Color [White]")
                {
                    lbl4_2.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl4_1.BackColor.ToString() == "Color [White]")
                {
                    lbl4_1.BackColor = p2p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();
            }


        }

        private void btnCol5_Click(object sender, EventArgs e)
        {


            if ((Turn % 2) == 1)
            {



                if (lbl5_6.BackColor.ToString() == "Color [White]")
                {
                    lbl5_6.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl5_5.BackColor.ToString() == "Color [White]")
                {
                    lbl5_5.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl5_4.BackColor.ToString() == "Color [White]")
                {
                    lbl5_4.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl5_3.BackColor.ToString() == "Color [White]")
                {
                    lbl5_3.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl5_2.BackColor.ToString() == "Color [White]")
                {
                    lbl5_2.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl5_1.BackColor.ToString() == "Color [White]")
                {
                    lbl5_1.BackColor = p1p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();

            }
            else
            {



                if (lbl5_6.BackColor.ToString() == "Color [White]")
                {
                    lbl5_6.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl5_5.BackColor.ToString() == "Color [White]")
                {
                    lbl5_5.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl5_4.BackColor.ToString() == "Color [White]")
                {
                    lbl5_4.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl5_3.BackColor.ToString() == "Color [White]")
                {
                    lbl5_3.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl5_2.BackColor.ToString() == "Color [White]")
                {
                    lbl5_2.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl5_1.BackColor.ToString() == "Color [White]")
                {
                    lbl5_1.BackColor = p2p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();
            }


        }

        private void btnCol6_Click(object sender, EventArgs e)
        {
            if ((Turn % 2) == 1)
            {



                if (lbl6_6.BackColor.ToString() == "Color [White]")
                {
                    lbl6_6.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl6_5.BackColor.ToString() == "Color [White]")
                {
                    lbl6_5.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl6_4.BackColor.ToString() == "Color [White]")
                {
                    lbl6_4.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl6_3.BackColor.ToString() == "Color [White]")
                {
                    lbl6_3.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl6_2.BackColor.ToString() == "Color [White]")
                {
                    lbl6_2.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl6_1.BackColor.ToString() == "Color [White]")
                {
                    lbl6_1.BackColor = p1p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();

            }
            else
            {



                if (lbl6_6.BackColor.ToString() == "Color [White]")
                {
                    lbl6_6.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl6_5.BackColor.ToString() == "Color [White]")
                {
                    lbl6_5.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl6_4.BackColor.ToString() == "Color [White]")
                {
                    lbl6_4.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl6_3.BackColor.ToString() == "Color [White]")
                {
                    lbl6_3.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl6_2.BackColor.ToString() == "Color [White]")
                {
                    lbl6_2.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl6_1.BackColor.ToString() == "Color [White]")
                {
                    lbl6_1.BackColor = p2p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();
            }
        }

        private void btnCol7_Click(object sender, EventArgs e)
        {


            if ((Turn % 2) == 1)
            {



                if (lbl7_6.BackColor.ToString() == "Color [White]")
                {
                    lbl7_6.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl7_5.BackColor.ToString() == "Color [White]")
                {
                    lbl7_5.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl7_4.BackColor.ToString() == "Color [White]")
                {
                    lbl7_4.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl7_3.BackColor.ToString() == "Color [White]")
                {
                    lbl7_3.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl7_2.BackColor.ToString() == "Color [White]")
                {
                    lbl7_2.BackColor = p1p.Color;
                    Turn++;
                }
                else if (lbl7_1.BackColor.ToString() == "Color [White]")
                {
                    lbl7_1.BackColor = p1p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();

            }
            else
            {



                if (lbl7_6.BackColor.ToString() == "Color [White]")
                {
                    lbl7_6.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl7_5.BackColor.ToString() == "Color [White]")
                {
                    lbl7_5.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl7_4.BackColor.ToString() == "Color [White]")
                {
                    lbl7_4.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl7_3.BackColor.ToString() == "Color [White]")
                {
                    lbl7_3.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl7_2.BackColor.ToString() == "Color [White]")
                {
                    lbl7_2.BackColor = p2p.Color;
                    Turn++;
                }
                else if (lbl7_1.BackColor.ToString() == "Color [White]")
                {
                    lbl7_1.BackColor = p2p.Color;
                    Turn++;
                }
                else
                    MessageBox.Show("This column is full, must select another column");

                TurnCheck();
                CheckWin();
            }


        }

        private void ConnectFour_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
