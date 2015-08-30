using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four
{
    public class ProPlayer : Player
    {
        private System.Drawing.Color border;

        public System.Drawing.Color Border
        {

            get { return border; }
            set { border = @value; }


        }
    }
}
