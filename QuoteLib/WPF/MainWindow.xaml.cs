using Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void output_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Quote_of_the_Day_Loaded(object sender, RoutedEventArgs e)
        {
            QuoteLogic quote = new QuoteLogic();

            string[] quoteAndAuthor = quote.GetQuote();

            output.Document.Blocks.Add(new Paragraph(new Run(quoteAndAuthor[0] + "\n-" + quoteAndAuthor[1])));
        }
    }
}
