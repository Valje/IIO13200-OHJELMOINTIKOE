using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace H3340_T1b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BL logics = new BL();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCheckLetters_Click(object sender, RoutedEventArgs e)
        {
            lblLetterCounts.Content = "";

            Result result = logics.getLetterCounts(tbInput.Text);
            

            foreach (var a in result.listOfKeys)
            {
                lblLetterCounts.Content += a + " = " + result.resultCount[a] + "\n";
            }

            lblLetterCounts.Content += "\n" +
                "Yhteensä " +
                result.goodChars +
                " sallittua merkkiä ja " +
                result.amount +
                " eri kirjainta.";
        }
    }
}
