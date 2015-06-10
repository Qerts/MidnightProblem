using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidnightProblem
{
    public static class ListOfQuotes
    {
        private static List<Quote> list = new List<Quote>();
        public static void AddQuote(Quote quota) 
        {
            if (GetQuote(quota.Id) == null)
            {
                list.Add(quota);
            }           
        }

        public static Quote GetQuote(int id) 
        {
            foreach (var quote in list)
            {
                if (quote.Id == id)
                {
                    return quote;
                }                
            }
            return null;
        }

        public static void DeleteQuote(Quote quote) 
        {
            //list.Remove()
        }

        

    }
}
