using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidnightProblem
{
    public static class MainMethods
    {
        
        /*
        public static void PrintText(Quote quote)
        {
            Console.WriteLine(quote.Text);
        }

        public static void PrintMenu(Quote quote)
        {
            for (int i = 0; i < quote.Menu.Count; i++)
            {
                Console.WriteLine(i + ". " + quote.Menu.ElementAt(i).Text);
            }
        }

        public static void ReadPlayerChoice() 
        {
        
        }*/

        /// <summary>
        /// Tato metoda slouží pro naplnění quotů. Počítám s počtem řetězců do 1000, takže se nebojím to držet v paměti.
        /// </summary>
        public static void InitMethod()
        {
            //vytvoření quotů
            Quote quote0 = new Quote(0, "WELCOME to Mindfuck'o'matic 2000!!!");
            Quote quote1 = new Quote(1, "What the hell are u finking?");
            Quote quote2 = new Quote(2, "Yo so nice, mucq!");
            //vytvoření vazeb mezi quoty
            quote0.Menu.Add(new MenuItem(0, "You piece of shit!", quote1));
            quote0.Menu.Add(new MenuItem(1, "What a sweet name you have!", quote2));
            //naplnění seznamu quotů
            ListOfQuotes.AddQuote(quote0);
            ListOfQuotes.AddQuote(quote1);

            quote0.PrintText();
        }

    }
}
