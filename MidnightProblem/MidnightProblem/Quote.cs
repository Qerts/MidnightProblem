using System;
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

        public Quote(int id, string text)
        {
            this.id = id;
            this.text = text;
            this.menu = new List<MenuItem>();
        }

        public void PrintText() 
        { 
            Console.WriteLine(Text);
            MakeAction();
        }
        private void MakeAction() 
        {
            PrintMenu();
        }
        private void PrintMenu() 
        {
            for (int i = 0; i < Menu.Count; i++)
            {
                Console.WriteLine((i+1) + ". " + Menu.ElementAt(i).Text);
            }
            ReadInput();
        }
        private void ReadInput() 
        {
            string choice = Console.ReadLine();
            int choiceNo = 0;
            if (!int.TryParse(choice, out choiceNo)) 
            {
                Console.WriteLine("Give me number please. I like numbers.");
                ReadInput();
            }
            else
            {
                for (int i = 0; i < Menu.Count; i++)
                {
                    if (i == choiceNo-1)
                    {
                        Menu.ElementAt(i).Quote.PrintText();
                    }
                }
            }
            
        }

    }
}
