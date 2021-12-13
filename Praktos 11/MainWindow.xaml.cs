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
using System.Text.RegularExpressions;

namespace Praktos_11
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

        private void firstSolution(object sender, RoutedEventArgs e)
        {
            firstExpression.Items.Clear();
            string letter = "ab abab abab abababab abea";
            Regex regex = new Regex("a(b)");
            MatchCollection match = regex.Matches(letter);
            for (int i = 0; i < match.Count; i++)
            {
                firstExpression.Items.Add(match[i]);
            }
        }

        private void secondSolution(object sender, RoutedEventArgs e)
        {
            secondExpression.Items.Clear();
            string letters = "a.a aba aea";
            Regex regex1 = new Regex("a[.]a");
            MatchCollection matches1 = regex1.Matches(letters);
            for (int i = 0; matches1.Count > 0; i++)
            {
                secondExpression.Items.Add(matches1[i]);
            }
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дана строка 'ab abab abab abababab abea'. Напишите регулярное выражение, котороенайдет строки 'ab' повторяется 1 или более раз.Дана строка 'a.a aba aea'.Напишите регулярное выражение, которое найдетстроку a.a, не захватив остальные");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
