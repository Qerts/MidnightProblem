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
        }
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private Quote quote;

        public Quote Quote
        {
            get { return quote; }
            set { quote = value; }
        }

        public MenuItem(int id, string text, Quote quote) 
        {
            this.id = id;
            this.text = text;
            this.quote = quote;
        }
    }
}
