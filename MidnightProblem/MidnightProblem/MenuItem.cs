using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidnightProblem
{
    public class MenuItem
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
