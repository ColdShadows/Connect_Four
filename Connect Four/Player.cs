using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four
{
    public class Player
    {
        private string name;
        private System.Drawing.Color color;
        private int gamesWon;

        public string Name
        {
            get { return name; }
            set { name = @value; }

        }
        public System.Drawing.Color Color
        {
            get { return color; }
            set { color = @value; }
            
        }
        public int GamesWon
        {
            get { return gamesWon; }
            set { gamesWon = @value; }

        }
    }
}
