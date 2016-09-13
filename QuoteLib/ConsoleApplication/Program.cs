using Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteLogic quote = new QuoteLogic();

            string[] quoteAndAuthor = quote.GetQuote();

            Console.WriteLine(quoteAndAuthor[0] + "\n-" + quoteAndAuthor[1]);

            Console.ReadKey(true);
        }
    }
}
