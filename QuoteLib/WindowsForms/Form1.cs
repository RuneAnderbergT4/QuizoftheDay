using Quotes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuoteLogic quote = new QuoteLogic();

            string[] quoteAndAuthor = quote.GetQuote();

            output.Text = (quoteAndAuthor[0] + "\n-" + quoteAndAuthor[1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
