using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotes
{
    public class QuoteLogic
    {
        public string[] GetQuote()
        {
            string[] quotes = new string[]
            {"\"Don't cry because it's over, smile because it happened.\"",
                "\"I'm selfish, impatient and a little insecure. I make mistakes, I am out of control and at times hard to handle. But if you can't handle me at my worst, then you sure as hell don't deserve me at my best.\"",
                "\"Be yourself; everyone else is already taken.\"",
                "\"Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.\"",
                "\"Be who you are and say what you feel, because those who mind don't matter, and those who matter don't mind.\"",
                "\"You've gotta dance like there's nobody watching, \n Love like you'll never be hurt, \n Sing like there's nobody listening, \n And live like it's heaven on earth.\"",
                "\"So many books, so little time.\"",
                "\"A room without books is like a body without a soul.\"",
                "\"You only live once, but if you do it right, once is enough.\"",
                "\"Be the change that you wish to see in the world.\""};

            string[] authors = new string[]
            {"Dr. Seuss",
                "Marilyn Monroe",
                "Oscar Wilde",
                "Albert Einstein",
                "Bernard M. Baruch",
                "William W. Purkey",
                "Frank Zappa",
                "Marcus Tullius Cicero",
                "Mae West",
                "Mahatma Gandhi" };

            DateTime startDay = new DateTime(1, 1, 1, 1, 1, 1);

            DateTime today = DateTime.Today;

            TimeSpan timeFromStartDay = today.Subtract(startDay);

            int quoteNumber = (timeFromStartDay.Days % quotes.Length);

            string[] quoteAndAuthor = new string[] {quotes[quoteNumber], authors[quoteNumber]};

            return(quoteAndAuthor);
        }
    }
}
