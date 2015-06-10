﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidnightProblem
{
    public class Quote
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

        private List<MenuItem> menu;

        public List<MenuItem> Menu
        {
            get { return menu; }
            set { menu = value; }
        }

        public Quote(int id, string text, List<MenuItem> menu) 
        {
            this.id = id;
            this.text = text;
            this.menu = menu;
        }
    }
}
